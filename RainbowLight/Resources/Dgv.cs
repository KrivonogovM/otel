using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Windows.Forms;

namespace RainbowLight.Resources
{
    
    class Dgv
    {
        public void TableDesign(DataGridView Designdgv)
        {
            Designdgv.BorderStyle = BorderStyle.FixedSingle;
            Designdgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            Designdgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Designdgv.RowHeadersWidth = 25;
            Designdgv.ColumnHeadersHeight = 30;
            Designdgv.DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control);
            Designdgv.DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Highlight);
            Designdgv.DefaultCellStyle.SelectionForeColor = Color.FromKnownColor(KnownColor.Info);
            Designdgv.GridColor = Color.FromKnownColor(KnownColor.HotTrack);
            Designdgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Designdgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Designdgv.BackgroundColor = Color.White;
            Designdgv.EnableHeadersVisualStyles = true;
        }
    }
}
