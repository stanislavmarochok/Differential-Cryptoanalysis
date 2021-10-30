// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Components.SBox
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using DiferencialnaKryptoanalyza.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza.Components
{
    public partial class SBox : UserControl
    {
        private readonly Color defaultSBoxColor;
        private IContainer components;
        public Button btnSbox;

        public byte BitsIn { get; set; }

        public byte BitsOut { get; set; }

        public bool Activated { get; set; }

        public Line[] LineIn { get; private set; }

        public Line[] LineOut { get; private set; }

        public Color DefaultSBoxColor => this.defaultSBoxColor;

        public double Probability { get; set; }

        public event SBox.SBoxClickEventHandler SBoxClick;

        public void SetDefaultSettings()
        {
            this.BitsIn = (byte)0;
            this.BitsOut = (byte)0;
            this.Probability = 0.0;
            this.Activated = false;
            this.btnSbox.BackColor = this.defaultSBoxColor;
            this.btnSbox.FlatStyle = FlatStyle.Standard;
        }

        private void btnSbox_Click(object sender, EventArgs e)
        {
            if (this.SBoxClick == null)
                return;
            this.SBoxClick((object)this, (EventArgs)null);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSbox = new Button();
            this.SuspendLayout();
            this.btnSbox.Location = new Point(3, 1);
            this.btnSbox.Name = "btnSbox";
            this.btnSbox.Size = new Size(61, 23);
            this.btnSbox.TabIndex = 0;
            this.btnSbox.Text = "S-Box";
            this.btnSbox.UseVisualStyleBackColor = true;
            this.btnSbox.Click += new EventHandler(this.btnSbox_Click);
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add((Control)this.btnSbox);
            this.Name = nameof(SBox);
            this.Size = new Size(67, 24);
            this.ResumeLayout(false);
        }

        public delegate void SBoxClickEventHandler(object sender, EventArgs e);
    }
}
