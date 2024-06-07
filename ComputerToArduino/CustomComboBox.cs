using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ComputerToArduino
{

    public class CustomComboBox : ComboBox
    {
        private List<bool> _checkedItems;

        public CustomComboBox()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            _checkedItems = new List<bool>();
        }
        public override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

        }
    }
}
