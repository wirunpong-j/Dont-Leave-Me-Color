using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dont_Leave_Me_Color
{
    /// <summary>
    /// Interaction logic for tapControl.xaml
    /// </summary>
    public partial class tapControl : UserControl
    {
        public tapControl()
        {
            InitializeComponent();
        }
        public int x = 0;
        public int y = 0;
        public int note = 0;
        public int noteColor = 0;
        public string thisTouch = "";
    }
}
