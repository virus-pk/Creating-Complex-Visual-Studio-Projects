using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfrastructureLayer.VO;

namespace EmployeeTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmployeeVO vO = new EmployeeVO();
            EmployeeVO2 vO2 = new EmployeeVO2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
