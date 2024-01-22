using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculs_Orthologick.Mk_Controls
{
    public partial class Mk_TextBox : UserControl
    {
        private Color borderColor = Color.Empty;
        private int borderSize = 0;
        private int borderRadius = 0;
        public Mk_TextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor { get => borderColor; set { borderColor = value; this.BorderColor = borderColor; this.Invalidate(); } }
        public int BorderSize { get => borderSize; set { borderSize = value; this.BorderSize = borderSize; this.Invalidate(); } }
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.BorderRadius = borderRadius; this.Invalidate(); } }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
            
        //}
    }
}
