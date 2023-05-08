using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_UDP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Код, що виконується при натисканні кнопки "Save" на формі налаштувань
        // Збереження введених налаштувань
            string ipAddress = txtIPAddress.Text;
            int localPort = int.Parse(txtLocalPort.Text);
            int remotePort = int.Parse(txtRemotePort.Text);
            // Збереження налаштувань в змінних або файлі
            // ...
            // Закриття форми налаштувань
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
