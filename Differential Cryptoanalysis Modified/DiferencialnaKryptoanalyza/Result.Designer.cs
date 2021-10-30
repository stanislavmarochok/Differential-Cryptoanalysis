// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Result
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using Aspose.Cells;
using ChartDLL;
using DiferencialnaKryptoanalyza.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    public partial class Result : Form
    {
        private readonly Spn spn;
        private BarChartVertical gr;
        private string[] graphValueX;
        private int[] graphValueY;
        private IContainer components;
        private GroupBox gbInfo;
        private GroupBox gbGraph;
        private PictureBox pictureBox1;
        private Label lblAtackTime;
        private Label lblProbabilitySubkeySPN;
        private Label lblProbabilitySubkeyComputed;
        private Label lblDiffOutput;
        private Label lblPotencialSubKey;
        private Label lblDiffInput;
        private Label lblRunTestCount;
        private TextBox tbAtackTime;
        private TextBox tbProbabilitySubkeyComputed;
        private TextBox tbProbabilitySubkeySPN;
        private TextBox tbPotencialSubKey;
        private TextBox tbDiffOutput;
        private TextBox tbDiffInput;
        private TextBox tbRuntTestCount;
        private TextBox tbRightPairCount;
        private Label lblRightPairCount;

        public Result(Spn spnPrev)
        {
            this.InitializeComponent();
            this.spn = spnPrev;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            this.graphValueX = new string[16];
            this.graphValueY = new int[16];
            if (this.spn.ValidateTrail() != null)
                return;
            stopwatch.Start();
            int[] numArray = this.spn.Attack(this.spn.RunTestCount == 0 ? ((int)(1.0 / this.spn.Probability) + 1) * 10 : this.spn.RunTestCount);
            stopwatch.Stop();
            this.SaveResultsToExcel(numArray);
            for (int index1 = 0; index1 < 16; ++index1)
            {
                int num = -1;
                int index2 = -1;
                for (int index3 = 0; index3 < numArray.Length; ++index3)
                {
                    if (numArray[index3] > num)
                    {
                        num = numArray[index3];
                        index2 = index3;
                    }
                }
                this.graphValueY[index1] = num;
                this.graphValueX[index1] = string.Format("{0:X}", (object)index2);
                numArray[index2] = -numArray[index2];
            }
            try
            {
                this.DrawGraph(this.graphValueX, this.graphValueY);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, "Chyba zobrazenia grafickej zavislosti.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            this.tbRuntTestCount.Text = this.spn.RunTestCount == 0 ? (((int)(1.0 / this.spn.Probability) + 1) * 10).ToString() : this.spn.RunTestCount.ToString();
            this.tbRightPairCount.Text = this.spn.RightPairCount.ToString();
            this.tbDiffInput.Text = string.Format("{0:X4}", (object)this.spn.DiffInput);
            this.tbDiffOutput.Text = string.Format("{0:X4}", (object)this.spn.DiffOutput);
            this.tbPotencialSubKey.Text = string.Format("{0:X4}", (object)this.PotencialSubkeyFormated(Convert.ToUInt16(this.graphValueX[0], 16)));
            this.tbProbabilitySubkeySPN.Text = string.Format("{0:E4}", (object)this.spn.Probability);
            this.tbProbabilitySubkeyComputed.Text = string.Format("{0:E4}", (object)((double)this.graphValueY[0] / (this.spn.RunTestCount == 0 ? (double)(((int)(1.0 / this.spn.Probability) + 1) * 10) : (double)this.spn.RunTestCount)));
            this.tbAtackTime.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void SaveResultsToExcel(int[] arr)
        {
            var book = new Workbook(); 
            Worksheet sheet = book.Worksheets[0]; 
            Cells cells = sheet.Cells; 

            cells[0, 0].PutValue("Key");
            cells[0, 1].PutValue("Pairs");

            List<Tuple<int, int>> sorted_list = new List<Tuple<int, int>>();
            for (int i = 0; i < arr.Length; i++)
                sorted_list.Add(new Tuple<int, int>(i, arr[i]));

            sorted_list.Sort((x, y) => {
                int result = y.Item2.CompareTo(x.Item2);
                return result == 0 ? x.Item1.CompareTo(y.Item1) : result;
            });

            for (int i = 0; i < sorted_list.Count; i++)
            {
                cells[i + 1, 0].PutValue(sorted_list[i].Item1.ToString("X"));
                cells[i + 1, 1].PutValue(sorted_list[i].Item2);
            }

            book.Save("results.xls");
        }

        private void Result_Resize(object sender, EventArgs e) { } //this.DrawGraph(this.graphValueX, this.graphValueY);

        private void DrawGraph(string[] valueX, int[] valueY)
        {
            BarChartVertical barChartVertical = new BarChartVertical("", this.pictureBox1.Width, this.pictureBox1.Height);
            barChartVertical.DataX = valueX;
            barChartVertical.DataY = valueY;
            barChartVertical.BarFillColor = 0;
            this.gr = barChartVertical;
            this.gr.CreateScreen();
            this.gr.DrawScreen();
            this.gr.DrawHeading();
            this.gr.DrawCanvasBgFill();
            this.gr.DrawLegendLabels();
            this.gr.DrawGridLines();
            this.gr.DrawGridLinesLabels();
            this.gr.DrawBars();
            this.gr.DrawXaxisLabels();
            this.gr.DrawZeroGridLine();
            this.gr.DrawZeroGridLineLabel();
            this.gr.DrawCanvasBorder();
            this.pictureBox1.Image = Image.FromStream((Stream)this.gr.DrawChartX());
        }

        private ushort PotencialSubkeyFormated(ushort subKey)
        {
            ushort num1 = 0;
            ushort num2 = 0;
            int num3 = 1;
            for (int index = 0; index < 4; ++index)
            {
                if (this.spn.SBox[index, 3].Activated)
                    ++num2;
            }
            for (int index = 0; index < 4; ++index)
            {
                if (this.spn.SBox[index, 3].Activated)
                {
                    num1 |= (ushort)(((int)subKey & 15 << ((int)num2 - num3) * 4) >> ((int)num2 - num3) * 4 << (3 - index) * 4);
                    ++num3;
                }
            }
            return num1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbInfo = new GroupBox();
            this.tbRightPairCount = new TextBox();
            this.lblRightPairCount = new Label();
            this.tbAtackTime = new TextBox();
            this.tbProbabilitySubkeyComputed = new TextBox();
            this.tbProbabilitySubkeySPN = new TextBox();
            this.tbPotencialSubKey = new TextBox();
            this.tbDiffOutput = new TextBox();
            this.tbDiffInput = new TextBox();
            this.tbRuntTestCount = new TextBox();
            this.lblAtackTime = new Label();
            this.lblProbabilitySubkeySPN = new Label();
            this.lblProbabilitySubkeyComputed = new Label();
            this.lblDiffOutput = new Label();
            this.lblPotencialSubKey = new Label();
            this.lblDiffInput = new Label();
            this.lblRunTestCount = new Label();
            this.gbGraph = new GroupBox();
            this.pictureBox1 = new PictureBox();
            this.gbInfo.SuspendLayout();
            this.gbGraph.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.gbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.gbInfo.Controls.Add((Control)this.tbRightPairCount);
            this.gbInfo.Controls.Add((Control)this.lblRightPairCount);
            this.gbInfo.Controls.Add((Control)this.tbAtackTime);
            this.gbInfo.Controls.Add((Control)this.tbProbabilitySubkeyComputed);
            this.gbInfo.Controls.Add((Control)this.tbProbabilitySubkeySPN);
            this.gbInfo.Controls.Add((Control)this.tbPotencialSubKey);
            this.gbInfo.Controls.Add((Control)this.tbDiffOutput);
            this.gbInfo.Controls.Add((Control)this.tbDiffInput);
            this.gbInfo.Controls.Add((Control)this.tbRuntTestCount);
            this.gbInfo.Controls.Add((Control)this.lblAtackTime);
            this.gbInfo.Controls.Add((Control)this.lblProbabilitySubkeySPN);
            this.gbInfo.Controls.Add((Control)this.lblProbabilitySubkeyComputed);
            this.gbInfo.Controls.Add((Control)this.lblDiffOutput);
            this.gbInfo.Controls.Add((Control)this.lblPotencialSubKey);
            this.gbInfo.Controls.Add((Control)this.lblDiffInput);
            this.gbInfo.Controls.Add((Control)this.lblRunTestCount);
            this.gbInfo.Location = new Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new Size(239, 440);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informácie";
            this.tbRightPairCount.Location = new Point(133, 54);
            this.tbRightPairCount.Name = "tbRightPairCount";
            this.tbRightPairCount.ReadOnly = true;
            this.tbRightPairCount.Size = new Size(100, 20);
            this.tbRightPairCount.TabIndex = 20;
            this.lblRightPairCount.Location = new Point(6, 57);
            this.lblRightPairCount.Name = "lblRightPairCount";
            this.lblRightPairCount.Size = new Size(120, 20);
            this.lblRightPairCount.TabIndex = 19;
            this.lblRightPairCount.Text = "Počet správnych párov";
            this.tbAtackTime.Location = new Point(133, 228);
            this.tbAtackTime.Name = "tbAtackTime";
            this.tbAtackTime.ReadOnly = true;
            this.tbAtackTime.Size = new Size(100, 20);
            this.tbAtackTime.TabIndex = 18;
            this.tbProbabilitySubkeyComputed.Location = new Point(133, 199);
            this.tbProbabilitySubkeyComputed.Name = "tbProbabilitySubkeyComputed";
            this.tbProbabilitySubkeyComputed.ReadOnly = true;
            this.tbProbabilitySubkeyComputed.Size = new Size(100, 20);
            this.tbProbabilitySubkeyComputed.TabIndex = 17;
            this.tbProbabilitySubkeySPN.Location = new Point(133, 170);
            this.tbProbabilitySubkeySPN.Name = "tbProbabilitySubkeySPN";
            this.tbProbabilitySubkeySPN.ReadOnly = true;
            this.tbProbabilitySubkeySPN.Size = new Size(100, 20);
            this.tbProbabilitySubkeySPN.TabIndex = 16;
            this.tbPotencialSubKey.Location = new Point(133, 141);
            this.tbPotencialSubKey.Name = "tbPotencialSubKey";
            this.tbPotencialSubKey.ReadOnly = true;
            this.tbPotencialSubKey.Size = new Size(100, 20);
            this.tbPotencialSubKey.TabIndex = 15;
            this.tbDiffOutput.Location = new Point(133, 112);
            this.tbDiffOutput.Name = "tbDiffOutput";
            this.tbDiffOutput.ReadOnly = true;
            this.tbDiffOutput.Size = new Size(100, 20);
            this.tbDiffOutput.TabIndex = 14;
            this.tbDiffInput.Location = new Point(133, 83);
            this.tbDiffInput.Name = "tbDiffInput";
            this.tbDiffInput.ReadOnly = true;
            this.tbDiffInput.Size = new Size(100, 20);
            this.tbDiffInput.TabIndex = 13;
            this.tbRuntTestCount.Location = new Point(133, 27);
            this.tbRuntTestCount.Name = "tbRuntTestCount";
            this.tbRuntTestCount.ReadOnly = true;
            this.tbRuntTestCount.Size = new Size(100, 20);
            this.tbRuntTestCount.TabIndex = 12;
            this.lblAtackTime.Location = new Point(6, 231);
            this.lblAtackTime.Name = "lblAtackTime";
            this.lblAtackTime.Size = new Size(120, 20);
            this.lblAtackTime.TabIndex = 11;
            this.lblAtackTime.Text = "Doba trvania útoku";
            this.lblProbabilitySubkeySPN.Location = new Point(6, 173);
            this.lblProbabilitySubkeySPN.Name = "lblProbabilitySubkeySPN";
            this.lblProbabilitySubkeySPN.Size = new Size(120, 20);
            this.lblProbabilitySubkeySPN.TabIndex = 5;
            this.lblProbabilitySubkeySPN.Text = "P podkľúča podľa SPN";
            this.lblProbabilitySubkeyComputed.Location = new Point(6, 202);
            this.lblProbabilitySubkeyComputed.Name = "lblProbabilitySubkeyComputed";
            this.lblProbabilitySubkeyComputed.Size = new Size(120, 20);
            this.lblProbabilitySubkeyComputed.TabIndex = 4;
            this.lblProbabilitySubkeyComputed.Text = "P podkľúča dosiahnutá";
            this.lblDiffOutput.Location = new Point(6, 115);
            this.lblDiffOutput.Name = "lblDiffOutput";
            this.lblDiffOutput.Size = new Size(120, 20);
            this.lblDiffOutput.TabIndex = 3;
            this.lblDiffOutput.Text = "Výstupná diferencia";
            this.lblPotencialSubKey.Location = new Point(6, 144);
            this.lblPotencialSubKey.Name = "lblPotencialSubKey";
            this.lblPotencialSubKey.Size = new Size(120, 20);
            this.lblPotencialSubKey.TabIndex = 2;
            this.lblPotencialSubKey.Text = "Potenciálny podkľúč";
            this.lblDiffInput.Location = new Point(6, 86);
            this.lblDiffInput.Name = "lblDiffInput";
            this.lblDiffInput.Size = new Size(120, 20);
            this.lblDiffInput.TabIndex = 1;
            this.lblDiffInput.Text = "Vstupná diferencia";
            this.lblRunTestCount.Location = new Point(6, 30);
            this.lblRunTestCount.Name = "lblRunTestCount";
            this.lblRunTestCount.Size = new Size(120, 20);
            this.lblRunTestCount.TabIndex = 0;
            this.lblRunTestCount.Text = "Počet spustení";
            this.gbGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gbGraph.Controls.Add((Control)this.pictureBox1);
            this.gbGraph.Location = new Point(257, 12);
            this.gbGraph.Name = "gbGraph";
            this.gbGraph.Size = new Size(615, 440);
            this.gbGraph.TabIndex = 1;
            this.gbGraph.TabStop = false;
            this.gbGraph.Text = "Grafické zobrazenie";
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Location = new Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(609, 421);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(884, 464);
            this.Controls.Add((Control)this.gbGraph);
            this.Controls.Add((Control)this.gbInfo);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(700, 315);
            this.Name = nameof(Result);
            this.ShowInTaskbar = false;
            this.Text = "Výsledky";
            this.Load += new EventHandler(this.Result_Load);
            this.Resize += new EventHandler(this.Result_Resize);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbGraph.ResumeLayout(false);
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
        }
    }
}
