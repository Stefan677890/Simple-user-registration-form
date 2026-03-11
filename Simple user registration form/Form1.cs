using System.Text.RegularExpressions;

namespace Simple_user_registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listawys();
        }


        private void listawys()
        {
            List.View = View.Details;
            List.FullRowSelect = true;
            List.Columns.Add("Użytkownik", 150);
            List.Columns.Add("E-mail", 150);
            Password.PasswordChar = '*';
        }


        private void Save_Click(object sender, EventArgs e)
        {
            Error.Text = "";

            if (string.IsNullOrWhiteSpace(Username.Text) ||
                string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(Password.Text))
            {
                Error.Text = "fill in all the fields -_- ";
                return;
            }


            if (!Accepts.Checked)
            {
                Error.Text = "Accept the rules !!!";
                return;
            }


            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(Email.Text, emailpattern))
            {
                Error.Text = "You wrote something wrong !!!";
                return;
            }

            ListViewItem item = new ListViewItem(Username.Text);
            item.SubItems.Add(Email.Text);
            List.Items.Add(item);

            clearfields();

            Error.Text = "User saved";
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            if (List.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in List.SelectedItems)
                {
                    List.Items.Remove(item);
                }
                Error.ForeColor = Color.Blue;
                Error.Text = "Deleted";
            }
            else
            {
                Error.ForeColor = Color.Red;
                Error.Text = "mark the user you want to delete";
            }
        }

        private void clearfields()
        {
            Username.Clear();
            Email.Clear();
            Password.Clear();
            Accepts.Checked = false;
        }
    }
}