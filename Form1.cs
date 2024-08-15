using System;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string currentOperation = "";
        private bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();

            //color
             ConfigureColors();
        }

        private void ConfigureColors()
        {
            this.BackColor = Color.LightGray; // Cor de fundo do formulário

            // Cores para botões numéricos
            Color buttonNumberBackColor = Color.LightBlue;
            Color buttonNumberForeColor = Color.DarkBlue;

            btnNumber0.BackColor = buttonNumberBackColor;
            btnNumber0.ForeColor = buttonNumberForeColor;
            btnNumber1.BackColor = buttonNumberBackColor;
            btnNumber1.ForeColor = buttonNumberForeColor;
            btnNumber2.BackColor = buttonNumberBackColor;
            btnNumber2.ForeColor = buttonNumberForeColor;
            btnNumber3.BackColor = buttonNumberBackColor;
            btnNumber3.ForeColor = buttonNumberForeColor;
            btnNumber4.BackColor = buttonNumberBackColor;
            btnNumber4.ForeColor = buttonNumberForeColor;
            btnNumber5.BackColor = buttonNumberBackColor;
            btnNumber5.ForeColor = buttonNumberForeColor;
            btnNumber6.BackColor = buttonNumberBackColor;
            btnNumber6.ForeColor = buttonNumberForeColor;
            btnNumber7.BackColor = buttonNumberBackColor;
            btnNumber7.ForeColor = buttonNumberForeColor;
            btnNumber8.BackColor = buttonNumberBackColor;
            btnNumber8.ForeColor = buttonNumberForeColor;
            btnNumber9.BackColor = buttonNumberBackColor;
            btnNumber9.ForeColor = buttonNumberForeColor;

            // Cores para botões de operação
            Color buttonOperationBackColor = Color.LightGreen;
            Color buttonOperationForeColor = Color.DarkGreen;

            btnAdd.BackColor = buttonOperationBackColor;
            btnAdd.ForeColor = buttonOperationForeColor;
            btnSubtract.BackColor = buttonOperationBackColor;
            btnSubtract.ForeColor = buttonOperationForeColor;
            btnMultiply.BackColor = buttonOperationBackColor;
            btnMultiply.ForeColor = buttonOperationForeColor;
            btnDivide.BackColor = buttonOperationBackColor;
            btnDivide.ForeColor = buttonOperationForeColor;

            btnEqual.BackColor = Color.FromArgb(255, 240, 128, 128); 
            btnEqual.ForeColor = Color.White;

            btnClear.BackColor = Color.Red; 
            btnClear.ForeColor = Color.White; 

            btnSqrt.BackColor = Color.LightYellow; 
            btnSqrt.ForeColor = Color.Black; 

            btnSquare.BackColor = Color.LightYellow; 
            btnSquare.ForeColor = Color.Black; 

            btnSine.BackColor = Color.LightYellow; 
            btnSine.ForeColor = Color.Black; 

            btnCosine.BackColor = Color.LightYellow; 
            btnCosine.ForeColor = Color.Black; 

            btnTangent.BackColor = Color.LightYellow; 
            btnTangent.ForeColor = Color.Black; 

            btnLog.BackColor = Color.LightYellow; 
            btnLog.ForeColor = Color.Black; 

            btnExp.BackColor = Color.LightYellow; 
            btnExp.ForeColor = Color.Black; 

            txtDisplay.BackColor = Color.White; 
            txtDisplay.ForeColor = Color.Black; 
        }
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || isOperationPressed)
            {
                txtDisplay.Clear();
            }

            isOperationPressed = false;
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPressed = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            
            switch (currentOperation)
            {
                case "+":
                    txtDisplay.Text = (result + currentValue).ToString("0.##");
                    break;
                case "-":
                    txtDisplay.Text = (result - currentValue).ToString("0.##");
                    break;
                case "*":
                    txtDisplay.Text = (result * currentValue).ToString("0.##");
                    break;
                case "/":
                    if (currentValue != 0)
                    {
                        txtDisplay.Text = (result / currentValue).ToString("0.##");
                    }
                    else
                    {
                        txtDisplay.Text = "Error"; // Error handling for division by zero
                    }
                    break;
                default:
                    break;
            }
            result = double.Parse(txtDisplay.Text);
            currentOperation = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            currentOperation = "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(value).ToString("0.##");
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (value * value).ToString("0.##");
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(DegreeToRadian(value)).ToString("0.##");
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(DegreeToRadian(value)).ToString("0.##");
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Tan(DegreeToRadian(value)).ToString("0.##");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Log10(value).ToString("0.##");
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Exp(value).ToString("0.##");
        }

        private double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }
    }
}