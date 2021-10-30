using DiferencialnaKryptoanalyza.Classes;
using DiferencialnaKryptoanalyza.Components;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    public partial class Main : Form
    {
        private IContainer components;
        private Spn spn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem súborToolStripMenuItem;
        private ToolStripMenuItem vymažSPNSieťToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem nastavenieToolStripMenuItem;
        private ToolStripMenuItem koniecToolStripMenuItem;
        private DataGridView dgvDistributionTable;
        private Button btnAutoFindTrail;
        private GroupBox gbBestDiffTrail;
        private Label lblGbInputDiff;
        private TextBox tbGbProbability;
        private TextBox tbGbInputDiff;
        private Label lblGbProbability;
        private Button btnValidate;
        private Label lblGbOutputDiff;
        private TextBox tbGbOutputDiff;
        private Button btnAttack;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private SBox lastSBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle17 = new DataGridViewCellStyle();
            this.menuStrip1 = new MenuStrip();
            this.súborToolStripMenuItem = new ToolStripMenuItem();
            this.vymažSPNSieťToolStripMenuItem = new ToolStripMenuItem();
            this.nastavenieToolStripMenuItem = new ToolStripMenuItem();
            this.koniecToolStripMenuItem = new ToolStripMenuItem();
            this.pomocToolStripMenuItem = new ToolStripMenuItem();
            this.dgvDistributionTable = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.Column11 = new DataGridViewTextBoxColumn();
            this.Column12 = new DataGridViewTextBoxColumn();
            this.Column13 = new DataGridViewTextBoxColumn();
            this.Column14 = new DataGridViewTextBoxColumn();
            this.Column15 = new DataGridViewTextBoxColumn();
            this.Column16 = new DataGridViewTextBoxColumn();
            this.btnAutoFindTrail = new Button();
            this.gbBestDiffTrail = new GroupBox();
            this.lblGbOutputDiff = new Label();
            this.tbGbOutputDiff = new TextBox();
            this.tbGbProbability = new TextBox();
            this.tbGbInputDiff = new TextBox();
            this.lblGbProbability = new Label();
            this.lblGbInputDiff = new Label();
            this.btnValidate = new Button();
            this.btnAttack = new Button();
            this.spn = new Spn();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize)this.dgvDistributionTable).BeginInit();
            this.gbBestDiffTrail.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.súborToolStripMenuItem,
        (ToolStripItem) this.pomocToolStripMenuItem
            });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(714, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.súborToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.vymažSPNSieťToolStripMenuItem,
        (ToolStripItem) this.nastavenieToolStripMenuItem,
        (ToolStripItem) this.koniecToolStripMenuItem
            });
            this.súborToolStripMenuItem.Name = "súborToolStripMenuItem";
            this.súborToolStripMenuItem.Size = new Size(99, 20);
            this.súborToolStripMenuItem.Text = "Hlavná ponuka";
            this.vymažSPNSieťToolStripMenuItem.Name = "vymažSPNSieťToolStripMenuItem";
            this.vymažSPNSieťToolStripMenuItem.Size = new Size(184, 22);
            this.vymažSPNSieťToolStripMenuItem.Text = "Vymaž SPN sieť";
            this.vymažSPNSieťToolStripMenuItem.Click += new EventHandler(this.vymažSPNSieťToolStripMenuItem_Click);
            this.nastavenieToolStripMenuItem.Name = "nastavenieToolStripMenuItem";
            this.nastavenieToolStripMenuItem.Size = new Size(184, 22);
            this.nastavenieToolStripMenuItem.Text = "Nastavenie SPN siete";
            this.nastavenieToolStripMenuItem.Click += new EventHandler(this.nastavenieToolStripMenuItem_Click);
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new Size(184, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new EventHandler(this.koniecToolStripMenuItem_Click);
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new EventHandler(this.pomocToolStripMenuItem_Click);
            this.dgvDistributionTable.AllowUserToAddRows = false;
            this.dgvDistributionTable.AllowUserToDeleteRows = false;
            this.dgvDistributionTable.AllowUserToResizeColumns = false;
            this.dgvDistributionTable.AllowUserToResizeRows = false;
            this.dgvDistributionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDistributionTable.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8, (DataGridViewColumn)this.Column9, (DataGridViewColumn)this.Column10, (DataGridViewColumn)this.Column11, (DataGridViewColumn)this.Column12, (DataGridViewColumn)this.Column13, (DataGridViewColumn)this.Column14, (DataGridViewColumn)this.Column15, (DataGridViewColumn)this.Column16);
            this.dgvDistributionTable.Enabled = false;
            this.dgvDistributionTable.Location = new Point(328, 200);
            this.dgvDistributionTable.MultiSelect = false;
            this.dgvDistributionTable.Name = "dgvDistributionTable";
            this.dgvDistributionTable.RowHeadersWidth = 44;
            this.dgvDistributionTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvDistributionTable.RowsDefaultCellStyle = gridViewCellStyle1;
            this.dgvDistributionTable.ScrollBars = ScrollBars.None;
            this.dgvDistributionTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgvDistributionTable.Size = new Size(379, 377);
            this.dgvDistributionTable.TabIndex = 6;
            this.dgvDistributionTable.RowPrePaint += new DataGridViewRowPrePaintEventHandler(this.dgvDistributionTable_RowPrePaint);
            this.dgvDistributionTable.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvDistributionTable_CellFormatting);
            this.dgvDistributionTable.CellClick += new DataGridViewCellEventHandler(this.dgvDistributionTable_CellClick);
            gridViewCellStyle2.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle2.SelectionForeColor = Color.Black;
            this.Column1.DefaultCellStyle = gridViewCellStyle2;
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = DataGridViewTriState.False;
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 21;
            gridViewCellStyle3.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle3.SelectionForeColor = Color.Black;
            this.Column2.DefaultCellStyle = gridViewCellStyle3;
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = DataGridViewTriState.False;
            this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 21;
            gridViewCellStyle4.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle4.SelectionForeColor = Color.Black;
            this.Column3.DefaultCellStyle = gridViewCellStyle4;
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = DataGridViewTriState.False;
            this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 21;
            gridViewCellStyle5.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle5.SelectionForeColor = Color.Black;
            this.Column4.DefaultCellStyle = gridViewCellStyle5;
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = DataGridViewTriState.False;
            this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 21;
            gridViewCellStyle6.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle6.SelectionForeColor = Color.Black;
            this.Column5.DefaultCellStyle = gridViewCellStyle6;
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = DataGridViewTriState.False;
            this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 21;
            gridViewCellStyle7.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle7.SelectionForeColor = Color.Black;
            this.Column6.DefaultCellStyle = gridViewCellStyle7;
            this.Column6.HeaderText = "5";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = DataGridViewTriState.False;
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 21;
            gridViewCellStyle8.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle8.SelectionForeColor = Color.Black;
            this.Column7.DefaultCellStyle = gridViewCellStyle8;
            this.Column7.HeaderText = "6";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = DataGridViewTriState.False;
            this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 21;
            gridViewCellStyle9.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle9.SelectionForeColor = Color.Black;
            this.Column8.DefaultCellStyle = gridViewCellStyle9;
            this.Column8.HeaderText = "7";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = DataGridViewTriState.False;
            this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 21;
            gridViewCellStyle10.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle10.SelectionForeColor = Color.Black;
            this.Column9.DefaultCellStyle = gridViewCellStyle10;
            this.Column9.HeaderText = "8";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = DataGridViewTriState.False;
            this.Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column9.Width = 21;
            gridViewCellStyle11.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle11.SelectionForeColor = Color.Black;
            this.Column10.DefaultCellStyle = gridViewCellStyle11;
            this.Column10.HeaderText = "9";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = DataGridViewTriState.False;
            this.Column10.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column10.Width = 21;
            gridViewCellStyle12.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle12.SelectionForeColor = Color.Black;
            this.Column11.DefaultCellStyle = gridViewCellStyle12;
            this.Column11.HeaderText = "A";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = DataGridViewTriState.False;
            this.Column11.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column11.Width = 21;
            gridViewCellStyle13.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle13.SelectionForeColor = Color.Black;
            this.Column12.DefaultCellStyle = gridViewCellStyle13;
            this.Column12.HeaderText = "B";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = DataGridViewTriState.False;
            this.Column12.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column12.Width = 21;
            gridViewCellStyle14.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle14.SelectionForeColor = Color.Black;
            this.Column13.DefaultCellStyle = gridViewCellStyle14;
            this.Column13.HeaderText = "C";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = DataGridViewTriState.False;
            this.Column13.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column13.Width = 21;
            gridViewCellStyle15.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle15.SelectionForeColor = Color.Black;
            this.Column14.DefaultCellStyle = gridViewCellStyle15;
            this.Column14.HeaderText = "D";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = DataGridViewTriState.False;
            this.Column14.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column14.Width = 21;
            gridViewCellStyle16.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle16.SelectionForeColor = Color.Black;
            this.Column15.DefaultCellStyle = gridViewCellStyle16;
            this.Column15.HeaderText = "E";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = DataGridViewTriState.False;
            this.Column15.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column15.Width = 21;
            gridViewCellStyle17.SelectionBackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            gridViewCellStyle17.SelectionForeColor = Color.Black;
            this.Column16.DefaultCellStyle = gridViewCellStyle17;
            this.Column16.HeaderText = "F";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = DataGridViewTriState.False;
            this.Column16.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column16.Width = 21;
            this.btnAutoFindTrail.Location = new Point(632, 35);
            this.btnAutoFindTrail.Name = "btnAutoFindTrail";
            this.btnAutoFindTrail.Size = new Size(75, 23);
            this.btnAutoFindTrail.TabIndex = 7;
            this.btnAutoFindTrail.Text = "Hľadaj trasu";
            this.btnAutoFindTrail.UseVisualStyleBackColor = true;
            this.btnAutoFindTrail.Click += new EventHandler(this.btnAutoFindTrail_Click);
            this.gbBestDiffTrail.Controls.Add((Control)this.lblGbOutputDiff);
            this.gbBestDiffTrail.Controls.Add((Control)this.tbGbOutputDiff);
            this.gbBestDiffTrail.Controls.Add((Control)this.tbGbProbability);
            this.gbBestDiffTrail.Controls.Add((Control)this.tbGbInputDiff);
            this.gbBestDiffTrail.Controls.Add((Control)this.lblGbProbability);
            this.gbBestDiffTrail.Controls.Add((Control)this.lblGbInputDiff);
            this.gbBestDiffTrail.Location = new Point(328, 29);
            this.gbBestDiffTrail.Name = "gbBestDiffTrail";
            this.gbBestDiffTrail.Size = new Size(221, 113);
            this.gbBestDiffTrail.TabIndex = 11;
            this.gbBestDiffTrail.TabStop = false;
            this.gbBestDiffTrail.Text = "Parametre trasy";
            this.lblGbOutputDiff.AutoSize = true;
            this.lblGbOutputDiff.Location = new Point(6, 51);
            this.lblGbOutputDiff.Name = "lblGbOutputDiff";
            this.lblGbOutputDiff.Size = new Size(128, 13);
            this.lblGbOutputDiff.TabIndex = 13;
            this.lblGbOutputDiff.Text = "Výstupná diferencia (Hex)";
            this.tbGbOutputDiff.Location = new Point(134, 48);
            this.tbGbOutputDiff.Name = "tbGbOutputDiff";
            this.tbGbOutputDiff.ReadOnly = true;
            this.tbGbOutputDiff.Size = new Size(81, 20);
            this.tbGbOutputDiff.TabIndex = 12;
            this.tbGbProbability.Location = new Point(134, 74);
            this.tbGbProbability.Name = "tbGbProbability";
            this.tbGbProbability.ReadOnly = true;
            this.tbGbProbability.Size = new Size(81, 20);
            this.tbGbProbability.TabIndex = 11;
            this.tbGbInputDiff.Location = new Point(134, 22);
            this.tbGbInputDiff.Name = "tbGbInputDiff";
            this.tbGbInputDiff.ReadOnly = true;
            this.tbGbInputDiff.Size = new Size(81, 20);
            this.tbGbInputDiff.TabIndex = 10;
            this.lblGbProbability.AutoSize = true;
            this.lblGbProbability.Location = new Point(6, 77);
            this.lblGbProbability.Name = "lblGbProbability";
            this.lblGbProbability.Size = new Size(92, 13);
            this.lblGbProbability.TabIndex = 9;
            this.lblGbProbability.Text = "Pravdepodobnosť";
            this.lblGbProbability.TextAlign = ContentAlignment.TopRight;
            this.lblGbInputDiff.AutoSize = true;
            this.lblGbInputDiff.Location = new Point(6, 25);
            this.lblGbInputDiff.Name = "lblGbInputDiff";
            this.lblGbInputDiff.Size = new Size(123, 13);
            this.lblGbInputDiff.TabIndex = 8;
            this.lblGbInputDiff.Text = "Vstupná diferencia (Hex)";
            this.lblGbInputDiff.TextAlign = ContentAlignment.TopRight;
            this.btnValidate.Location = new Point(632, 64);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new Size(75, 23);
            this.btnValidate.TabIndex = 12;
            this.btnValidate.Text = "Validuj trasu";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new EventHandler(this.btnValidate_Click);
            this.btnAttack.Location = new Point(632, 93);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new Size(75, 23);
            this.btnAttack.TabIndex = 13;
            this.btnAttack.Text = "Útok";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new EventHandler(this.btnAttack_Click);
            this.spn.BorderStyle = BorderStyle.FixedSingle;
            this.spn.DiffInput = (ushort)0;
            this.spn.DiffOutput = (ushort)0;
            this.spn.Key = 982832703U;
            this.spn.Location = new Point(12, 35);
            this.spn.Name = "spn";
            this.spn.Permutation = new ushort[16]
            {
        (ushort) 0,
        (ushort) 4,
        (ushort) 8,
        (ushort) 12,
        (ushort) 1,
        (ushort) 5,
        (ushort) 9,
        (ushort) 13,
        (ushort) 2,
        (ushort) 6,
        (ushort) 10,
        (ushort) 14,
        (ushort) 3,
        (ushort) 7,
        (ushort) 11,
        (ushort) 15
            };
            this.spn.Probability = 0.0;
            this.spn.RightPairCount = 0;
            this.spn.RunTestCount = 0;
            this.spn.Size = new Size(292, 542);
            this.spn.Substitution = new ushort[16]
            {
        (ushort) 14,
        (ushort) 4,
        (ushort) 13,
        (ushort) 1,
        (ushort) 2,
        (ushort) 15,
        (ushort) 11,
        (ushort) 8,
        (ushort) 3,
        (ushort) 10,
        (ushort) 6,
        (ushort) 12,
        (ushort) 5,
        (ushort) 9,
        (ushort) 0,
        (ushort) 7
            };
            this.spn.TabIndex = 3;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(714, 578);
            this.Controls.Add((Control)this.btnAttack);
            this.Controls.Add((Control)this.btnValidate);
            this.Controls.Add((Control)this.gbBestDiffTrail);
            this.Controls.Add((Control)this.dgvDistributionTable);
            this.Controls.Add((Control)this.spn);
            this.Controls.Add((Control)this.btnAutoFindTrail);
            this.Controls.Add((Control)this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new Size(730, 616);
            this.MinimumSize = new Size(730, 616);
            this.Name = nameof(Main);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Diferenciálna kryptoanalýza";
            this.Load += new EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)this.dgvDistributionTable).EndInit();
            this.gbBestDiffTrail.ResumeLayout(false);
            this.gbBestDiffTrail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public bool AutoFindTrail { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lastSBox = this.spn.SBox[0, 0];
            this.dgvDistributionTable.Enabled = true;
            for (int index1 = 0; index1 < 16; ++index1)
            {
                for (int index2 = 0; index2 < 16; ++index2)
                    this.dgvDistributionTable.Rows[index1].Cells[index2].Value = (object)this.spn.DiffTable[index1, index2];
            }
            if (this.AutoFindTrail)
                this.dgvDistributionTable.Enabled = false;
            this.dgvDistributionTable.Refresh();
        }

        private void btnAutoFindTrail_Click(object sender, EventArgs e)
        {
            if (this.spn.SBox[0, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 128) | this.spn.SBox[1, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 128) | this.spn.SBox[2, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 128) | this.spn.SBox[3, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 128))
            {
                this.Cursor = Cursors.AppStarting;
                this.spn.Probability = this.spn.AutoFindTrail();
                this.tbGbProbability.Text = string.Format("{0:E4}", (object)this.spn.Probability);
                this.tbGbInputDiff.Text = string.Format("{0:X4}", (object)this.spn.DiffInput);
                this.tbGbOutputDiff.Text = string.Format("{0:X4}", (object)this.spn.DiffOutput);
                this.dgvDistributionTable.Enabled = true;
                for (int index1 = 0; index1 < 16; ++index1)
                {
                    this.dgvDistributionTable.Columns[index1].DefaultCellStyle.BackColor = Color.White;
                    for (int index2 = 0; index2 < 16; ++index2)
                        this.dgvDistributionTable.Rows[index1].Cells[index2].Style.BackColor = Color.White;
                }
                this.dgvDistributionTable.Enabled = false;
                this.Cursor = Cursors.Default;
            }
            else
            {
                int num = (int)MessageBox.Show("Musíte aktivovať aspoň 1 S-Box v poslednom kole kliknutím pravým tlačidlom myši na príslušný S-Box.", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.btnAutoFindTrail.Enabled = false;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidationResult validationResult = this.spn.ValidateTrail();
            if (validationResult != null)
            {
                string text = "Validácia neúspešná." + Environment.NewLine;
                int num1 = 1;
                if (validationResult.NullInputDiffernce)
                {
                    text = text + "Chyba " + (object)num1 + ": Vstupná diferencia nesmie byť nulová." + Environment.NewLine;
                    ++num1;
                }
                if (validationResult.NullOutputDifference)
                {
                    text = text + "Chyba " + (object)num1 + ": Výstupná diferencia nesmie byť nulová." + Environment.NewLine;
                    ++num1;
                }
                if (validationResult.SBoxWrongInputBits != null)
                {
                    foreach (SBox sboxWrongInputBit in validationResult.SBoxWrongInputBits)
                    {
                        text = text + "Chyba " + (object)num1 + ": " + sboxWrongInputBit.btnSbox.Text + " má neplatnú vstupnú diferenciu." + Environment.NewLine;
                        ++num1;
                    }
                }
                int num2 = (int)MessageBox.Show(text, "Validácia zlyhala", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int num = (int)MessageBox.Show("Validácia prebehla úspešne.", "Validácia úspešná", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Result result = new Result(this.spn);
            if (this.spn.ValidateTrail() == null)
            {
                int num1 = (int)result.ShowDialog((IWin32Window)this);
            }
            else
            {
                int num2 = (int)MessageBox.Show("Overte, či vstupná a výstupná diferencia SPN nie je nulová a či S-Boxy majú platné vstupné a výstupné diferencie.", "Validácia zlyhala", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void vymažSPNSieťToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                    this.spn.SBox[index1, index2].SetDefaultSettings();
            }
            this.spn.DiffInput = (ushort)0;
            this.dgvDistributionTable.Enabled = !this.AutoFindTrail;
            this.tbGbProbability.Text = "";
            this.tbGbInputDiff.Text = "";
            this.tbGbOutputDiff.Text = "";
            this.spn.Refresh();
            this.dgvDistributionTable.Enabled = true;
            for (int index3 = 0; index3 < 16; ++index3)
            {
                this.dgvDistributionTable.Columns[index3].DefaultCellStyle.BackColor = Color.White;
                for (int index4 = 0; index4 < 16; ++index4)
                    this.dgvDistributionTable.Rows[index3].Cells[index4].Style.BackColor = Color.White;
            }
            this.dgvDistributionTable.Rows[0].Cells[0].Selected = true;
            if (!this.AutoFindTrail)
                return;
            this.btnAutoFindTrail.Enabled = true;
        }

        private void nastavenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this.spn.RunTestCount);
            settings.SettingsForSpnChanged += new Settings.SettingsForSpnChangedEventHandler(this.settings_SettingsForSpnChanged);
            if (settings.ShowDialog((IWin32Window)this) != DialogResult.OK)
                return;
            this.vymažSPNSieťToolStripMenuItem_Click((object)this, (EventArgs)null);
            this.Form1_Load((object)this, (EventArgs)null);
            this.btnAutoFindTrail.Enabled = this.AutoFindTrail;
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)new Help().ShowDialog((IWin32Window)this);
        }

        private void dgvDistributionTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            byte sBoxInputDiff = 0;
            byte sBoxOutputDiff = 0;
            for (byte index1 = 0; index1 < (byte)16; ++index1)
            {
                for (byte index2 = 0; index2 < (byte)16; ++index2)
                {
                    if (this.dgvDistributionTable.Rows[(int)index1].Cells[(int)index2].Selected)
                    {
                        sBoxInputDiff = index1;
                        sBoxOutputDiff = index2;
                    }
                }
            }
            if (!this.lastSBox.btnSbox.Name.EndsWith("4"))
            {
                this.spn.Probability = this.spn.ManualFindTrail(ref this.lastSBox, sBoxInputDiff, sBoxOutputDiff, (double)(ushort)this.dgvDistributionTable.Rows[(int)sBoxInputDiff].Cells[(int)sBoxOutputDiff].Value / 16.0);
                if (this.spn.ValidateTrail() == null)
                {
                    this.spn.Probability = 1.0;
                    for (int index3 = 0; index3 < 4; ++index3)
                    {
                        this.spn.DiffOutput |= (ushort)(((int)this.spn.SBox[index3, 3].BitsIn & 15) << (3 - index3) * 4);
                        this.spn.DiffInput |= (ushort)(((int)this.spn.SBox[index3, 0].BitsIn & 15) << (3 - index3) * 4);
                        for (int index4 = 0; index4 < 4; ++index4)
                        {
                            if (this.spn.SBox[index4, index3].Activated && index3 < 3)
                                this.spn.Probability *= this.spn.SBox[index4, index3].Probability;
                        }
                    }
                }
            }
            if (this.spn.ValidateTrail() == null)
            {
                this.tbGbProbability.Text = string.Format("{0:E4}", (object)this.spn.Probability);
                this.tbGbInputDiff.Text = string.Format("{0:X4}", (object)this.spn.DiffInput);
                this.tbGbOutputDiff.Text = string.Format("{0:X4}", (object)this.spn.DiffOutput);
            }
            else
            {
                this.tbGbProbability.Text = "";
                this.tbGbInputDiff.Text = "";
                this.tbGbOutputDiff.Text = "";
            }
        }

        private void dgvDistributionTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintCells(e.ClipBounds, DataGridViewPaintParts.All);
            e.PaintHeader(DataGridViewPaintParts.Background | DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
            e.Handled = true;
        }

        private void dgvDistributionTable_CellFormatting(
          object sender,
          DataGridViewCellFormattingEventArgs e)
        {
            this.dgvDistributionTable.Rows[e.RowIndex].HeaderCell.Value = (object)string.Format("{0:X}", (object)e.RowIndex);
        }

        private void spn_SBoxClick(object sender, EventArgs e)
        {
            if (!(sender is SBox currentSBox))
                return;
            this.lastSBox = currentSBox;
            if (this.AutoFindTrail)
            {
                if (this.spn.DiffInput == (ushort)0)
                {
                    if (!currentSBox.btnSbox.Name.EndsWith("4"))
                        return;
                    if (currentSBox.btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128))
                    {
                        currentSBox.btnSbox.BackColor = currentSBox.DefaultSBoxColor;
                    }
                    else
                    {
                        if (!(currentSBox.btnSbox.BackColor == currentSBox.DefaultSBoxColor))
                            return;
                        currentSBox.btnSbox.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
                    }
                }
                else
                {
                    this.dgvDistributionTable.Enabled = true;
                    for (int index1 = 0; index1 < 16; ++index1)
                    {
                        this.dgvDistributionTable.Columns[index1].DefaultCellStyle.BackColor = Color.White;
                        for (int index2 = 0; index2 < 16; ++index2)
                            this.dgvDistributionTable.Rows[index1].Cells[index2].Style.BackColor = Color.White;
                    }
                    for (int index = 0; index < 16; ++index)
                    {
                        this.dgvDistributionTable.Rows[(int)currentSBox.BitsIn].Cells[index].Style.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 192);
                        this.dgvDistributionTable.Rows[index].Cells[(int)currentSBox.BitsOut].Style.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 192);
                    }
                    this.dgvDistributionTable.Rows[(int)currentSBox.BitsIn].Cells[(int)currentSBox.BitsOut].Selected = true;
                    this.dgvDistributionTable.Enabled = false;
                }
            }
            else
            {
                this.dgvDistributionTable.Enabled = !currentSBox.btnSbox.Name.EndsWith("4");
                for (int index3 = 0; index3 < 16; ++index3)
                {
                    this.dgvDistributionTable.Columns[index3].DefaultCellStyle.BackColor = Color.White;
                    for (int index4 = 0; index4 < 16; ++index4)
                        this.dgvDistributionTable.Rows[index3].Cells[index4].Style.BackColor = Color.White;
                }
                byte roundInputDiff = this.spn.GetRoundInputDiff(currentSBox);
                for (int index = 0; index < 16; ++index)
                {
                    if (Convert.ToInt32(currentSBox.btnSbox.Name[currentSBox.btnSbox.Name.Length - 1].ToString()) - 1 != 0)
                        this.dgvDistributionTable.Rows[(int)roundInputDiff].Cells[index].Style.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 225, 225);
                }
                for (int index = 0; index < 16; ++index)
                {
                    this.dgvDistributionTable.Rows[(int)currentSBox.BitsIn].Cells[index].Style.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 192);
                    this.dgvDistributionTable.Rows[index].Cells[(int)currentSBox.BitsOut].Style.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue, 192);
                }
                this.dgvDistributionTable.Rows[(int)currentSBox.BitsIn].Cells[(int)currentSBox.BitsOut].Selected = true;
            }
        }

        private void settings_SettingsForSpnChanged(object sender, Spn_SettingsEventArgs e)
        {
            if (e.updateKey)
                this.spn.Key = e.Key;
            if (e.updateSubstitution)
                this.spn.Substitution = e.Substitution;
            if (e.updateRunTestCount)
                this.spn.RunTestCount = e.RunTestCount;
            this.spn.SetDiffTable();
        }
    }
}
