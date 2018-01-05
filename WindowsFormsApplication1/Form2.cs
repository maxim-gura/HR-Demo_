using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAddemp : Form
    {
        public frmAddemp() // initializing the Form for Adding new Employee
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

            this.labelStatusBar.Text = this.inputIsEmpty();
            if (this.labelStatusBar.Text != "")
            {
                
                this.DialogResult = DialogResult.None;
                
            }

            if (this.labelStatusBar.Text == "") 
                {
                string dob = dateForSQL(dtpDOB.Value);
                string emp_date = dateForSQL(dtpEmp. Value);
                // string sqlStr = "insert into world.emp (full_name, dob, marital_status, emp_start_date, nationality) values ('" + this.fullName.Text.Trim() + "', STR_TO_DATE('" + dob + "','%m-%d-%Y'), '" + this.cmbMarital.Text.Trim() + "', STR_TO_DATE('" + emp_date + "','%m-%d-%Y'), 'USA')";
                string sqlStr = "call world.add_emp('" + this.fullName.Text.Trim() + "', '" + dob + "', '" + this.cmbMarital.Text.Trim() + "', '" + emp_date + "', 'USA', '"+ this.cmbResidency.Text.Trim()+"')";
                Form1.executeSQL(sqlStr); // calling stored procedure at MySql database to insert the record with new employee data


                this.DialogResult = DialogResult.OK;
            }
            
        }
        public string dateForSQL(DateTime d)  // re-formatting the date type to MM-DD-YYYY style
        {
            string str = "";
            if (d.Month < 10) { str = "0"+d.Month.ToString(); } else { str = d.Month.ToString(); }
            if (d.Day < 10) { str = str+"-0" + d.Day.ToString(); } else { str = str+"-"+d.Day.ToString(); }
            
            str = str +"-"+ d.Year.ToString();

            return str;
        }

        public string inputIsEmpty() //function checks all input fields in the Form to avoid entering empty data.
            //Returns message string specifying the field which needs attention
        {
            string msg="";
            
            if (this.fullName.Text.Trim() == "")
            { msg = "Full name can not be empty";
            }

             if ((msg=="") && ((this.dtpEmp.Value.Year - this.dtpDOB.Value.Year)<17))
            {
                msg = "You can not hire employees younger than 17 years old";
            }

             if ((msg=="") && (this.cmbMarital.SelectedIndex == -1))
             {
                msg = "Marital status can not be empty";

             }
            if ((msg == "") && (this.cmbNationality.SelectedIndex == -1))
            {
                msg = "Nationality can not be empty";

            }

            if ((msg == "") && (this.cmbResidency.SelectedIndex == -1))
            {
                msg = "Residency status can not be empty";

            }

            return msg;
        }

        private void frmAddemp_Shown(object sender, EventArgs e)
        {
            this.labelStatusBar.Text = "";
            fillNationalityList(cmbNationality);
        }

        public static void fillNationalityList(ComboBox sender)  // filling the Combobox with all countries
        {
            DataTable dtSet = new DataTable();
            dtSet = Form1.extractTable("SELECT * FROM world.country");
            int i = 0;
            for (i = 0; i < dtSet.Rows.Count; i++)
            {
                sender.Items.Add(dtSet.Rows[i]["name"].ToString());
            }
        }

       


    }
}
