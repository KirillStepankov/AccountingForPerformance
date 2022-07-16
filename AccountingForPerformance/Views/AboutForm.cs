using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingForPerformance.Views
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = ConfigurationManager.AppSettings["pathAbout"];
            if(!File.Exists(path))
            {
                MessageBox.Show($"Файл справки {path} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process.Start(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
