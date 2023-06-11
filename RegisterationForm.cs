using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFlabDay2.Models;
namespace EFlabDay2
{
    
    public partial class RegisterationForm : Form
    {

        public RegisterationForm()
        {
            InitializeComponent();
            
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            BlogContext blogDb = new BlogContext();
            User newUser= new User();
            newUser.User_name = txt_name.Text;
            newUser.User_age=int.Parse(txt_age.Text);
            newUser.User_add=txt_address.Text;
            newUser.User_email=txt_email.Text;
            newUser.User_photo=txt_photo.Text;  
            newUser.User_password=int.Parse(txt_password.Text);

            blogDb.Users.Add(newUser);
            blogDb.SaveChanges();
            txt_address.Text = txt_age.Text = txt_email.Text = txt_name.Text = txt_password.Text = txt_photo.Text = "";
            this.Hide();


        }
    }
}
