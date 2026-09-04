namespace Calculator
{
    public partial class Calculator : Form
    {
        //declare variables
        private string input = "";
        private string operand1 = "";
        private string operand2 = "";
        private char operation;
        private double output = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            DisplayTxtBox.Text = input;
        }

        private void Operators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand1 = input;
            operation = button.Text[0];
            input = "";
        }

        private void Equal(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    output = num1 + num2;
                    break;

                case '-':
                    output = num1 - num2;
                    break;

                case '*':
                    output = num1 * num2;
                    break;

                case '/':
                    output = num1 / num2;
                    break;
            }

            DisplayTxtBox.Text = output.ToString();
            input = output.ToString();
        }

        private void Clear(object sender, EventArgs e)
        {
            input = "";
            operand1 = "";
            operand2 = "";
            DisplayTxtBox.Text = "";
        }
    }
}
