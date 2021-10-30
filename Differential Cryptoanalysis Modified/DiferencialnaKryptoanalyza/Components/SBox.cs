using DiferencialnaKryptoanalyza.Classes;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza.Components
{
    public partial class SBox : UserControl
    {
        public SBox()
        {
            this.InitializeComponent();
            this.BitsIn = (byte)0;
            this.BitsOut = (byte)0;
            this.Activated = false;
            this.LineIn = new Line[4];
            this.LineOut = new Line[4];
            this.defaultSBoxColor = this.btnSbox.BackColor;
            this.Probability = 0.0;
        }
    }
}
