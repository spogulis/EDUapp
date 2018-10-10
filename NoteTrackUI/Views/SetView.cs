using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTrackUI.Views
{
    public partial class SetView : Form
    {
        public SetView()
        {
            InitializeComponent();
            SetViewMainPanel.CellPaint += OnSetViewMainPanelCellPaint;
        }

        private void MainPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 1)
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }


            }
            else
            {
                using (SolidBrush brush = new SolidBrush(Color.OliveDrab))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }
        }


        private void MainPanelTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            
            if (e.Row == 0 || e.Row == 1 || e.Row == 2 || e.Row == 4 || e.Row == 5 || e.Row == 6)
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }

            if (e.Row == 0 || e.Row == 4)
            {
                e.Graphics.DrawLine(new Pen(Color.OliveDrab), e.CellBounds.Location, new Point(e.CellBounds.Right, e.CellBounds.Top));
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(225, 240, 204)))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
            }
        }


        private void TopicListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? Brushes.White : new SolidBrush(Color.OliveDrab);
                Brush background = ((e.State & DrawItemState.Selected) == DrawItemState.Selected ? new SolidBrush(Color.FromArgb(51, 153, 255)) : new SolidBrush(Color.Black));
                g.FillRectangle(background, e.Bounds);
                e.Graphics.DrawString(TopicListbox.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
                //TODO: Figure out how to draw a separator line. This below doesn't work automatically
                //e.Graphics.DrawLine(Pens.OliveDrab, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
            }
        }

        //private void TopicListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        //{
        //    string itemString = (string) TopicListbox.Items[e.Index];
        //    string[] resultStrings = itemString.Split(' ');
        //    e.ItemHeight = 26;
        //    if (itemString.Length > 104)
        //    {
        //        e.ItemHeight += 78;
        //    }
        //    else if (itemString.Length > 89)
        //    {
        //        e.ItemHeight += 52;
        //    }
        //    else if (itemString.Length > 59)
        //    {
        //        e.ItemHeight += 26;
        //    }
        //    else if (itemString.Length > 30)
        //    {
        //        e.ItemHeight += 13;
        //    }
        //}


        private void ListboxPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0 && e.Row == 0)
            {
                e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
                //e.Graphics.DrawRectangle(Pens.OliveDrab, e.CellBounds);

                //TODO: Another cell separator line
            }

            if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
            }
        }

        
        private void OnSetViewMainPanelCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
            {
                e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Top), new Point(e.CellBounds.Left, e.CellBounds.Bottom));

                e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));

            }

            if (e.Column == 1)
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                    e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Top), new Point(e.CellBounds.Left, e.CellBounds.Bottom));
                    e.Graphics.DrawLine(Pens.OliveDrab, new Point(e.CellBounds.Left, e.CellBounds.Top), new Point(e.CellBounds.Right, e.CellBounds.Top));
                }
            }

            
        }

        private void ListboxPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Orange, new Point(this.Bounds.Left, this.Bounds.Bottom), new Point(this.Bounds.Right, this.Bounds.Bottom));
        }
    }
}
