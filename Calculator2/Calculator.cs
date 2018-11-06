using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private string operationText;
        private string resultText;
        private bool perantesed;

        #region UpdateOnKeyboard
        private void UpdateOnKeyboard(object s, KeyPressEventArgs k)
        {
            string MyKeyboardText = k.KeyChar.ToString();

            if (operationTextBox.Text.Length > 18)
            {
                this.operationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                operationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            operationText = operationTextBox.Text.Replace("x", "*");
            byte asciiButtonText = Encoding.ASCII.GetBytes(MyKeyboardText)[0];

            if (asciiButtonText > 48 && asciiButtonText < 58 && operationTextBox.Text.Length<64)
            {
                numberClicked(MyKeyboardText);
            }
            else if (((MyKeyboardText == "/" || MyKeyboardText == "*" || MyKeyboardText == "-" || MyKeyboardText == "+")) && operationTextBox.Text.Length < 64)
            {
                operatoionClicked(MyKeyboardText);
            }
            else
            {
                switch (asciiButtonText)
                {
                    case 48:
                        if (operationTextBox.Text.Length < 64)
                        zeroClicked(MyKeyboardText);
                        break;
                    case 46:
                        if (operationTextBox.Text.Length < 64)
                        pointClicked(MyKeyboardText);
                        break;
                    case 27:
                        cClicked();
                        break;
                    case 40:
                        if (operationTextBox.Text.Length < 64)
                        ceClicked();
                        break;
                    case 41:
                        if (operationTextBox.Text.Length < 64)
                        ceClicked();
                        break;
                    case 8:
                        backSpaceClicked();
                        break;
                    case 13:
                        equalClicked();
                        break;
                }
            }
            operationTextBox.Text = operationText.Replace("*", "x");
            resultLabel.InputText = resultText;
            this.ActiveControl = operationTextBox;
            operationTextBox.Select(operationTextBox.Text.Length, 0);
        }
        #endregion \UpdateOnKeyboard

        #region UpdateOnClick
        public void UpdateOnClick()
        {
            if (operationTextBox.Text.Length > 18)
            {
                this.operationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {
                operationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            operationText = operationTextBox.Text.Replace("x", "*");
            byte asciiButtonText = Encoding.ASCII.GetBytes(MyButton.ButtonText)[0];

            if (asciiButtonText > 48 && asciiButtonText < 58 && operationTextBox.Text.Length < 64)
            {
                numberClicked(MyButton.ButtonText);
            }
            else if (((MyButton.ButtonText == "/" || MyButton.ButtonText == "x" || MyButton.ButtonText == "-" || MyButton.ButtonText == "+")) && operationTextBox.Text.Length < 64)
            {
                operatoionClicked(MyButton.ButtonText);
            }
            else
            {
                switch (MyButton.ButtonText)
                {
                    case "0":
                        if (operationTextBox.Text.Length < 64)
                        zeroClicked(MyButton.ButtonText);
                        break;
                    case ".":
                        if (operationTextBox.Text.Length < 64)
                            pointClicked(MyButton.ButtonText);
                        break;
                    case "C":
                        cClicked();
                        break;
                    case "()":
                        if (operationTextBox.Text.Length < 64)
                            ceClicked();
                        break;
                    case "<":
                        backSpaceClicked();
                        break;
                    case "=":
                        equalClicked();
                        break;
                }
            }
            operationTextBox.Text = operationText.Replace("*", "x");
            resultLabel.InputText = resultText;
            this.ActiveControl = operationTextBox;
            operationTextBox.Select(operationTextBox.Text.Length, 0);
        }
        #endregion \UpdateOnClick

        private void numberClicked(string s)
        {
            if (operationText == "0")
                operationText = s;
            else
                operationText += s;
        }

        private void zeroClicked(string s)
        {
            if (operationText == string.Empty)
                operationText = s;
            else if (operationText != "0")
                operationText += s;
        }

        private void pointClicked(string s)
        {
            if (operationText == string.Empty)
                operationText = "0.";
            else if (!operationText.Contains("."))
                operationText += s;
        }

        private void equalClicked()
        {
            try
            {
                if (operationText != string.Empty && operationText != "0" && !operationText.EndsWith(".") && !operationText.EndsWith("("))
                {
                    if (!operationText.EndsWith("+") && !operationText.EndsWith("-") && !operationText.EndsWith("*") && !operationText.EndsWith("/"))
                    {
                        if (perantesed) ceClicked();
                        resultText = Convert.ToString(Convert.ToDouble(new DataTable().Compute(operationText, null)));
                        operationText = string.Empty;
                    }
                    else if (operationText.Length != 1 || !operationText.EndsWith("-"))
                    {
                        if (perantesed)
                        {
                            operationText = operationText.Insert(operationText.Length - 1, ")");
                            perantesed = false;
                        }
                        resultText = Convert.ToString(Convert.ToDouble(new DataTable().Compute("(" +
                            operationText.Insert(operationText.Length - 1, ")") + "(" + operationText.Substring(0, operationText.Length - 1) + ")", null)));
                        operationText = string.Empty;
                    }
                    operationText = resultText;
                }
            }
            catch
            {
                MessageBox.Show("Check Parentheses !!!");
            }
        }

        private void operatoionClicked(string s)
        {
            try
            {
                if (operationText != string.Empty && operationText != "0" && !operationText.EndsWith(".") && !operationText.EndsWith("+") && !operationText.EndsWith("-") && !operationText.EndsWith("*") && !operationText.EndsWith("/") && !operationText.EndsWith("("))
                {
                    if (!perantesed)
                    {
                        resultText = Convert.ToString(Convert.ToDouble(new DataTable().Compute(operationText, null)));
                        operationText += s;
                    }
                    else
                    {
                        operationText += s;
                    }
                }
                else if (operationText == string.Empty && MyButton.ButtonText == "-")
                {
                    operationText += s;
                }
            }
            catch
            {
                MessageBox.Show("Check Parentheses !!!");
            }
        }

        private void cClicked()
        {
            operationText = string.Empty;
            resultText = string.Empty;
        }

        private void ceClicked()
        {
            if (!perantesed)
            {
                if (operationText.EndsWith("+") || operationText.EndsWith("-") || operationText.EndsWith("*") || operationText.EndsWith("/"))
                {
                    operationText += "(";
                    perantesed = true;
                }
            }
            else
            {
                if (!operationText.EndsWith("("))
                {
                    operationText += ")";
                }
                else
                {
                    operationText = operationText.Substring(0, operationText.Length - 1);
                }
                perantesed = false;
            }
        }

        private void backSpaceClicked()
        {
            if (operationText != string.Empty)
                operationText = operationText.Substring(0, operationText.Length - 1);
        }
    }
}
