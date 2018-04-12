using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdText = cmdTextBox.Text;
            if(cmdText == "!pika")
            {
                SoundPlayer audio = new SoundPlayer(Resource1.smashbros_pikachuu); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
                audio.Play();
            }
        }
    }
}
