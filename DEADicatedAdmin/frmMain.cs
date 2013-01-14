using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEADicatedAdmin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Add NewServer from, required when building or finding a new server
            DEADicatedAdmin.Forms.frmNewServer NewServer = new DEADicatedAdmin.Forms.frmNewServer();
            NewServer.TopLevel = false;
            panelContent.Controls.Add(NewServer);
            NewServer.Visible = true;



            // Removing a form from the panel
            // ContainerPanel.Controls.Remove(activeform);
            // activeform.Close();
            // activeform.Dispose();
        }
    }
}
