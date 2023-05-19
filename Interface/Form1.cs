namespace Interface
{
    public partial class Form1 : Form
    {
        public float Numero1 { get; set; }
        public float Numero2 { get; set; }
        public Form1()
        {
            InitializeComponent();
            lblDigito.Text = "";
            lblDigito.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            lblDigito.Visible = true;
            lblDigito.Text += "1 ";
            Numero1 = 1;
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            lblDigito.Visible = true;
            lblDigito.Text += "2 ";
            Numero2 = 2;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var result = Numero1 + Numero2;
            lblDigito.Text = result.ToString();
        }
    }
}