using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco;
using System.IO;
using System.Reflection;

namespace WMVConverter
{
    class View
    {
        public void finishedMessageBox()
        {
            //Display Messagebox that the conversion of files/folder has finished
            MessageBox.Show("Conversion Finished", "Conversion Finished", MessageBoxButtons.OK);
        }

    }
}
