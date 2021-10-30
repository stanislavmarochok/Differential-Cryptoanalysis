using DiferencialnaKryptoanalyza.Components;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();
            this.spn.SBoxClick += new Spn.Spn_SBoxClickEventHandler(this.spn_SBoxClick);
            for (int index = 0; index < 16; ++index)
                this.dgvDistributionTable.Rows.Add();
            this.AutoFindTrail = true;
        }
    }
}
