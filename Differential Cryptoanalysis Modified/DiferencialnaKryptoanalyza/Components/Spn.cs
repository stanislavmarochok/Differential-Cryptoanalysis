using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza.Components
{
    public partial class Spn : UserControl
    {
        public Spn()
        {
            this.InitializeComponent();
            this.InitializeSBox();
            this.InitializeLabel();
            this.InitializeLineCoordinates();
            this.SetDiffTable();
            this.key = this.key << 16 | this.key >> 16;
            for (int index = 0; index < 5; ++index)
            {
                this.subKey[index] = (ushort)this.key;
                this.key = this.key << 4 | this.key >> 28;
            }
            this.key = this.key >> 4 | this.key << 28;
        }
    }
}
