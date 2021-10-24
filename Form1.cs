using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandManagerApp
{
    public partial class BandManager : Form
    {
        public BandManager()
        {
            InitializeComponent();
                       
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            //bandlistBox.Items.Add(nameTextBox.Text + " - " + roleTextBox.Text);
            DatabaseDataSet1.MembersRow newMembersRow;
            newMembersRow = databaseDataSet1.Members.NewMembersRow();
            newMembersRow.Name = nameTextBox.Text;
            newMembersRow.Role = roleTextBox.Text;
            this.databaseDataSet1.Members.Rows.Add(newMembersRow);           
            this.membersTableAdapter1.Update(this.databaseDataSet1.Members);

            bandlistBox.Items.Clear();
            bandlistBox2.Items.Clear();
            foreach (DatabaseDataSet1.MembersRow r in this.databaseDataSet1.Members.Rows)
            {               
                bandlistBox.Items.Add(r.Name);
                bandlistBox2.Items.Add(r.Role);
            }

        }
        private void button3_Click(object sender, EventArgs e) //usuwanie członka
        {
            //DatabaseDataSet1.MembersRow deletemembersRow = databaseDataSet1.Members.NewMembersRow();
            //deletemembersRow.Name = bandlistBox.SelectedItem;
            //this.databaseDataSet1.Members.Rows.Remove();
        }

        private void BandManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter1.Fill(this.databaseDataSet1.Members);            

        }

        
    }
}
