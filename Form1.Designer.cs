namespace CalculadoraCSharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2; 
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnSine;
        private System.Windows.Forms.Button btnCosine;
        private System.Windows.Forms.Button btnTangent;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnDecimal;

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSine = new System.Windows.Forms.Button();
            this.btnCosine = new System.Windows.Forms.Button();
            this.btnTangent = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // txtDisplay configuration
            this.txtDisplay.Location = new System.Drawing.Point(12, 40);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(240, 40);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Cursor = Cursors.Arrow;
            this.txtDisplay.Font = new Font("Arial", 14, FontStyle.Regular); 

            // Button 0 configuration
            this.btnNumber0.Location = new System.Drawing.Point(75, 195);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(60, 27);
            this.btnNumber0.TabIndex = 1;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber0.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 1 configuration
            this.btnNumber1.Location = new System.Drawing.Point(12, 165);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(60, 27);
            this.btnNumber1.TabIndex = 2;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.btnNumber_Click);
            
            // Button 2 configuration
            this.btnNumber2.Location = new System.Drawing.Point(75, 165);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(60, 27);
            this.btnNumber2.TabIndex = 3;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber2.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 3 configuration
            this.btnNumber3.Location = new System.Drawing.Point(135, 165);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(60, 27);
            this.btnNumber3.TabIndex = 4;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber3.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 4 configuration
            this.btnNumber4.Location = new System.Drawing.Point(12, 135);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(60, 27);
            this.btnNumber4.TabIndex = 5;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber4.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 5 configuration
            this.btnNumber5.Location = new System.Drawing.Point(75, 135);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(60, 27);
            this.btnNumber5.TabIndex = 6;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber5.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 6 configuration
            this.btnNumber6.Location = new System.Drawing.Point(135, 135);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(60, 27);
            this.btnNumber6.TabIndex = 7;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber6.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 7 configuration
            this.btnNumber7.Location = new System.Drawing.Point(12, 105);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(60, 27);
            this.btnNumber7.TabIndex = 8;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber7.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 8 configuration
            this.btnNumber8.Location = new System.Drawing.Point(75, 105);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(60, 27);
            this.btnNumber8.TabIndex = 9;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber8.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button 9 configuration
            this.btnNumber9.Location = new System.Drawing.Point(135, 105);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(60, 27);
            this.btnNumber9.TabIndex = 10;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.btnNumber_Click);
            this.btnNumber9.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Decimal configuration
            this.btnDecimal.Location = new System.Drawing.Point(135, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(60, 27);
            this.btnDecimal.TabIndex = 11;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            
            // Button Add configuration
            this.btnAdd.Location = new System.Drawing.Point(195, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 27);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperation_Click);
            this.btnAdd.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Subtract configuration
            this.btnSubtract.Location = new System.Drawing.Point(195, 135);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 27);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnOperation_Click);
            this.btnSubtract.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Multiply configuration
            this.btnMultiply.Location = new System.Drawing.Point(195, 165);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 27);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnOperation_Click);
            this.btnMultiply.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Divide configuration
            this.btnDivide.Location = new System.Drawing.Point(195, 195);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 27);
            this.btnDivide.TabIndex = 15;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnOperation_Click);
            this.btnDivide.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Equal configuration
            this.btnEqual.Location = new System.Drawing.Point(135, 225);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(60, 27);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Clear configuration
            this.btnClear.Location = new System.Drawing.Point(75, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 27);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Sqrt configuration
            this.btnSqrt.Location = new System.Drawing.Point(12, 195);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(60, 27);
            this.btnSqrt.TabIndex = 18;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            this.btnSqrt.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Square configuration
            this.btnSquare.Location = new System.Drawing.Point(12, 255);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(60, 27);
            this.btnSquare.TabIndex = 19;
            this.btnSquare.Text = "^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            this.btnSquare.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Sine configuration
            this.btnSine.Location = new System.Drawing.Point(75, 255);
            this.btnSine.Name = "btnSine";
            this.btnSine.Size = new System.Drawing.Size(60, 27);
            this.btnSine.TabIndex = 20;
            this.btnSine.Text = "sin";
            this.btnSine.UseVisualStyleBackColor = true;
            this.btnSine.Click += new System.EventHandler(this.btnSine_Click);
            this.btnSine.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Cosine configuration
            this.btnCosine.Location = new System.Drawing.Point(135, 255);
            this.btnCosine.Name = "btnCosine";
            this.btnCosine.Size = new System.Drawing.Size(60, 27);
            this.btnCosine.TabIndex = 21;
            this.btnCosine.Text = "cos";
            this.btnCosine.UseVisualStyleBackColor = true;
            this.btnCosine.Click += new System.EventHandler(this.btnCosine_Click);
            this.btnCosine.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Button Tangent configuration
            this.btnTangent.Location = new System.Drawing.Point(195, 255);
            this.btnTangent.Name = "btnTangent";
            this.btnTangent.Size = new System.Drawing.Size(60, 27);
            this.btnTangent.TabIndex = 22;
            this.btnTangent.Text = "tan";
            this.btnTangent.UseVisualStyleBackColor = true;
            this.btnTangent.Click += new System.EventHandler(this.btnTangent_Click);
            
            // Button Log configuration
            this.btnLog.Location = new System.Drawing.Point(195, 225);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(60, 27);
            this.btnLog.TabIndex = 23;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            
            // Button Exponential configuration
            this.btnExp.Location = new System.Drawing.Point(12, 225);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(60, 27);
            this.btnExp.TabIndex = 24;
            this.btnExp.Text = "exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            this.btnExp.Font = new Font("Arial", 10, FontStyle.Regular);
            
            // Form1 configuration
            this.ClientSize = new System.Drawing.Size(265, 300);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnTangent);
            this.Controls.Add(this.btnCosine);
            this.Controls.Add(this.btnSine);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNumber9);
            this.Controls.Add(this.btnNumber8);
            this.Controls.Add(this.btnNumber7);
            this.Controls.Add(this.btnNumber6);
            this.Controls.Add(this.btnNumber5);
            this.Controls.Add(this.btnNumber4);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnNumber0);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}