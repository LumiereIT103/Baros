namespace Baros
{
    public partial class BrsRegister : Form
    {
        public BrsRegister()
        {
            InitializeComponent();
        }

        private void backtolog_lbl_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }
    }
}