using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tecnologia
{
    public partial class FRM_Tecnologia : Form
    {
        public FRM_Tecnologia()
        {
            InitializeComponent();
        }


        private void ImagemLogo_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, ImagemLogo.Width, ImagemLogo.Height);
            ImagemLogo.Region = new Region(path);

        }

        private void Btn_Identidade_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Tecnologia_Load(object sender, EventArgs e)
        {

        }
    }
}
