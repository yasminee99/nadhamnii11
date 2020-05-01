using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            
            ViewTasks.Rows.Add(
               new object[]
               {
                   1,
                   "sport",
                   "Zumba",
                   12,
                   13,
                   "California Gym",
                   "Wife",
                   "2 days",
                   "Normal"
               }
                ) ;
            ViewTasks.Rows.Add(
               new object[]
               {
                   2,
                   "family",
                   "take yasmine to the dentist",
                   15,
                   16,
                   "Doctor khouja",
                   "Wife,Yasmine",
                   "1 day",
                   "urgent"
               }
                );
            ViewTasks.Rows.Add(
              new object[]
              {
                   3,
                   "school",
                   "get kids from school",
                   16,
                   "16:30",
                   "isg",
                   "kids",
                   "30 min",
                   "urgent"
              }
               );
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
