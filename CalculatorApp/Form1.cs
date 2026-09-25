namespace CalculatorApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            int num1 = txtBoxNum1.Text != "" ? int.Parse(txtBoxNum1.Text) : 0;
            int num2 = txtBoxNum2.Text != "" ? int.Parse(txtBoxNum2.Text) : 0;
            btnSum.Click += BtnSum_Click;
            btnSub.Click += BtnSub_Click;
            btnMult.Click += BtnMult_Click;
            btnDiv.Click += BtnDiv_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnSum_Click(object? sender, EventArgs e)
        {
            double result = num1 + num2;
            txtBoxEredmeny.Text = result.ToString();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            txtBoxEredmeny.Text = "";
        }
    }
}
