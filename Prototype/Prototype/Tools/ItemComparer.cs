using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype.Tools
{
    public class ItemComparer : IComparer
    {
        public int ColumnIndex;
        public bool SortOrder;

        public ItemComparer(int columnIndex)
        {
            ColumnIndex = columnIndex;
            SortOrder = true;
        }

        public int Compare(object x, object y)
        {
            int result;
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;
            if (itemX == null && itemY == null)
                result = 0;
            else if (itemX == null)
                result = -1;
            else if (itemY == null)
                result = 1;
            if (itemX == itemY)
                result = 0;
            result = String.Compare(itemX.SubItems[ColumnIndex].Text, itemY.SubItems[ColumnIndex].Text);
            int intX;
            int intY;
            if (int.TryParse(itemX.SubItems[ColumnIndex].Text, out intX) && int.TryParse(itemY.SubItems[ColumnIndex].Text, out intY))
            {
                if (intX == intY)
                {
                    result = 0;
                }
                else
                {
                    result = intX > intY ? 1 : -1;
                }
            }
            else
            {
                if (int.TryParse(itemX.SubItems[ColumnIndex].Text, out intX) || int.TryParse(itemY.SubItems[ColumnIndex].Text, out intY))
                {
                    result = int.TryParse(itemX.SubItems[ColumnIndex].Text, out intX) ? 1 : -1;
                }
            }
            if (SortOrder && result != 0)
            {
                result = result == 1 ? -1 : 1;
            }
            return result;
        }
    }
}
