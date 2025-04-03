namespace MyFirstCalculator
{
    partial class FormCalculator
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
            textBox_UserInput1 = new TextBox();
            textBox1_UserInput2 = new TextBox();
            label1_UserInput1 = new Label();
            label1_UserInput2 = new Label();
            button_Add = new Button();
            button_Multiply = new Button();
            label_Sum = new Label();
            button_Subtract = new Button();
            button_Divide = new Button();
            button_Clear = new Button();
            SuspendLayout();
            // 
            // textBox_UserInput1
            // 
            textBox_UserInput1.Location = new Point(116, 79);
            textBox_UserInput1.Multiline = true;
            textBox_UserInput1.Name = "textBox_UserInput1";
            textBox_UserInput1.Size = new Size(125, 36);
            textBox_UserInput1.TabIndex = 0;
            // 
            // textBox1_UserInput2
            // 
            textBox1_UserInput2.Location = new Point(112, 147);
            textBox1_UserInput2.Multiline = true;
            textBox1_UserInput2.Name = "textBox1_UserInput2";
            textBox1_UserInput2.Size = new Size(129, 35);
            textBox1_UserInput2.TabIndex = 1;
            // 
            // label1_UserInput1
            // 
            label1_UserInput1.AutoSize = true;
            label1_UserInput1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1_UserInput1.Location = new Point(116, 51);
            label1_UserInput1.Name = "label1_UserInput1";
            label1_UserInput1.Size = new Size(113, 15);
            label1_UserInput1.TabIndex = 2;
            label1_UserInput1.Text = "Enter first number:";
            label1_UserInput1.Click += label1_Click;
            // 
            // label1_UserInput2
            // 
            label1_UserInput2.AutoSize = true;
            label1_UserInput2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1_UserInput2.Location = new Point(112, 129);
            label1_UserInput2.Name = "label1_UserInput2";
            label1_UserInput2.Size = new Size(129, 15);
            label1_UserInput2.TabIndex = 3;
            label1_UserInput2.Text = "Enter second number:";
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.LightSkyBlue;
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.Location = new Point(60, 283);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(95, 52);
            button_Add.TabIndex = 4;
            button_Add.Text = "ADD";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // button_Multiply
            // 
            button_Multiply.BackColor = Color.PaleGreen;
            button_Multiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Multiply.Location = new Point(208, 283);
            button_Multiply.Name = "button_Multiply";
            button_Multiply.Size = new Size(95, 52);
            button_Multiply.TabIndex = 5;
            button_Multiply.Text = "MULTIPLY";
            button_Multiply.UseVisualStyleBackColor = false;
            button_Multiply.Click += button_Multiply_Click;
            // 
            // label_Sum
            // 
            label_Sum.AutoSize = true;
            label_Sum.Location = new Point(78, 229);
            label_Sum.Name = "label_Sum";
            label_Sum.Size = new Size(46, 15);
            label_Sum.TabIndex = 6;
            label_Sum.Text = "RESULT";
            // 
            // button_Subtract
            // 
            button_Subtract.BackColor = Color.Plum;
            button_Subtract.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Subtract.Location = new Point(60, 353);
            button_Subtract.Name = "button_Subtract";
            button_Subtract.Size = new Size(112, 52);
            button_Subtract.TabIndex = 8;
            button_Subtract.Text = "SUBTRACT";
            button_Subtract.UseVisualStyleBackColor = false;
            button_Subtract.Click += button_Subtract_Click;
            // 
            // button_Divide
            // 
            button_Divide.BackColor = Color.Aquamarine;
            button_Divide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Divide.Location = new Point(208, 353);
            button_Divide.Name = "button_Divide";
            button_Divide.Size = new Size(95, 52);
            button_Divide.TabIndex = 9;
            button_Divide.Text = "DIVIDE";
            button_Divide.UseVisualStyleBackColor = false;
            button_Divide.Click += button_Divide_Click;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Crimson;
            button_Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.Location = new Point(126, 440);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(112, 52);
            button_Clear.TabIndex = 10;
            button_Clear.Text = "CLEAR ALL";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(385, 507);
            Controls.Add(button_Clear);
            Controls.Add(button_Divide);
            Controls.Add(button_Subtract);
            Controls.Add(label_Sum);
            Controls.Add(button_Multiply);
            Controls.Add(button_Add);
            Controls.Add(label1_UserInput2);
            Controls.Add(label1_UserInput1);
            Controls.Add(textBox1_UserInput2);
            Controls.Add(textBox_UserInput1);
            Name = "FormCalculator";
            Text = "Form1";
            Load += FormCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_UserInput1;
        private TextBox textBox1_UserInput2;
        private Label label1_UserInput1;
        private Label label1_UserInput2;
        private Button button_Add;
        private Button button_Multiply;
        private Label label_Sum;
        private Label label_Product;
        private Button button_Subtract;
        private Button button_Divide;
        private Button button_Clear;
    }
}
