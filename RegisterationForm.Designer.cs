namespace EFlabDay2
{
    partial class RegisterationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            btn_register = new Button();
            label1 = new Label();
            txt_email = new TextBox();
            txt_age = new TextBox();
            txt_password = new TextBox();
            txt_photo = new TextBox();
            txt_address = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(433, 59);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 0;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(395, 375);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 1;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 66);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(433, 246);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(125, 27);
            txt_email.TabIndex = 3;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(433, 108);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(125, 27);
            txt_age.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(433, 297);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 5;
            // 
            // txt_photo
            // 
            txt_photo.Location = new Point(433, 206);
            txt_photo.Name = "txt_photo";
            txt_photo.Size = new Size(125, 27);
            txt_photo.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(433, 160);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(125, 27);
            txt_address.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 304);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 253);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 213);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Photo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 167);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 11;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 115);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 12;
            label6.Text = "Age";
            // 
            // RegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_address);
            Controls.Add(txt_photo);
            Controls.Add(txt_password);
            Controls.Add(txt_age);
            Controls.Add(txt_email);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(txt_name);
            Name = "RegisterationForm";
            Text = "RegisterationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private Button btn_register;
        private Label label1;
        private TextBox txt_email;
        private TextBox txt_age;
        private TextBox txt_password;
        private TextBox txt_photo;
        private TextBox txt_address;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}