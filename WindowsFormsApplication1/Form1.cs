using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string connstr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString; //extracting credentials for connecting to MySQL DB (from App.config unit) 
        public static MySqlConnection conDB = new MySqlConnection(connstr); // creating  a connection object
       
        public Form1()
        {         
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            fillGrid(dataGridView1);  // initial filling of the grid with employees data


        }

  

        public static DataTable extractTable(string st) // generic function returning dataset (DataTable type) for any SELECT SQL-query
        {
                DataTable dtSet = new DataTable();     
            try
            {
              
                Form1.conDB.Open();
                MySqlCommand cmd = new MySqlCommand(st, Form1.conDB);
                MySqlDataReader reader = cmd.ExecuteReader();
                dtSet.Load(reader);
            }
            catch (Exception ex)  //processing run-time errors
            {
                MessageBox.Show(ex.Message);
                dtSet = null;
            }
            finally
            {            
                Form1.conDB.Close();
            }
            return dtSet; //rerturning the dataset result (DataTabe type)
            

        }

        public static void executeSQL(string st)  // generic function for executing DML SQL queries
        {
            try
            {
                Form1.conDB.Open();
                MySqlCommand cmd = new MySqlCommand(st, Form1.conDB);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1.conDB.Close();
            }
        }


        public static void fillGrid(DataGridView sender)  // filling the Grid table with all employees
        {
            sender.DataSource = extractTable("Select * from world.emp");
        }

        private void btn_emp_List_Click(object sender, EventArgs e) // refreshing gridview
        {
          fillGrid(dataGridView1);
        }

        private void btn_add_Emp_Click(object sender, EventArgs e)
        {

            frmAddemp frm2 = new frmAddemp();
            frm2.ShowDialog();
        
            Show();
            fillGrid(dataGridView1);

        }

        private void delEmp_btn_Click(object sender, EventArgs e)
        {
            string del_str = "";
            if (dataGridView1.SelectedRows.Count>0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete employee '"+ dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["full_name"].Value.ToString()+"'?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    del_str = "delete from world.emp where emp.id=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                    executeSQL(del_str);
                    fillGrid(dataGridView1);
                }
               
               
            }
            
        }
    }
}
