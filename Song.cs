using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songy
{
    class Song
    {
    private string song;

        getSong(){
            return song;
        }

        setSong(string song){
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.FileName = song;
                }
            }
        }
    }
}
