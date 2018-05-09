using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NerdBirdCalenday2017
{

    public partial class Form1 : Form
    {
        RestClient restClient = new RestClient();

        public Form1()
        {
            InitializeComponent();
            ControlBox = false;
            runHttp();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private async void monthCalendar1_DateChangedAsync(object sender, DateRangeEventArgs e)
        {
            List<Entry> entry = new List<Entry>();
            String path = "/api/todos/";
            entry = await restClient.GetEntryAsync(path);
            //textBox1.Text = monthCalendar1.SelectionStart.ToString()
            Console.WriteLine(entry[0].Id);
            textBox1.Text = entry[0].Id.ToString();
        }

        private async void runHttp()
        {
            await restClient.RunAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

    }
}
