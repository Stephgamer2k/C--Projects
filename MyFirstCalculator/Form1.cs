namespace MyFirstCalculator
{
    public partial class FormCalculator : Form
    {
        double num1;
        double num2;
        double sum;
        double product;
        double subtraction;
        double division;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox_UserInput1.Text);
                num2 = Double.Parse(textBox1_UserInput2.Text);
                sum = num1 + num2;

                label_Sum.Text = "Addition result: " + sum;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {

            try
            {
                num1 = Double.Parse(textBox_UserInput1.Text);
                num2 = Double.Parse(textBox1_UserInput2.Text);

                product = num1 * num2;
                label_Sum.Text = "Product result: " + product;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {

            try
            {
                num1 = Double.Parse(textBox_UserInput1.Text);
                num2 = Double.Parse(textBox1_UserInput2.Text);

                //subtraction = num1 - num2;
                if (num1 > num2)
                {
                    subtraction = num1 - num2;
                }
                else
                {
                    subtraction = num2 - num1;
                }

                label_Sum.Text = "Subtraction result: " + subtraction;

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox_UserInput1.Text);
                num2 = Double.Parse(textBox1_UserInput2.Text);

                //division = num1 / num2;
                if (num1 > num2)
                {
                    division = num1 / num2;
                }
                else
                {
                    division = num2 / num1;
                }
                label_Sum.Text = "Division result: " + division;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by zero", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            label_Sum.Text = string.Empty;
        }
    }
}
