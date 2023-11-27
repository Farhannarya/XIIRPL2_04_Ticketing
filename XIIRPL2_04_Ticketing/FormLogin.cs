using XIIRPL2_04_Ticketing.MasterForm;

namespace XIIRPL2_04_Ticketing
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}