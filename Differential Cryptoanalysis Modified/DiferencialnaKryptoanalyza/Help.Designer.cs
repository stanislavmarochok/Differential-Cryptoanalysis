using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    public partial class Help : Form
    {
        private IContainer components;
        private TreeView treeView1;
        private Label lblDefault1;
        private Label lblDefault2;
        private Label lblPart;
        private Label lblControls;
        private Label lblControlsAutomatic;
        private PictureBox pBControls1;
        private Label lblControlsManual;
        private Label lblLayout;
        private PictureBox pBControls2;
        private Label label1;
        private PictureBox pBLogo;
        private Label lblSettings;

        private void Help_Load(object sender, EventArgs e) => this.pBLogo.Load("Pictures\\Logo.jpeg");

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Name)
            {
                case "NodeDefault":
                    this.pBControls1.Visible = false;
                    this.lblPart.Text = "Základné informácie";
                    this.lblDefault1.BringToFront();
                    this.lblDefault2.BringToFront();
                    break;
                case "NodeControls":
                    this.pBControls1.Visible = false;
                    this.lblPart.Text = "Ovládanie";
                    this.lblControls.BringToFront();
                    break;
                case "NodeControlsAutomatic":
                    this.pBControls1.Load("Pictures\\AutoFindTrail.bmp");
                    this.pBControls1.Visible = true;
                    this.lblPart.Text = "Automatické hľadanie trasy";
                    this.lblControlsAutomatic.BringToFront();
                    this.pBControls1.BringToFront();
                    break;
                case "NodeControlsManual":
                    this.pBControls1.Load("Pictures\\ManualFindTrail.bmp");
                    this.pBControls1.Visible = true;
                    this.lblPart.Text = "Manuálne hľadanie trasy";
                    this.lblControlsManual.BringToFront();
                    this.pBControls1.BringToFront();
                    break;
                case "NodeLayout":
                    this.pBControls1.Visible = false;
                    this.lblLayout.BringToFront();
                    this.lblPart.Text = "Rozlozenie komponentov";
                    break;
                case "NodeLayoutWinMain":
                    this.lblLayout.BringToFront();
                    this.pBControls2.BringToFront();
                    this.pBControls2.Load("Pictures\\WinMainLayout.bmp");
                    this.pBControls2.Visible = true;
                    this.lblPart.Text = "Hlavné okno";
                    break;
                case "NodeLayoutWinResult":
                    this.lblLayout.BringToFront();
                    this.pBControls2.BringToFront();
                    this.pBControls2.Load("Pictures\\WinResultLayout.bmp");
                    this.pBControls2.Visible = true;
                    this.lblPart.Text = "Okno s výsledkami";
                    break;
                case "NodeSettings":
                    this.lblSettings.BringToFront();
                    this.pBControls1.BringToFront();
                    this.pBControls1.Load("Pictures\\WinSettings.bmp");
                    this.pBControls1.Visible = true;
                    this.lblPart.Text = "Nastavenia";
                    break;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Základne informácie");
            TreeNode treeNode2 = new TreeNode("Hlavné okno");
            TreeNode treeNode3 = new TreeNode("Výsledky");
            TreeNode treeNode4 = new TreeNode("Rozloženie komponentov", new TreeNode[2]
            {
        treeNode2,
        treeNode3
            });
            TreeNode treeNode5 = new TreeNode("Automatické hľadanie trasy");
            TreeNode treeNode6 = new TreeNode("Manuálne hľadanie trasy");
            TreeNode treeNode7 = new TreeNode("Ovládanie", new TreeNode[2]
            {
        treeNode5,
        treeNode6
            });
            TreeNode treeNode8 = new TreeNode("Nastavenia");
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Help));
            this.treeView1 = new TreeView();
            this.lblDefault1 = new Label();
            this.lblDefault2 = new Label();
            this.lblPart = new Label();
            this.lblControls = new Label();
            this.lblControlsAutomatic = new Label();
            this.pBControls1 = new PictureBox();
            this.lblControlsManual = new Label();
            this.lblLayout = new Label();
            this.pBControls2 = new PictureBox();
            this.label1 = new Label();
            this.pBLogo = new PictureBox();
            this.lblSettings = new Label();
            ((ISupportInitialize)this.pBControls1).BeginInit();
            ((ISupportInitialize)this.pBControls2).BeginInit();
            ((ISupportInitialize)this.pBLogo).BeginInit();
            this.SuspendLayout();
            this.treeView1.Location = new Point(12, 47);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeDefault";
            treeNode1.Text = "Základne informácie";
            treeNode2.Name = "NodeLayoutWinMain";
            treeNode2.Text = "Hlavné okno";
            treeNode3.Name = "NodeLayoutWinResult";
            treeNode3.Text = "Výsledky";
            treeNode4.Name = "NodeLayout";
            treeNode4.Text = "Rozloženie komponentov";
            treeNode5.Name = "NodeControlsAutomatic";
            treeNode5.Text = "Automatické hľadanie trasy";
            treeNode6.Name = "NodeControlsManual";
            treeNode6.Text = "Manuálne hľadanie trasy";
            treeNode7.Name = "NodeControls";
            treeNode7.Text = "Ovládanie";
            treeNode8.Name = "NodeSettings";
            treeNode8.Text = "Nastavenia";
            this.treeView1.Nodes.AddRange(new TreeNode[4]
            {
        treeNode1,
        treeNode4,
        treeNode7,
        treeNode8
            });
            this.treeView1.Size = new Size(192, 256);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
            this.lblDefault1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblDefault1.BackColor = Color.White;
            this.lblDefault1.BorderStyle = BorderStyle.FixedSingle;
            this.lblDefault1.Location = new Point(226, 47);
            this.lblDefault1.Name = "lblDefault1";
            this.lblDefault1.Size = new Size(500, 447);
            this.lblDefault1.TabIndex = 0;
            this.lblDefault1.Text = componentResourceManager.GetString("lblDefault1.Text");
            this.lblDefault2.AutoSize = true;
            this.lblDefault2.BackColor = Color.White;
            this.lblDefault2.Location = new Point(376, 114);
            this.lblDefault2.Name = "lblDefault2";
            this.lblDefault2.Size = new Size(202, 65);
            this.lblDefault2.TabIndex = 1;
            this.lblDefault2.Text = "- vstupný / výstupný počet bitov SPN: 16\r\n- počet bitov kľúča: 32\r\n- počet bitov podkľúča: 16\r\n- počet bitov S-Boxu: 4\r\n- počet kôl : 4";
            this.lblPart.AutoSize = true;
            this.lblPart.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)238);
            this.lblPart.Location = new Point(223, 9);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new Size(277, 31);
            this.lblPart.TabIndex = 2;
            this.lblPart.Text = "Základné informácie";
            this.lblControls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblControls.BackColor = Color.White;
            this.lblControls.BorderStyle = BorderStyle.FixedSingle;
            this.lblControls.Location = new Point(226, 47);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new Size(500, 447);
            this.lblControls.TabIndex = 3;
            this.lblControls.Text = componentResourceManager.GetString("lblControls.Text");
            this.lblControlsAutomatic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblControlsAutomatic.BackColor = Color.White;
            this.lblControlsAutomatic.BorderStyle = BorderStyle.FixedSingle;
            this.lblControlsAutomatic.Location = new Point(226, 47);
            this.lblControlsAutomatic.Name = "lblControlsAutomatic";
            this.lblControlsAutomatic.Size = new Size(500, 447);
            this.lblControlsAutomatic.TabIndex = 4;
            this.lblControlsAutomatic.Text = componentResourceManager.GetString("lblControlsAutomatic.Text");
            this.pBControls1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.pBControls1.Location = new Point(242, 181);
            this.pBControls1.Name = "pBControls1";
            this.pBControls1.Size = new Size(469, 302);
            this.pBControls1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pBControls1.TabIndex = 5;
            this.pBControls1.TabStop = false;
            this.lblControlsManual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblControlsManual.BackColor = Color.White;
            this.lblControlsManual.BorderStyle = BorderStyle.FixedSingle;
            this.lblControlsManual.Location = new Point(226, 47);
            this.lblControlsManual.Name = "lblControlsManual";
            this.lblControlsManual.Size = new Size(500, 447);
            this.lblControlsManual.TabIndex = 6;
            this.lblControlsManual.Text = componentResourceManager.GetString("lblControlsManual.Text");
            this.lblLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblLayout.BackColor = Color.White;
            this.lblLayout.Location = new Point(226, 48);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new Size(500, 447);
            this.lblLayout.TabIndex = 7;
            this.lblLayout.Text = "Tu je možné sískať prehľad o použitých komponentoch a ich rozmiestnení";
            this.pBControls2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.pBControls2.Location = new Point(242, 72);
            this.pBControls2.Name = "pBControls2";
            this.pBControls2.Size = new Size(469, 411);
            this.pBControls2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pBControls2.TabIndex = 8;
            this.pBControls2.TabStop = false;
            this.label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.label1.Location = new Point(12, 508);
            this.label1.Name = "label1";
            this.label1.Size = new Size(722, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = componentResourceManager.GetString("label1.Text");
            this.pBLogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.pBLogo.Location = new Point(12, 325);
            this.pBLogo.Name = "pBLogo";
            this.pBLogo.Size = new Size(192, 170);
            this.pBLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pBLogo.TabIndex = 10;
            this.pBLogo.TabStop = false;
            this.lblSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.lblSettings.BackColor = Color.White;
            this.lblSettings.BorderStyle = BorderStyle.FixedSingle;
            this.lblSettings.Location = new Point(226, 47);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new Size(500, 447);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = componentResourceManager.GetString("lblSettings.Text");
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(738, 528);
            this.Controls.Add((Control)this.lblSettings);
            this.Controls.Add((Control)this.pBLogo);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.lblPart);
            this.Controls.Add((Control)this.treeView1);
            this.Controls.Add((Control)this.lblDefault2);
            this.Controls.Add((Control)this.lblDefault1);
            this.Controls.Add((Control)this.lblControls);
            this.Controls.Add((Control)this.lblControlsAutomatic);
            this.Controls.Add((Control)this.lblLayout);
            this.Controls.Add((Control)this.lblControlsManual);
            this.Controls.Add((Control)this.pBControls2);
            this.Controls.Add((Control)this.pBControls1);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(754, 566);
            this.MinimumSize = new Size(754, 566);
            this.Name = nameof(Help);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Pomoc";
            this.Load += new EventHandler(this.Help_Load);
            ((ISupportInitialize)this.pBControls1).EndInit();
            ((ISupportInitialize)this.pBControls2).EndInit();
            ((ISupportInitialize)this.pBLogo).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
