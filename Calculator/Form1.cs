namespace Calculator
{
    public partial class Calculator : Form
    {
        int result = 0;
        string operPerformed = "";
        bool isOperPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if (isOperPerformed)
            {
                textBox1.Clear();
            }
            isOperPerformed = false;
            Button btn = (Button) sender;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button oper = (Button)sender;
            operPerformed = oper.Text;
            result = int.Parse(textBox1.Text);
            //textBox1.Text = textBox1.Text + oper.Text;
            isOperPerformed = true;
        }

        private void btnEq_click(object sender, EventArgs e)
        {
            switch (operPerformed)
            {
                case "+":
                    textBox1.Text = (int.Parse(textBox1.Text) + result).ToString();
                    break;
            
            
                case "-":
                    textBox1.Text = (result - int.Parse(textBox1.Text)).ToString();
                break;
            
            
                case "*":
                    textBox1.Text = (int.Parse(textBox1.Text) * result).ToString();
                break;
            
            
                case "/":
                    textBox1.Text = (result / int.Parse(textBox1.Text)).ToString();
                break;

                default:
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}