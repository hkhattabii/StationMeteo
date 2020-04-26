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
    public partial class UserCreation : Form
    {
        public Interface mainInterface;
        public Database database;
        private int CELL_SIZE;
        public UserCreation(Interface mainInterface)
        {
            this.mainInterface = mainInterface;
            this.database = new Database();
            InitializeComponent();
        }

        private void UserCreation_Load(object sender, EventArgs e)
        {
            CELL_SIZE = 30;
            initRoleComboBox();
            buildUserGrid();
        }

        private void initRoleComboBox()
        {
            cb_role.Items.AddRange(new String[5] { "Admin", "Master", "Middle", "Basic", "Aucun" });
            cb_role.SelectedIndex = 4;
        }

        private void buildUserGrid()
        {
            int columnCount = 7;
            List<User> users = database.getUsers();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Nom d'utilisateur");
            dataTable.Columns.Add("Rôle");
            dataTable.Columns.Add("Ajouter un ID");
            dataTable.Columns.Add("Supprimer un ID");
            dataTable.Columns.Add("Configurer alarme");
            dataTable.Columns.Add("Crée un utilisateur");


            foreach (User user in users)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = user.ID;
                dataRow[1] = user.username;
                dataRow[2] = user.permission.name;
                dataRow[3] = user.permission.allowCreateID;
                dataRow[4] = user.permission.allowDestroyID;
                dataRow[5] = user.permission.allowConfigAlarm;
                dataRow[6] = user.permission.allowUserCreation;

                dataTable.Rows.Add(dataRow);
            }

            dgv_users.DataSource = dataTable;
            dgv_users.RowTemplate.Height = CELL_SIZE;

            for (int x = 0; x < columnCount; x++)
            {
                dgv_users.Columns[x].Width = dgv_users.Width / columnCount;
            }

            for (int y = 0; y < users.Count; y++)
            {
                dgv_users.Rows[y].Height = CELL_SIZE;
            }

        }

        private void createuser(object sender, EventArgs e)
        {
            if (tb_username.TextLength > 0 && tb_password.TextLength > 0)
            {
                database.createUser(tb_username.Text,tb_password.Text, cb_role.SelectedIndex);
                buildUserGrid();
            }
        }
    }
}
