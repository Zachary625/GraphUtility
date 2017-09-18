using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphUtility
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadGraphFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            File.ReadAllLines(fileName);
        }

        private void LoadVerticesFile(string fileName)
        {
        }

        private void LoadeEdgesFile(string fileName)
        {
        }
    }

}
