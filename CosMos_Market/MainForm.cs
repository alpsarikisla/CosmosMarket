using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosMos_Market
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            UserLogin frm = new UserLogin();
            frm.ShowDialog();
            InitializeComponent();
        }
    }
}
