namespace WinFormsApplab1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click_1(object sender, EventArgs e)
        {
            if (TryReadNumber(out int n))
            {
                label1.Text = "Sum of digits: " + IntSumDigits(n);
            }
        }

        public void button2_Click_2(object sender, EventArgs e)
        {
            if (TryReadNumber(out int n))
            {
                label1.Text = "Even digits: " + IntCountEvenDigits(n);
            }
        }

        public int IntSumDigits(int number)
        {
            if (number < 0)
            {
                number = -number;
            }

            int total = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                total = total + lastDigit;
                number = number / 10;
            }

            return total;
        }

        public int IntCountEvenDigits(int number)
        {
            if (number < 0)
            {
                number = -number;
            }

            if (number == 0)
            {
                return 1;
            }

            int count = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    count++;
                }

                number = number / 10;
            }

            return count;
        }

        public bool TryReadNumber(out int number)
        {
            bool success = int.TryParse(txtNumber.Text, out number);

            if (success == false)
            {
                MessageBox.Show("Please enter a valid integer.");
            }

            return success;
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (TryReadNumber(out int n))
            {
                label1.Text = "Sum of digits: " + IntSumDigits(n);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (TryReadNumber(out int n))
            {
                label1.Text = "Even digits: " + IntCountEvenDigits(n);
            }
        }
    }
}
