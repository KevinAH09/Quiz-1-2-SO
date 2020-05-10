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
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        List<Proceso> procesos = new List<Proceso>();
        List<HiloProceso> Hilosprocesos = new List<HiloProceso>();
        List<int> asignados = new List<int>() { 1, 2, 3, 2, 3, 5 };
        int n = 0;
        int idProcesosCreados = 0;
        public Form1()
        {
            InitializeComponent();
           

        }
        void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            idProcesosCreados++;
            Proceso proceso = new Proceso(idProcesosCreados,int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));

            procesos.Add(proceso);
            Hilosprocesos.Add(new HiloProceso(proceso));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = procesos;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 210;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 210;
            dataGridView1.Columns[6].Width = 160;
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

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 5000;
            myTimer.Start();
        }
    }
}
