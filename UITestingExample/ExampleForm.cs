using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITestingExample
{
    public partial class ExampleForm : Form
    {
        private BindingList<ColorInfo> _colorInfoList;
        private const int COLOR_COLUMN_INDEX = 1;

        public ExampleForm()
        {
            InitializeComponent();
            _colorInfoList = new BindingList<ColorInfo>();
            _dataGridView.DataSource = _colorInfoList;

        }

        private void ClickAddButton(object sender, EventArgs e)
        {
            Color color = _colorLabel.BackColor;
            ColorInfo colorInfo = new ColorInfo(color);
            _colorInfoList.Add(colorInfo);
        }

        private void ClickColorLabel(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _colorLabel.BackColor = colorDialog.Color;
            }
        }

        private void FormatDataGridViewCell(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == COLOR_COLUMN_INDEX)
            {
                Color colorInfo = (Color)e.Value;
                e.CellStyle.BackColor = colorInfo;
                e.Value = null;
            }
        }

        private void ClickShowWindowMenu(object sender, EventArgs e)
        {
            PopUpForm popUpForm = new PopUpForm();
            popUpForm.ShowDialog();
        }
    }
}
