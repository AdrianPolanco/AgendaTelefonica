using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    public static class UI
    {
        public static void GetNewLinkColumn(string name, DataGridView dataGridView)
        {
            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn() { HeaderText = name, Text = name, UseColumnTextForLinkValue = true };
            dataGridView.Columns.Add(linkColumn);
        }
    }
}
