using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTrackUI.Views
{
    public partial class SetListboxView : Form, ISetListboxView
    {
        public SetListboxView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Override HomeSetList draw properties
        /// </summary>
        //public void HomeSetList_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    Graphics g = e.Graphics;
        //    Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.White : new SolidBrush(Color.FromArgb(51, 153, 255));
        //    Brush background = ((e.State & DrawItemState.Selected) == DrawItemState.Selected ? new SolidBrush(Color.FromArgb(51, 153, 255)) : new SolidBrush(Color.FromArgb(225, 240, 204)));
        //    g.FillRectangle(background, e.Bounds);
        //    e.Graphics.DrawString(HomeSetList.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
        //    e.DrawFocusRectangle();
        //}
        
        /// <summary>
        /// Override HomeSetList line height properties
        /// </summary>
        //public void HomeSetList_MeasureItem(object sender, MeasureItemEventArgs e)
        //{
        //    string itemString = (string) HomeSetList.Items[e.Index].Text;
        //    string[] resultStrings = itemString.Split(' ');
        //    if (resultStrings.Length > 9)
        //    {
        //        e.ItemHeight += 50;
        //    }
        //    else if (resultStrings.Length > 6)
        //    {
        //        e.ItemHeight += 35;
        //    } 
        //    else if (resultStrings.Length > 3) 
        //    {
        //        e.ItemHeight += 20;
        //    }
        //    else
        //    {
        //        e.ItemHeight += 5;
        //    }
        //}

        private void HomeSetList_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
