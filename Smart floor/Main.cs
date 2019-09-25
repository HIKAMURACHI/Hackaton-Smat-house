using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_floor
{
    public partial class Main : Form
    {
        const int step = 5;
        public Main()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void v_Click(object sender, EventArgs e)
        {            
            if (PMenu.Width != 250)
            { 
               for (int i=50; PMenu.Width<250; i=i+step)
                { 
                    PMenu.Width = PMenu.Width + step;
                    System.Threading.Thread.Sleep(1);
                }
                BHome.Width = 244;
                BFloor.Width = 244;
                BAdd.Width = 244;
            }
            else 
            {
                for (int i = 250; PMenu.Width > 50; i = i - step)
                {
                    PMenu.Width = PMenu.Width - step;
                    System.Threading.Thread.Sleep(1);
                }
                BHome.Width = 44;
                BFloor.Width = 44;
                BAdd.Width = 44;
            }
        }

        private void BHome_Click(object sender, EventArgs e)
        {
            menuButton("Home");
        }

        private void BFloor_Click(object sender, EventArgs e)
        {
            menuButton("Floor");
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void menuButton(string btnName)
        {
            switch (btnName)
            {                
                case "Home":
                    uHome1.Visible = true;                    
                    break;
                case "Floor":
                    uHome1.Visible = false;
                    break;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Visible = true;
        }
        
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (contextMenuStrip1.Name == "Close")
            Application.Exit();
        }
    }   
}
