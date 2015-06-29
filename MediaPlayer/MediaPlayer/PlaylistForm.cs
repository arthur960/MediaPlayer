using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MediaPlayer
{
    public partial class PlaylistForm : Form
    {
        private MainWindow myMainWindow;
        XmlDocument myXmlDocument = new XmlDocument();
        myXmlDocument.Load("books.xml");
        public PlaylistForm()
        {
           
            InitializeComponent();
        }

        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void playlistadd_Click(object sender, EventArgs e)
        {

         
            }
        }
    }

