using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.WS;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        WS.asmxWSSoapClient client;
        User selectedUser;
        int curRow = -1;

        public Form1()
        {
            InitializeComponent();
            this.client = new WS.asmxWSSoapClient();
            getDataBtn.Text = "Get contacts";
            createBtn.Text = "Create new contact";
            updBtn.Text = "Update contact";
            deleteBtn.Text = "Delete contact";
        }



        private void updBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Id = selectedUser.Id;
            user.Name = updName.Text;
            user.PhoneNumber = updPhone.Text;
            client.UpdateData(user);
            UpdateData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("You did not select any rows");
            }
            else
            {
                List<User> selected = new List<User>(dataGridView1.SelectedRows.Count);

                for (int index = 0; index < dataGridView1.SelectedRows.Count; index++)
                {
                    var selectedRow = dataGridView1.SelectedRows[index];
                    var user = (User)selectedRow.DataBoundItem;

                    client.DeleteData(user.Id);
                }
                UpdateData();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = createName.Text;
            user.PhoneNumber = createPhone.Text;
            client.AddData(user);
            UpdateData();
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView1.DataSource = client.GetData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != curRow)
            {
                curRow = dataGridView1.CurrentRow.Index;
                selectedUser = (User)dataGridView1.Rows[curRow].DataBoundItem;
                updName.Text = selectedUser.Name;
                updPhone.Text = selectedUser.PhoneNumber;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
