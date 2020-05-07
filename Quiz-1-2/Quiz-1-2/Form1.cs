using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
          


            InitializeComponent();
            List<Proceso> procesos = new List<Proceso>();
            List<int> asignados = new List<int>() { 1, 2, 3, 2, 3, 5 };

            Proceso proceso = new Quiz_1_2.Proceso(1, asignados, 4, 2, asignados, 23);

            procesos.Add(proceso);
            proceso = new Quiz_1_2.Proceso(2, asignados, 4, 2, asignados, 11);

            procesos.Add(proceso);
            proceso = new Quiz_1_2.Proceso(4, asignados, 4, 2, asignados, 3);

            procesos.Add(proceso);
            proceso = new Quiz_1_2.Proceso(5, asignados, 3, 8, asignados, 7);

            procesos.Add(proceso);

            
            dataGridView1.DataSource = procesos;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 200;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
