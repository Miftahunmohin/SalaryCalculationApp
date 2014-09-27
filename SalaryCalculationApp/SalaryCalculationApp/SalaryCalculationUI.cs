using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationApp
{
    public partial class SalaryCalculationUI : Form
    {
        public SalaryCalculationUI()
        {
            InitializeComponent();
        }
        Salary aSalary=new Salary();
        private void showbutton_Click(object sender, EventArgs e)
        {
            aSalary.name = EmployeetextBox.Text;
            aSalary.basicamount =Convert.ToDouble(BasicamounttextBox.Text) ;
            aSalary.houserent = Convert.ToDouble(HouserenttextBox.Text);
            aSalary.medical = Convert.ToDouble(MedicaltextBox.Text);

            double total = aSalary.GetTotal();
            MessageBox.Show(Name + "Your salary is " + total);



        }
    }
}
