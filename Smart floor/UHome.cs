using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Smart_floor
{
    public partial class UHome : UserControl
    {
        public UHome()
        {
            InitializeComponent();
        }

        bool isDown;
        string btnName;
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            btnName = (sender as Button).Name;
            //MessageBox.Show(btnName);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {                
                c.Location = this.PointToClient(Control.MousePosition);
            }            
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            file_chek("Location", btnName);
        }        

        private void file_chek(string path, string btnName) // chek file
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();

                write_file(path, btnName);
            }
            else
            {
                write_file(path, btnName);
            }
        }

        private void write_file(string path, string btnName)
        {
            string s;

            StreamReader sr = new StreamReader(path, Encoding.Default);
            s = sr.ReadToEnd();
            sr.Close();            
                File.AppendAllText(path, this.Controls[btnName].Location + Environment.NewLine);
            //MessageBox.Show(Convert.ToString(this.Controls[btnName].Location));
        }
    }
}
