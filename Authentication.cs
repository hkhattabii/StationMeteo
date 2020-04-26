using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stationMeteo
{
    public partial class Authentication : Form
    {
        public Interface mainInterface;
        public Database database;
        public Authentication(Interface mainInterface)
        {
            this.mainInterface = mainInterface;
            this.database = new Database();
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void onLogin(object sender, EventArgs e)
        {
            User user = database.loginUser(tb_username.Text, tb_password.Text);
            if (user == null)
            {
                lb_authMessage.Text = "L'utilisateur ou le mot de passe est incorrect";
                lb_authMessage.ForeColor = Color.Red;
                lb_authMessage.Visible = true;
            } else
            {

                lb_authMessage.Text = "Vous êtes connecté en tant que " + user.username;
                lb_authMessage.ForeColor = Color.Green;
                lb_authMessage.Visible = true;
                mainInterface.login(user);

            }

        }
    }
}
