
using System;
using System.Drawing;

using System.Windows.Forms;

namespace matrix
{
    class Specification
    {
        private int Row { get; set; } 
        private int Column { get; set; } 
        private int WidthGrid{ get; set; } 
        private int LocationX { get; set; } 
        private int LocationY { get; set; } 
        Random R = new Random();

        public void Settings(DataGridView dg, int locX, int locY, int row, int column)
        {        
            //Initial properties
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToResizeRows = false;
            dg.RowHeadersVisible = false;
            dg.AllowUserToResizeColumns = false;
            
            //Transfer characteristics
            LocationX = locX;
            LocationY= locY;
            Column = column;
            Row = row;      
            dg.ColumnCount = column;
            dg.RowCount = row;


            dg.Location = new Point(locX, locY);

            //Specifications GridControl 
            for (int i = 0; i < row; i++)
            {
                dg.Columns[i].HeaderText = "" + (i + 1);
                dg.Columns[i].Width = dg[0, 0].Size.Height + WidthGrid;//устанавливаем ширину равную высоте ячейки[0,0] 
            }
            try
            {
                dg.Size = new Size(dg[0, 0].Size.Width * row + 3, dg[0, 0].Size.Height * column + 25);
            }
            catch (Exception) { }
        }              
    }
}
