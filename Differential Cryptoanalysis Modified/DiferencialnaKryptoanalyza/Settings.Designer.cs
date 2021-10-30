using DiferencialnaKryptoanalyza.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    public partial class Settings : Form
    {
        private IContainer components;
        private TabControl lblTabSBox;
        private TabPage tabKey;
        private TabPage tabSBox;
        private Label lblTabKey;
        private TextBox tbKey;
        private Button btnOk;
        private Button btnCancel;
        private Label label1;
        private Label lblTabSBoxSubstitution;
        private TextBox tbSubstitution;
        private TabPage tabAutoFindTrail;
        private Label lblTabAutoFindTrail;
        public CheckBox checkBox1;
        private TextBox tbRunTestCount;
        private Label lblTabRunTestCount;
        private readonly ushort[] Substitution = new ushort[16];
        private uint Key;
        private bool AnyError;
        private readonly int RunTestCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTabSBox = new TabControl();
            this.tabKey = new TabPage();
            this.lblTabKey = new Label();
            this.tbKey = new TextBox();
            this.tabSBox = new TabPage();
            this.lblTabSBoxSubstitution = new Label();
            this.tbSubstitution = new TextBox();
            this.label1 = new Label();
            this.tabAutoFindTrail = new TabPage();
            this.tbRunTestCount = new TextBox();
            this.lblTabRunTestCount = new Label();
            this.checkBox1 = new CheckBox();
            this.lblTabAutoFindTrail = new Label();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.lblTabSBox.SuspendLayout();
            this.tabKey.SuspendLayout();
            this.tabSBox.SuspendLayout();
            this.tabAutoFindTrail.SuspendLayout();
            this.SuspendLayout();
            this.lblTabSBox.Controls.Add((Control)this.tabKey);
            this.lblTabSBox.Controls.Add((Control)this.tabSBox);
            this.lblTabSBox.Controls.Add((Control)this.tabAutoFindTrail);
            this.lblTabSBox.Location = new Point(12, 12);
            this.lblTabSBox.Name = "lblTabSBox";
            this.lblTabSBox.SelectedIndex = 0;
            this.lblTabSBox.Size = new Size(275, 164);
            this.lblTabSBox.TabIndex = 0;
            this.tabKey.Controls.Add((Control)this.lblTabKey);
            this.tabKey.Controls.Add((Control)this.tbKey);
            this.tabKey.Location = new Point(4, 22);
            this.tabKey.Name = "tabKey";
            this.tabKey.Padding = new Padding(3);
            this.tabKey.Size = new Size(267, 138);
            this.tabKey.TabIndex = 0;
            this.tabKey.Text = "Kľúč";
            this.tabKey.UseVisualStyleBackColor = true;
            this.lblTabKey.AutoSize = true;
            this.lblTabKey.Location = new Point(6, 13);
            this.lblTabKey.Name = "lblTabKey";
            this.lblTabKey.Size = new Size(189, 13);
            this.lblTabKey.TabIndex = 1;
            this.lblTabKey.Text = "Zadajte kľúč v hexadecimálnom tvare:";
            this.tbKey.Location = new Point(9, 42);
            this.tbKey.MaxLength = 8;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new Size(68, 20);
            this.tbKey.TabIndex = 1;
            this.tabSBox.Controls.Add((Control)this.lblTabSBoxSubstitution);
            this.tabSBox.Controls.Add((Control)this.tbSubstitution);
            this.tabSBox.Controls.Add((Control)this.label1);
            this.tabSBox.Location = new Point(4, 22);
            this.tabSBox.Name = "tabSBox";
            this.tabSBox.Padding = new Padding(3);
            this.tabSBox.Size = new Size(267, 138);
            this.tabSBox.TabIndex = 1;
            this.tabSBox.Text = "S-Box";
            this.tabSBox.UseVisualStyleBackColor = true;
            this.lblTabSBoxSubstitution.AutoSize = true;
            this.lblTabSBoxSubstitution.Location = new Point(9, 42);
            this.lblTabSBoxSubstitution.Name = "lblTabSBoxSubstitution";
            this.lblTabSBoxSubstitution.Size = new Size(109, 13);
            this.lblTabSBoxSubstitution.TabIndex = 2;
            this.lblTabSBoxSubstitution.Text = "0123456789ABCDEF";
            this.tbSubstitution.Location = new Point(9, 67);
            this.tbSubstitution.MaxLength = 16;
            this.tbSubstitution.Name = "tbSubstitution";
            this.tbSubstitution.Size = new Size(118, 20);
            this.tbSubstitution.TabIndex = 1;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(254, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadajte substitúciu S-Boxu v hexadecimálnom tvare:";
            this.tabAutoFindTrail.Controls.Add((Control)this.tbRunTestCount);
            this.tabAutoFindTrail.Controls.Add((Control)this.lblTabRunTestCount);
            this.tabAutoFindTrail.Controls.Add((Control)this.checkBox1);
            this.tabAutoFindTrail.Controls.Add((Control)this.lblTabAutoFindTrail);
            this.tabAutoFindTrail.Location = new Point(4, 22);
            this.tabAutoFindTrail.Name = "tabAutoFindTrail";
            this.tabAutoFindTrail.Size = new Size(267, 138);
            this.tabAutoFindTrail.TabIndex = 3;
            this.tabAutoFindTrail.Text = "Cesta šírenia a počet spustení";
            this.tabAutoFindTrail.UseVisualStyleBackColor = true;
            this.tbRunTestCount.Location = new Point(9, 105);
            this.tbRunTestCount.MaxLength = 6;
            this.tbRunTestCount.Name = "tbRunTestCount";
            this.tbRunTestCount.Size = new Size(57, 20);
            this.tbRunTestCount.TabIndex = 3;
            this.lblTabRunTestCount.Location = new Point(6, 71);
            this.lblTabRunTestCount.Name = "lblTabRunTestCount";
            this.lblTabRunTestCount.Size = new Size(265, 42);
            this.lblTabRunTestCount.TabIndex = 2;
            this.lblTabRunTestCount.Text = "Zadajte počet testov útoku (počet testovaných párov). Pre automatický počet testov útoku zadajte \"0\".";
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new Point(9, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(85, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Automatická";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.lblTabAutoFindTrail.AutoSize = true;
            this.lblTabAutoFindTrail.Location = new Point(6, 13);
            this.lblTabAutoFindTrail.Name = "lblTabAutoFindTrail";
            this.lblTabAutoFindTrail.Size = new Size(232, 13);
            this.lblTabAutoFindTrail.TabIndex = 0;
            this.lblTabAutoFindTrail.Text = "Zvoľte možnosť určenia trasy šírenia diferencie:";
            this.btnOk.DialogResult = DialogResult.OK;
            this.btnOk.Location = new Point(131, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new EventHandler(this.btnOk_Click);
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Location = new Point(212, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.AcceptButton = (IButtonControl)this.btnOk;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = (IButtonControl)this.btnCancel;
            this.ClientSize = new Size(299, 217);
            this.Controls.Add((Control)this.btnCancel);
            this.Controls.Add((Control)this.btnOk);
            this.Controls.Add((Control)this.lblTabSBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = new Size(408, 278);
            this.MinimumSize = new Size(8, 78);
            this.Name = nameof(Settings);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Nastavenia";
            this.Load += new EventHandler(this.Settings_Load);
            this.lblTabSBox.ResumeLayout(false);
            this.tabKey.ResumeLayout(false);
            this.tabKey.PerformLayout();
            this.tabSBox.ResumeLayout(false);
            this.tabSBox.PerformLayout();
            this.tabAutoFindTrail.ResumeLayout(false);
            this.tabAutoFindTrail.PerformLayout();
            this.ResumeLayout(false);
        }

        public event Settings.SettingsForSpnChangedEventHandler SettingsForSpnChanged;

        public Settings(int runTestCount)
        {
            this.InitializeComponent();
            this.RunTestCount = runTestCount;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (!(this.Owner is Main owner))
                return;
            this.checkBox1.Checked = owner.AutoFindTrail;
            this.tbRunTestCount.Text = this.RunTestCount.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.AnyError = false;
            if (this.tbKey.Text != "")
            {
                try
                {
                    this.Key = Convert.ToUInt32(this.tbKey.Text, 16);
                }
                catch (Exception ex)
                {
                    this.AnyError = true;
                    int num = (int)MessageBox.Show("Chyba pri prevode zadaného reťazca na číslo. Hexadecimálny reťazec by mal obsahovať len znaky \"0123456789ABCDEF\".", "Chyba zadaného kľúča", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            if (this.tbSubstitution.Text != "")
            {
                try
                {
                    for (int index = 0; index < 16; ++index)
                        this.Substitution[index] = (ushort)16;
                    for (int index1 = 0; index1 < 16; ++index1)
                    {
                        for (int index2 = 0; index2 < 16; ++index2)
                        {
                            if ((int)this.Substitution[index2] == (int)Convert.ToUInt16(this.tbSubstitution.Text[index1].ToString(), 16))
                                throw new ApplicationException();
                        }
                        this.Substitution[index1] = Convert.ToUInt16(this.tbSubstitution.Text[index1].ToString(), 16);
                    }
                }
                catch (ApplicationException ex)
                {
                    this.AnyError = true;
                    int num = (int)MessageBox.Show("Každá číslica \"0, 1, 2, ... ,F\" sa musí vyskytovať v substitúcii práve raz.", "Chyba zadanej substitúcie", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                catch (Exception ex)
                {
                    this.AnyError = true;
                    int num = (int)MessageBox.Show("Chyba pri prevode zadaného reťazca na číslo. Hexadecimálny reťazec by mal obsahovať len znaky \"0123456789ABCDEF\".", "Chyba zadanej substitúcie", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            int result = -1;
            try
            {
                if (!int.TryParse(this.tbRunTestCount.Text, out result))
                {
                    int num = (int)MessageBox.Show("Chyba pri prevode zadaného reťazca na číslo. Reťazec by mal obsahovať len znaky \"0123456789\".", "Chyba zadaného počtu testovaných párov.", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                this.AnyError = true;
                int num = (int)MessageBox.Show("Chyba pri prevode zadaného reťazca na číslo. Reťazec by mal obsahovať len znaky \"0123456789\".", "Chyba zadaného počtu testovaných párov.", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            if ((this.tbKey.Text != "" || this.tbSubstitution.Text != "" || result >= 0) && !this.AnyError && this.SettingsForSpnChanged != null)
                this.SettingsForSpnChanged((object)this, new Spn_SettingsEventArgs(this.Key, this.tbKey.Text != "", this.Substitution, this.tbSubstitution.Text != "", result, result >= 0));
            if (!(this.Owner is Main owner))
                return;
            owner.AutoFindTrail = this.checkBox1.Checked;
        }

        public delegate void SettingsForSpnChangedEventHandler(object sender, Spn_SettingsEventArgs e);
    }
}
