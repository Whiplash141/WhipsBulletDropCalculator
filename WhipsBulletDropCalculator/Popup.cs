using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhipsBulletDropCalculator
{
    public partial class Popup : Form
    {
        public Popup(Image image)
        {
            InitializeComponent();
            pictureBoxPopup.Image = image;
        }
    }
}
