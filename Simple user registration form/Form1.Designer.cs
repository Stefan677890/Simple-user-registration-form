namespace Simple_user_registration_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Username = new TextBox();
            Email = new TextBox();
            Password = new TextBox();
            Error = new Label();
            label2 = new Label();
            label3 = new Label();
            Accepts = new CheckBox();
            DELETE = new Button();
            Save = new Button();
            label4 = new Label();
            List = new ListView();
            SuspendLayout();
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 13F);
            Username.Location = new Point(65, 56);
            Username.Name = "Username";
            Username.Size = new Size(353, 31);
            Username.TabIndex = 0;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 13F);
            Email.Location = new Point(65, 130);
            Email.Name = "Email";
            Email.Size = new Size(353, 31);
            Email.TabIndex = 1;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 13F);
            Password.Location = new Point(65, 205);
            Password.Name = "Password";
            Password.Size = new Size(353, 31);
            Password.TabIndex = 2;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI", 18F);
            Error.ForeColor = Color.Red;
            Error.Location = new Point(65, 306);
            Error.Name = "Error";
            Error.Size = new Size(0, 32);
            Error.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(61, 28);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(65, 102);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 7;
            label3.Text = "E-mail";
            // 
            // Accepts
            // 
            Accepts.AutoSize = true;
            Accepts.Font = new Font("Segoe UI", 13F);
            Accepts.Location = new Point(65, 257);
            Accepts.Name = "Accepts";
            Accepts.Size = new Size(164, 29);
            Accepts.TabIndex = 8;
            Accepts.Text = "I accpet the rules";
            Accepts.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            DELETE.Font = new Font("Segoe UI", 18F);
            DELETE.Location = new Point(61, 360);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(117, 49);
            DELETE.TabIndex = 9;
            DELETE.Text = "Delete";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += Delete_Click;
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 18F);
            Save.Location = new Point(301, 360);
            Save.Name = "Save";
            Save.Size = new Size(117, 49);
            Save.TabIndex = 10;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(65, 177);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // List
            // 
            List.Location = new Point(474, 28);
            List.Name = "List";
            List.Size = new Size(280, 368);
            List.TabIndex = 12;
            List.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(List);
            Controls.Add(label4);
            Controls.Add(Save);
            Controls.Add(DELETE);
            Controls.Add(Accepts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Error);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Username);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private TextBox Email;
        private TextBox Password;
        private Label Error;
        private Label label2;
        private Label label3;
        private CheckBox Accepts;
        private Button DELETE;
        private Button Save;
        private Label label4;
        private ListView List;
    }
}
