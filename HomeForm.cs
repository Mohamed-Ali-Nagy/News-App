using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFlabDay2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
           // LoginForm loginForm = new LoginForm();
           // loginForm.Show();
        }

        private void btn_regest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterationForm registerationForm = new RegisterationForm();
            registerationForm.Show();
        }
    }
}
