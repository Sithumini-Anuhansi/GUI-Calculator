namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayTxtBox = new TextBox();
            BtnPlus = new Button();
            BtnMinus = new Button();
            BtnMul = new Button();
            BtnDiv = new Button();
            Btn0 = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn7 = new Button();
            Btn8 = new Button();
            Btn9 = new Button();
            BtnClear = new Button();
            BtnEqual = new Button();
            SuspendLayout();
            // 
            // DisplayTxtBox
            // 
            DisplayTxtBox.Location = new Point(12, 12);
            DisplayTxtBox.Name = "DisplayTxtBox";
            DisplayTxtBox.Size = new Size(423, 34);
            DisplayTxtBox.TabIndex = 0;
            // 
            // BtnPlus
            // 
            BtnPlus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPlus.Location = new Point(12, 61);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(94, 42);
            BtnPlus.TabIndex = 1;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += Operators;
            // 
            // BtnMinus
            // 
            BtnMinus.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMinus.Location = new Point(122, 61);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(94, 42);
            BtnMinus.TabIndex = 2;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += Operators;
            // 
            // BtnMul
            // 
            BtnMul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMul.Location = new Point(231, 61);
            BtnMul.Name = "BtnMul";
            BtnMul.Size = new Size(94, 42);
            BtnMul.TabIndex = 3;
            BtnMul.Text = "*";
            BtnMul.UseVisualStyleBackColor = true;
            BtnMul.Click += Operators;
            // 
            // BtnDiv
            // 
            BtnDiv.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDiv.Location = new Point(341, 61);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(94, 42);
            BtnDiv.TabIndex = 4;
            BtnDiv.Text = "/";
            BtnDiv.UseVisualStyleBackColor = true;
            BtnDiv.Click += Operators;
            // 
            // Btn0
            // 
            Btn0.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn0.Location = new Point(12, 118);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(94, 42);
            Btn0.TabIndex = 5;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Numbers;
            // 
            // Btn1
            // 
            Btn1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn1.Location = new Point(122, 118);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(94, 42);
            Btn1.TabIndex = 6;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Numbers;
            // 
            // Btn2
            // 
            Btn2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn2.Location = new Point(231, 118);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(94, 42);
            Btn2.TabIndex = 7;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Numbers;
            // 
            // Btn3
            // 
            Btn3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn3.Location = new Point(341, 118);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(94, 42);
            Btn3.TabIndex = 8;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Numbers;
            // 
            // Btn4
            // 
            Btn4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn4.Location = new Point(12, 176);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(94, 42);
            Btn4.TabIndex = 9;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += Numbers;
            // 
            // Btn5
            // 
            Btn5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn5.Location = new Point(122, 176);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(94, 42);
            Btn5.TabIndex = 10;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Numbers;
            // 
            // Btn6
            // 
            Btn6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn6.Location = new Point(231, 176);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(94, 42);
            Btn6.TabIndex = 11;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Numbers;
            // 
            // Btn7
            // 
            Btn7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn7.Location = new Point(341, 176);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(94, 42);
            Btn7.TabIndex = 12;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += Numbers;
            // 
            // Btn8
            // 
            Btn8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn8.Location = new Point(12, 234);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(94, 42);
            Btn8.TabIndex = 13;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Numbers;
            // 
            // Btn9
            // 
            Btn9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn9.Location = new Point(122, 234);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(94, 42);
            Btn9.TabIndex = 14;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Numbers;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(231, 234);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 42);
            BtnClear.TabIndex = 15;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += Clear;
            // 
            // BtnEqual
            // 
            BtnEqual.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEqual.Location = new Point(341, 234);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(94, 42);
            BtnEqual.TabIndex = 16;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = true;
            BtnEqual.Click += Equal;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(447, 286);
            Controls.Add(BtnEqual);
            Controls.Add(BtnClear);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Btn0);
            Controls.Add(BtnDiv);
            Controls.Add(BtnMul);
            Controls.Add(BtnMinus);
            Controls.Add(BtnPlus);
            Controls.Add(DisplayTxtBox);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DisplayTxtBox;
        private Button BtnPlus;
        private Button BtnMinus;
        private Button BtnMul;
        private Button BtnDiv;
        private Button Btn0;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnClear;
        private Button BtnEqual;
    }
}
