using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkStatus
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
           { 

        

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Speedtest.folderName.Replace(@"//", @"/");
            if (!File.Exists(Speedtest.folderName)) {
                Directory.CreateDirectory(Speedtest.folderName);
            }
        }
    }
}
