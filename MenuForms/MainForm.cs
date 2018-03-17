using MenuForms.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuForms
{
    public partial class MainForm : Form
    {
        private Timer _timerUpdateTime = new Timer();
        private int _processStatusBar = 0;
        private readonly EFContext _context;
        public MainForm()
        {
            InitializeComponent();
            stLabelInfo.Text = "Програма завнтажуєтсья ...";
            stLabelInfo.Image = Image.FromFile("icon\\Wait.gif");
            _timerUpdateTime.Interval = 1000;
            _timerUpdateTime.Enabled = true;
            _timerUpdateTime.Tick += timerUpdateTime_Tick;
            stTimeNow.Text = DateTime.Now.ToLongTimeString();
            stProgressBar.Value = _processStatusBar;
            
            _context = new EFContext();
        }
        private void timerUpdateTime_Tick(object sender, EventArgs e)
        {
            stTimeNow.Text = DateTime.Now.ToLongTimeString();
            if(_processStatusBar<100)
            {
                _processStatusBar += 10;
                stProgressBar.Value = _processStatusBar;
            }
            else
            {
                stLabelInfo.Image = null;//Image.FromFile("icon\\Appay.gif");
                stLabelInfo.Text = "Програма завтнажена";
                //stProgressBar.Value = 100;
            }

        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetCountUsers_Click(object sender, EventArgs e)
        {
            int countUsers = _context.Users.Count();
            MessageBox.Show(countUsers.ToString());
        }
    }
}
