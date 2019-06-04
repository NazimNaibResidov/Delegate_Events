using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_and_Delegate.Core
{
 public   class Tools
    {
        public static void Clean(TextBox textBox)
        {
            textBox.Text = string.Empty;
        }
    }
}
