using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Songy
{

    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private Player myMp3 = new Player();
        Player Temp {get; set;}
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    myMp3.Open(ofd.FileName);
                }
            }
            Thread.Sleep(2000);
            myMp3.Play();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            myMp3.Play();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            myMp3.Stop();
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            myMp3.Stop();
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            myMp3.Stop();    
            Application.Restart();
        }

        private void StopButton_Click_1(object sender, EventArgs e)
        {
            myMp3.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    myMp3.Open(ofd.FileName);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void OtherButton_Click(object sender, EventArgs e)
        {
            myMp3.Stop();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void SongDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                mouseX = Cursor.Position.X;
                mouseY = Cursor.Position.Y;
                this.SetDesktopLocation(mouseX - 246, mouseY - 10);
            }
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}