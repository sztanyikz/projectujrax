namespace projectujra
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1(Model mod)
        {
            InitializeComponent();
            button1.Text = "Register";
            button2.Text = "Login";
            model = mod;
            button1.Click += (s, e) =>
            {
                if (
                model.Registration(textBox1.Text, textBox2.Text) == false)
                {
                    MessageBox.Show("Already exists");
                }
            };
            button2.Click += (s, e) =>
            {
                if (model.SigIn(textBox1.Text, textBox2.Text))
                {

                    Form2 order = new Form2();
                    order.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error");
                }
            };
        
        }
    }
}