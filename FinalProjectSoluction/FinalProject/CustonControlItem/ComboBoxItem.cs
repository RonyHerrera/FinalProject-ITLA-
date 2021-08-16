using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.CustonControlItem
{
    public class ComboBoxItem
    {
        public string Text { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}
