using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class cCheckedListBoxItem
    {
        public string Text;
        public object Tag;

        // override ToString(); this
        // is what the checkbox control
        // displays as text
        public override string ToString()
        {
            return this.Text;
        }
    }
}
