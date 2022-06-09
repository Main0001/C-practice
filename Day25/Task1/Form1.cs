using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3__z1_
{
    public partial class Form1 : Form
    {
        private int openDocument = 0;

        public Form1()
        {
            InitializeComponent();
            spdata.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    Child_Form newChild = new Child_Form();
                    newChild.MdiParent = this;
                    ++openDocument;
                    newChild.Text = newChild.Text + " " + openDocument.ToString();
                    newChild.Show();
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWin.Text = "Windows is cascade";
                    break;
                case "Title":
                    this.LayoutMdi
                    (System.Windows.Forms.MdiLayout.TileHorizontal);
                    spWin.Text = "Windows is horizontal";
                    break;
            }
        }
    }
}
