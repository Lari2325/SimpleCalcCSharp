using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string currentOperation = "";
        private bool isOperationPressed = false;

        private Panel panelTitle;
        private Button btnClose;

        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();

            // Definir o título da janela
            this.Text = "Calculadora";

            // Configurar a cor
            ConfigureColors();

            // Definir o ícone da janela
            string iconPath = "favicon.ico";
            if (System.IO.File.Exists(iconPath))
            {
                this.Icon = new Icon(iconPath);
            }
            else
            {
                MessageBox.Show("Ícone não encontrado!");
            }

            panelTitle = new Panel
            {
                Dock = DockStyle.Top,
                Height = 30,
                BackColor = ColorTranslator.FromHtml("#004480"), 
            };

            btnClose = new Button
            {
                Text = "X",
                Dock = DockStyle.Right,
                Width = 30,
                BackColor = ColorTranslator.FromHtml("#004480"), 
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 }
            };

            btnClose.Click += BtnClose_Click;

            panelTitle.Controls.Add(btnClose);
            this.Controls.Add(panelTitle);
            this.FormBorderStyle = FormBorderStyle.None;

            panelTitle.MouseDown += PanelTitle_MouseDown;
            panelTitle.MouseMove += PanelTitle_MouseMove;
            panelTitle.MouseUp += PanelTitle_MouseUp;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(delta));
            }
        }

        private void PanelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ConfigureColors()
        {
            Color colorSystem = ColorTranslator.FromHtml("#afd1ee");

            this.BackColor = colorSystem; 

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

            btnEqual.BackColor = Color.FromArgb(242, 214, 214, 255); 
            btnEqual.ForeColor = Color.DarkBlue;

            btnClear.BackColor = Color.FromArgb(242, 214, 214, 255); 
            btnClear.ForeColor = Color.DarkBlue; 

            btnSqrt.BackColor = Color.FromArgb(255, 202, 239, 128);
            btnSqrt.ForeColor = Color.Black; 

            btnSquare.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnSquare.ForeColor = Color.Black; 

            btnSine.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnSine.ForeColor = Color.Black; 

            btnCosine.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnCosine.ForeColor = Color.Black; 

            btnTangent.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnTangent.ForeColor = Color.Black; 

            btnLog.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnLog.ForeColor = Color.Black; 

            btnExp.BackColor = Color.FromArgb(255, 202, 239, 128); 
            btnExp.ForeColor = Color.Black; 

            btnDecimal.BackColor = Color.LightGreen; 
            btnDecimal.ForeColor = Color.Black; 

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