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
        static public int hddMAx;
        static public int ramMAx;
        static public int cdMAx;
        static public int audioMAx;
        static public int scanerMAx;
        static public int impresoraMAx;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public static bool cerrojo=true;
        public static List<Proceso> procesos = new List<Proceso>();
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
            if (cerrojo)
            {
                cerrojo = false;
                idProcesosCreados++;
                Proceso proceso = new Proceso(idProcesosCreados, int.Parse(textBox7.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text), int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text));
                textBox7.Text = string.Concat(int.Parse(textBox7.Text) - proceso.recursosAsignados[0]);
                textBox8.Text = string.Concat(int.Parse(textBox8.Text) - proceso.recursosAsignados[1]);
                textBox9.Text = string.Concat(int.Parse(textBox9.Text) - proceso.recursosAsignados[2]);
                textBox10.Text = string.Concat(int.Parse(textBox10.Text) - proceso.recursosAsignados[3]);
                textBox11.Text = string.Concat(int.Parse(textBox11.Text) - proceso.recursosAsignados[4]);
                textBox12.Text = string.Concat(int.Parse(textBox12.Text) - proceso.recursosAsignados[5]);
                procesos.Add(proceso);
                Hilosprocesos.Add(new HiloProceso(proceso, dataGridView1, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = procesos;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].Width = 210;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 210;
                dataGridView1.Columns[6].Width = 160;
                cerrojo = true;
            }
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
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Text = textBox1.Text;
            textBox8.Text = textBox2.Text;
            textBox9.Text = textBox3.Text;
            textBox10.Text = textBox4.Text;
            textBox11.Text = textBox5.Text;
            textBox12.Text = textBox6.Text;
            hddMAx = int.Parse(textBox1.Text);
            ramMAx = int.Parse(textBox2.Text);
            cdMAx = int.Parse(textBox3.Text);
            audioMAx = int.Parse(textBox4.Text);
            scanerMAx = int.Parse(textBox5.Text);
            impresoraMAx = int.Parse(textBox6.Text);

            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 10000;
            myTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
