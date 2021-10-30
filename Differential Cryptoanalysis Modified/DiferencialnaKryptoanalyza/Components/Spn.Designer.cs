// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Components.Spn
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using DiferencialnaKryptoanalyza.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza.Components
{
    public partial class Spn : UserControl
    {
        private const short roundCount = 4;
        public const int c = 10;
        private DiferencialnaKryptoanalyza.Components.SBox[,] sBox = new DiferencialnaKryptoanalyza.Components.SBox[4, 4];
        private readonly System.Windows.Forms.Label[] label = new System.Windows.Forms.Label[5];
        private readonly Line[] lineInput = new Line[16];
        private readonly Line[] lineOutput = new Line[16];
        private ushort[,] diffTable = new ushort[16, 16];
        private ushort diffInput;
        private ushort diffOutput;
        private uint key = 982832703;
        private ushort[] subKey = new ushort[5];
        private ushort[] p = new ushort[16]
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
        private ushort[] s = new ushort[16]
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
        private IContainer components;

        public DiferencialnaKryptoanalyza.Components.SBox[,] SBox
        {
            get => this.sBox;
            set => this.sBox = value;
        }

        public System.Windows.Forms.Label[] Label => this.label;

        public Line[] LineInput => this.lineInput;

        public Line[] LineOutput => this.lineOutput;

        public ushort[,] DiffTable
        {
            get => this.diffTable;
            set => this.diffTable = value;
        }

        public ushort DiffInput
        {
            get => this.diffInput;
            set => this.diffInput = value;
        }

        public ushort DiffOutput
        {
            get => this.diffOutput;
            set => this.diffOutput = value;
        }

        public int RunTestCount { get; set; }

        public int RightPairCount { get; set; }

        public uint Key
        {
            get => this.key;
            set
            {
                this.key = value;
                this.subKey = this.SubKey;
            }
        }

        public ushort[] SubKey
        {
            get
            {
                this.key = this.key << 16 | this.key >> 16;
                for (int index = 0; index < 5; ++index)
                {
                    this.subKey[index] = (ushort)this.key;
                    this.key = this.key << 4 | this.key >> 28;
                }
                this.key = this.key >> 4 | this.key << 28;
                return this.subKey;
            }
        }

        public ushort[] Permutation
        {
            get => this.p;
            set => this.p = value;
        }

        public ushort[] Substitution
        {
            get => this.s;
            set => this.s = value;
        }

        public double Probability { get; set; }

        public bool IsValidTrail
        {
            get
            {
                ushort num1 = 0;
                ushort num2 = 0;
                for (int index = 0; index < 4; ++index)
                {
                    num1 |= (ushort)(((int)this.SBox[index, 0].BitsIn & 15) << (3 - index) * 4);
                    num2 |= (ushort)(((int)this.SBox[index, 3].BitsOut & 15) << (3 - index) * 4);
                }
                if (num1 == (ushort)0 || num2 == (ushort)0)
                    return false;
                for (int index1 = 0; index1 < 3; ++index1)
                {
                    ushort text;
                    ushort num3 = text = (ushort)0;
                    for (int index2 = 0; index2 < 4; ++index2)
                    {
                        num3 |= (ushort)(((int)this.SBox[index2, index1 + 1].BitsIn & 15) << (3 - index2) * 4);
                        text |= (ushort)(((int)this.SBox[index2, index1].BitsOut & 15) << (3 - index2) * 4);
                    }
                    ushort num4 = this.ApplyPermutation(text);
                    if ((int)num3 != (int)num4)
                    {
                        for (int index3 = 0; index3 < 4; ++index3)
                        {
                            if (((int)num3 & 15 << (3 - index3) * 4) != ((int)num4 & 15 << (3 - index3) * 4))
                                return false;
                        }
                    }
                }
                return true;
            }
        }

        public event Spn.Spn_SBoxClickEventHandler SBoxClick;

        private void InitializeSBox()
        {
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    DiferencialnaKryptoanalyza.Components.SBox[,] sBox = this.sBox;
                    int index3 = index1;
                    int index4 = index2;
                    DiferencialnaKryptoanalyza.Components.SBox sbox1 = new DiferencialnaKryptoanalyza.Components.SBox();
                    sbox1.Location = new Point(index1 * 70 + 5, index2 * 110 + 70);
                    DiferencialnaKryptoanalyza.Components.SBox sbox2 = sbox1;
                    sBox[index3, index4] = sbox2;
                    this.sBox[index1, index2].Controls["btnSbox"].Text += ((object)(index1 + 1)).ToString();
                    this.sBox[index1, index2].Controls["btnSbox"].Text += ((object)(index2 + 1)).ToString();
                    this.sBox[index1, index2].Controls["btnSbox"].Name = "btnSbox" + (index1 + 1).ToString() + (index2 + 1).ToString();
                    this.Controls.Add((Control)this.sBox[index1, index2]);
                    this.sBox[index1, index2].SBoxClick += new DiferencialnaKryptoanalyza.Components.SBox.SBoxClickEventHandler(this.Spn_SBoxClick);
                }
            }
        }

        private void InitializeLabel()
        {
            for (int index1 = 0; index1 < 5; ++index1)
            {
                System.Windows.Forms.Label[] label1 = this.label;
                int index2 = index1;
                System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                label2.AutoSize = false;
                label2.Width = 270;
                label2.Height = 18;
                label2.BorderStyle = BorderStyle.FixedSingle;
                label2.Text = "";
                label2.Location = new Point(8, index1 * 110 + 38);
                System.Windows.Forms.Label label3 = label2;
                label1[index2] = label3;
                this.Controls.Add((Control)this.label[index1]);
                this.label[index1].BringToFront();
            }
        }

        private void InitializeLineCoordinates()
        {
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    for (int index3 = 0; index3 < 4; ++index3)
                    {
                        this.sBox[index3, index2].LineIn[3].Start = new Point(this.sBox[index3, index2].Location.X + 10, this.sBox[index3, index2].Location.Y - 15);
                        this.sBox[index3, index2].LineIn[3].End = new Point(this.sBox[index3, index2].Location.X + 10, this.sBox[index3, index2].Location.Y);
                        this.sBox[index3, index2].LineOut[3].Start = new Point(this.sBox[index3, index2].Location.X + 10, this.sBox[index3, index2].Location.Y + 23);
                        this.sBox[index3, index2].LineOut[3].End = new Point(this.sBox[0, index2].Location.X + 10 + index3 * 15, this.sBox[index3, index2].Location.Y + 77);
                        this.sBox[index3, index2].LineIn[2].Start = new Point(this.sBox[index3, index2].Location.X + 25, this.sBox[index3, index2].Location.Y - 15);
                        this.sBox[index3, index2].LineIn[2].End = new Point(this.sBox[index3, index2].Location.X + 25, this.sBox[index3, index2].Location.Y);
                        this.sBox[index3, index2].LineOut[2].Start = new Point(this.sBox[index3, index2].Location.X + 25, this.sBox[index3, index2].Location.Y + 23);
                        this.sBox[index3, index2].LineOut[2].End = new Point(this.sBox[1, index2].Location.X + 10 + index3 * 15, this.sBox[index3, index2].Location.Y + 77);
                        this.sBox[index3, index2].LineIn[1].Start = new Point(this.sBox[index3, index2].Location.X + 40, this.sBox[index3, index2].Location.Y - 15);
                        this.sBox[index3, index2].LineIn[1].End = new Point(this.sBox[index3, index2].Location.X + 40, this.sBox[index3, index2].Location.Y);
                        this.sBox[index3, index2].LineOut[1].Start = new Point(this.sBox[index3, index2].Location.X + 40, this.sBox[index3, index2].Location.Y + 23);
                        this.sBox[index3, index2].LineOut[1].End = new Point(this.sBox[2, index2].Location.X + 10 + index3 * 15, this.sBox[index3, index2].Location.Y + 77);
                        this.sBox[index3, index2].LineIn[0].Start = new Point(this.sBox[index3, index2].Location.X + 55, this.sBox[index3, index2].Location.Y - 15);
                        this.sBox[index3, index2].LineIn[0].End = new Point(this.sBox[index3, index2].Location.X + 55, this.sBox[index3, index2].Location.Y);
                        this.sBox[index3, index2].LineOut[0].Start = new Point(this.sBox[index3, index2].Location.X + 55, this.sBox[index3, index2].Location.Y + 23);
                        this.sBox[index3, index2].LineOut[0].End = new Point(this.sBox[3, index2].Location.X + 10 + index3 * 15, this.sBox[index3, index2].Location.Y + 77);
                    }
                    if (index2 == 3)
                    {
                        for (int index4 = 0; index4 < 4; ++index4)
                        {
                            this.sBox[index4, index2].LineOut[3].End = new Point(this.sBox[index4, index2].Location.X + 10, this.sBox[index4, index2].Location.Y + 77);
                            this.sBox[index4, index2].LineOut[2].End = new Point(this.sBox[index4, index2].Location.X + 25, this.sBox[index4, index2].Location.Y + 77);
                            this.sBox[index4, index2].LineOut[1].End = new Point(this.sBox[index4, index2].Location.X + 40, this.sBox[index4, index2].Location.Y + 77);
                            this.sBox[index4, index2].LineOut[0].End = new Point(this.sBox[index4, index2].Location.X + 55, this.sBox[index4, index2].Location.Y + 77);
                        }
                        for (int index5 = 0; index5 < 16; ++index5)
                        {
                            this.lineInput[index5].Start = new Point(this.sBox[index5 / 4, 0].Location.X + 10 + 15 * (3 - index5 % 4), this.sBox[index5 / 4, 0].Location.Y - 33);
                            this.lineInput[index5].End = new Point(this.sBox[index5 / 4, 0].Location.X + 10 + 15 * (3 - index5 % 4), this.sBox[index5 / 4, 0].Location.Y - 47);
                        }
                        for (int index6 = 0; index6 < 16; ++index6)
                        {
                            this.lineOutput[index6].Start = new Point(this.sBox[index6 / 4, 3].Location.X + 10 + 15 * (3 - index6 % 4), this.sBox[index6 / 4, 3].Location.Y + 90);
                            this.lineOutput[index6].End = new Point(this.sBox[index6 / 4, 3].Location.X + 10 + 15 * (3 - index6 % 4), this.sBox[index6 / 4, 3].Location.Y + 109);
                        }
                    }
                }
            }
        }

        private ushort ApplySubstitution(ushort text)
        {
            ushort num = text;
            text = (ushort)0;
            for (int index = 3; index >= 0; --index)
                text |= (ushort)((int)this.s[((int)num & 15 << index * 4) >> index * 4] << index * 4 | (int)text << (4 - index) * 4);
            return text;
        }

        private ushort ApplySubstitutionInverted(ushort text)
        {
            ushort num = text;
            text = (ushort)0;
            for (int index1 = 3; index1 >= 0; --index1)
            {
                for (int index2 = 0; index2 < 16; ++index2)
                {
                    if (((int)num & 15 << index1 * 4) >> index1 * 4 == (int)this.s[index2])
                    {
                        text |= (ushort)(index2 << index1 * 4);
                        break;
                    }
                }
            }
            return text;
        }

        private ushort ApplyPermutation(ushort text)
        {
            ushort num = text;
            text = (ushort)0;
            for (int index = 0; index < 16; ++index)
                text |= (ushort)((uint)(((int)num & 32768 >> index) << index) >> (int)this.p[index]);
            return text;
        }

        public ushort Encrypt(ushort plainText)
        {
            plainText ^= this.subKey[0];
            for (int index = 1; index < 4; ++index)
            {
                plainText = this.ApplySubstitution(plainText);
                plainText = this.ApplyPermutation(plainText);
                plainText ^= this.subKey[index];
            }
            plainText = this.ApplySubstitution(plainText);
            plainText ^= this.subKey[4];
            return plainText;
        }

        public ushort Decrypt(ushort plainText)
        {
            plainText ^= this.subKey[4];
            plainText = this.ApplySubstitutionInverted(plainText);
            for (int index = 3; index > 0; --index)
            {
                plainText ^= this.subKey[index];
                plainText = this.ApplyPermutation(plainText);
                plainText = this.ApplySubstitutionInverted(plainText);
            }
            plainText ^= this.subKey[0];
            return plainText;
        }

        public void SetDiffTable()
        {
            byte[] numArray = new byte[16];
            for (byte index1 = 0; index1 < (byte)16; ++index1)
            {
                for (byte index2 = 0; index2 < (byte)16; ++index2)
                {
                    byte num1 = (byte)((uint)index1 ^ (uint)index2);
                    byte num2 = (byte)((uint)(byte)this.ApplySubstitution((ushort)index2) ^ (uint)(byte)this.ApplySubstitution((ushort)num1));
                    ++numArray[(int)num2];
                }
                for (byte index3 = 0; index3 < (byte)16; ++index3)
                {
                    this.DiffTable[(int)index1, (int)index3] = (ushort)numArray[(int)index3];
                    numArray[(int)index3] = (byte)0;
                }
            }
        }

        public double AutoFindTrail()
        {
            DiferencialnaKryptoanalyza.Components.SBox[,] sboxArray = new DiferencialnaKryptoanalyza.Components.SBox[4, 4];
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                    sboxArray[index1, index2] = new DiferencialnaKryptoanalyza.Components.SBox();
            }
            ushort num1 = 0;
            this.diffInput = this.diffOutput = (ushort)0;
            double num2 = 0.0;
            for (ushort index3 = 1; index3 < ushort.MaxValue; ++index3)
            {
                for (int index4 = 0; index4 < 4; ++index4)
                {
                    for (int index5 = 0; index5 < 4; ++index5)
                    {
                        this.sBox[index5, index4].BitsIn = (byte)0;
                        this.sBox[index5, index4].BitsOut = (byte)0;
                        this.sBox[index5, index4].Activated = false;
                        if (index4 < 3)
                            this.sBox[index5, index4].btnSbox.BackColor = this.sBox[index5, index4].DefaultSBoxColor;
                    }
                }
                ushort num3 = index3;
                double num4 = 1.0;
                for (int index6 = 0; index6 < 3; ++index6)
                {
                    for (int index7 = 0; index7 < 4; ++index7)
                    {
                        this.sBox[index7, index6].BitsIn = (byte)(((int)num3 & (int)(ushort)(15 << 4 * (3 - index7))) >> 4 * (3 - index7));
                        if (this.sBox[index7, index6].BitsIn > (byte)0)
                            this.sBox[index7, index6].Activated = true;
                    }
                    for (int index8 = 0; index8 < 4; ++index8)
                    {
                        if (!this.sBox[index8, index6].Activated)
                        {
                            this.sBox[index8, index6].BitsOut = (byte)0;
                        }
                        else
                        {
                            ushort num5 = 0;
                            for (byte index9 = 0; index9 < (byte)16; ++index9)
                            {
                                if ((int)this.DiffTable[(int)this.sBox[index8, index6].BitsIn, (int)index9] > (int)num5)
                                {
                                    num5 = this.DiffTable[(int)this.sBox[index8, index6].BitsIn, (int)index9];
                                    this.sBox[index8, index6].BitsOut = index9;
                                }
                            }
                            this.sBox[index8, index6].Probability = (double)num5 / 16.0;
                        }
                    }
                    ushort text = 0;
                    for (int index10 = 0; index10 < 4; ++index10)
                        text |= (ushort)((uint)this.sBox[index10, index6].BitsOut << 4 * (3 - index10));
                    num3 = this.ApplyPermutation(text);
                }
                for (int index11 = 0; index11 < 4; ++index11)
                {
                    this.sBox[index11, 3].BitsIn = (byte)(((int)num3 & (int)(ushort)(15 << 4 * (3 - index11))) >> 4 * (3 - index11));
                    if (this.sBox[index11, 3].BitsIn > (byte)0)
                        this.sBox[index11, 3].Activated = true;
                }
                for (int index12 = 0; index12 < 4; ++index12)
                {
                    if (!this.sBox[index12, 3].Activated)
                    {
                        this.sBox[index12, 3].BitsOut = (byte)0;
                    }
                    else
                    {
                        ushort num6 = 0;
                        for (byte index13 = 0; index13 < (byte)16; ++index13)
                        {
                            if ((int)this.DiffTable[(int)this.sBox[index12, 3].BitsIn, (int)index13] > (int)num6)
                            {
                                num6 = this.DiffTable[(int)this.sBox[index12, 3].BitsIn, (int)index13];
                                this.sBox[index12, 3].BitsOut = index13;
                            }
                        }
                        this.sBox[index12, 3].Probability = (double)num6 / 16.0;
                    }
                }
                int num7 = 0;
                int num8 = 0;
                int num9 = 0;
                for (int index14 = 0; index14 < 4; ++index14)
                {
                    if (this.sBox[index14, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128))
                        ++num8;
                    if (this.sBox[index14, 3].Activated)
                        ++num7;
                    if (this.sBox[index14, 3].btnSbox.BackColor == Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128) && this.sBox[index14, 3].Activated)
                        ++num9;
                }
                if (num8 == num7 && num9 == num7)
                {
                    for (int index15 = 0; index15 < 3; ++index15)
                    {
                        for (int index16 = 0; index16 < 4; ++index16)
                        {
                            if (this.sBox[index16, index15].Activated)
                                num4 *= this.sBox[index16, index15].Probability;
                        }
                    }
                    if (num4 > num2)
                    {
                        num2 = num4;
                        num1 = index3;
                        for (int index17 = 0; index17 < 4; ++index17)
                        {
                            for (int index18 = 0; index18 < 4; ++index18)
                            {
                                sboxArray[index17, index18].BitsIn = this.sBox[index17, index18].BitsIn;
                                sboxArray[index17, index18].BitsOut = this.sBox[index17, index18].BitsOut;
                                sboxArray[index17, index18].Activated = this.sBox[index17, index18].Activated;
                                sboxArray[index17, index18].Probability = this.sBox[index17, index18].Probability;
                            }
                        }
                    }
                }
            }
            for (int index19 = 0; index19 < 4; ++index19)
            {
                for (int index20 = 0; index20 < 4; ++index20)
                {
                    this.sBox[index19, index20].BitsIn = sboxArray[index19, index20].BitsIn;
                    this.sBox[index19, index20].BitsOut = sboxArray[index19, index20].BitsOut;
                    this.sBox[index19, index20].Activated = sboxArray[index19, index20].Activated;
                    this.sBox[index19, index20].Probability = sboxArray[index19, index20].Probability;
                    if (this.sBox[index19, index20].Activated && index20 < 3)
                        this.sBox[index19, index20].btnSbox.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
                }
            }
            this.RedrawTrail();
            this.diffInput = num1;
            for (int index = 0; index < 4; ++index)
                this.diffOutput |= (ushort)(((int)this.sBox[index, 3].BitsIn & 15) << (3 - index) * 4);
            return num2;
        }

        public double ManualFindTrail(
          ref DiferencialnaKryptoanalyza.Components.SBox currentSBox,
          byte sBoxInputDiff,
          byte sBoxOutputDiff,
          double prob)
        {
            if (!currentSBox.Activated && sBoxInputDiff > (byte)0)
            {
                currentSBox.Activated = true;
                currentSBox.BitsIn = sBoxInputDiff;
                currentSBox.BitsOut = sBoxOutputDiff;
                currentSBox.Probability = prob;
                currentSBox.btnSbox.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            }
            else if (currentSBox.Activated && sBoxInputDiff > (byte)0 && sBoxOutputDiff > (byte)0)
            {
                currentSBox.BitsIn = sBoxInputDiff;
                currentSBox.BitsOut = sBoxOutputDiff;
                currentSBox.Probability = prob;
            }
            else if (currentSBox.Activated && sBoxInputDiff == (byte)0)
            {
                currentSBox.Activated = false;
                currentSBox.BitsIn = (byte)0;
                currentSBox.BitsOut = (byte)0;
                currentSBox.Probability = 0.0;
                currentSBox.btnSbox.BackColor = currentSBox.DefaultSBoxColor;
            }
            if (currentSBox.btnSbox.Text.EndsWith("3"))
            {
                ushort text = 0;
                for (int index = 0; index < 4; ++index)
                    text |= (ushort)((uint)this.sBox[index, 2].BitsOut << (3 - index) * 4);
                ushort num1 = this.ApplyPermutation(text);
                for (int index1 = 0; index1 < 4; ++index1)
                {
                    this.sBox[index1, 3].BitsIn = (byte)(((int)num1 & 15 << (3 - index1) * 4) >> (3 - index1) * 4);
                    ushort num2 = 0;
                    for (byte index2 = 0; index2 < (byte)16; ++index2)
                    {
                        if ((int)this.DiffTable[(int)this.sBox[index1, 3].BitsIn, (int)index2] > (int)num2)
                        {
                            num2 = this.DiffTable[(int)this.sBox[index1, 3].BitsIn, (int)index2];
                            this.sBox[index1, 3].BitsOut = index2;
                        }
                    }
                    if (this.sBox[index1, 3].BitsIn != (byte)0)
                    {
                        this.sBox[index1, 3].Activated = true;
                        this.sBox[index1, 3].btnSbox.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
                    }
                    else
                    {
                        this.sBox[index1, 3].Activated = false;
                        this.sBox[index1, 3].BitsOut = (byte)0;
                        this.sBox[index1, 3].btnSbox.BackColor = currentSBox.DefaultSBoxColor;
                    }
                }
            }
            this.RedrawTrail();
            return this.Probability;
        }

        public ValidationResult ValidateTrail()
        {
            ValidationResult validationResult = (ValidationResult)null;
            ushort num1 = 0;
            ushort num2 = 0;
            for (int index = 0; index < 4; ++index)
                num1 |= (ushort)(((int)this.SBox[index, 0].BitsIn & 15) << (3 - index) * 4);
            if (num1 == (ushort)0)
                validationResult = new ValidationResult()
                {
                    NullInputDiffernce = true
                };
            for (int index = 0; index < 4; ++index)
                num2 |= (ushort)(((int)this.SBox[index, 3].BitsOut & 15) << (3 - index) * 4);
            if (num2 == (ushort)0)
            {
                if (validationResult == null)
                    validationResult = new ValidationResult()
                    {
                        NullOutputDifference = true
                    };
                else
                    validationResult.NullOutputDifference = true;
            }
            for (int index1 = 0; index1 < 3; ++index1)
            {
                ushort text;
                ushort num3 = text = (ushort)0;
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    num3 |= (ushort)(((int)this.SBox[index2, index1 + 1].BitsIn & 15) << (3 - index2) * 4);
                    text |= (ushort)(((int)this.SBox[index2, index1].BitsOut & 15) << (3 - index2) * 4);
                }
                ushort num4 = this.ApplyPermutation(text);
                if ((int)num3 != (int)num4)
                {
                    for (int index3 = 0; index3 < 4; ++index3)
                    {
                        if (((int)num3 & 15 << (3 - index3) * 4) != ((int)num4 & 15 << (3 - index3) * 4))
                        {
                            if (validationResult == null)
                                validationResult = new ValidationResult()
                                {
                                    SBoxWrongInputBits = new List<DiferencialnaKryptoanalyza.Components.SBox>()
                  {
                    this.SBox[index3, index1 + 1]
                  }
                                };
                            else if (validationResult.SBoxWrongInputBits == null)
                                validationResult.SBoxWrongInputBits = new List<DiferencialnaKryptoanalyza.Components.SBox>()
                {
                  this.SBox[index3, index1 + 1]
                };
                            else
                                validationResult.SBoxWrongInputBits.Add(this.SBox[index3, index1 + 1]);
                        }
                    }
                }
            }
            this.diffInput = this.diffOutput = (ushort)0;
            for (int index = 0; index < 4; ++index)
            {
                this.diffInput |= (ushort)(((int)this.sBox[index, 0].BitsIn & 15) << (3 - index) * 4);
                this.diffOutput |= (ushort)(((int)this.sBox[index, 3].BitsIn & 15) << (3 - index) * 4);
            }
            return validationResult;
        }

        public int[] Attack(int repeatCount)
        {
            this.RightPairCount = 0;
            this.diffInput = this.diffOutput = (ushort)0;
            Random random = new Random();
            bool[] flagArray = new bool[4];
            ushort num1 = 0;
            for (int index = 0; index < 4; ++index)
            {
                flagArray[index] = this.sBox[index, 3].Activated;
                this.diffInput |= (ushort)(((int)this.sBox[index, 0].BitsIn & 15) << (3 - index) * 4);
                this.diffOutput |= (ushort)(((int)this.sBox[index, 3].BitsIn & 15) << (3 - index) * 4);
                if (flagArray[index])
                    ++num1;
            }
            uint uint32 = Convert.ToUInt32(Math.Pow(16.0, (double)num1));
            int[] numArray = new int[(int)(IntPtr)uint32];
            for (int index1 = 0; index1 < repeatCount; ++index1)
            {
                bool flag = true;
                ushort plainText1 = (ushort)random.Next();
                ushort plainText2 = (ushort)((uint)plainText1 ^ (uint)this.diffInput);
                ushort num2 = this.Encrypt(plainText1);
                ushort num3 = this.Encrypt(plainText2);
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    if ((flagArray[index2] || ((int)num2 & 15 << (3 - index2) * 4) != ((int)num3 & 15 << (3 - index2) * 4)) && !flagArray[index2])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    ++this.RightPairCount;
                    for (uint index3 = 0; index3 < uint32; ++index3)
                    {
                        int num4 = 1;
                        ushort text1 = num2;
                        ushort text2 = num3;
                        for (int index4 = 0; index4 < 4; ++index4)
                        {
                            if (flagArray[index4])
                            {
                                ushort num5 = (ushort)(((long)index3 & (long)(15 << ((int)num1 - num4) * 4)) >> ((int)num1 - num4) * 4 << (3 - index4) * 4);
                                text1 ^= num5;
                                text2 ^= num5;
                                ++num4;
                            }
                        }
                        ushort num6 = this.ApplySubstitutionInverted(text1);
                        ushort num7 = this.ApplySubstitutionInverted(text2);
                        for (int index5 = 0; index5 < 4; ++index5)
                        {
                            if (!flagArray[index5])
                            {
                                num6 &= (ushort)(4095 >> index5 * 4 | 4095 << 16 - index5 * 4);
                                num7 &= (ushort)(4095 >> index5 * 4 | 4095 << 16 - index5 * 4);
                            }
                        }
                        if ((int)this.diffOutput == (int)(ushort)((uint)num6 ^ (uint)num7))
                            ++numArray[(int)index3];
                    }
                }
            }
            return numArray;
        }

        public byte GetRoundInputDiff(DiferencialnaKryptoanalyza.Components.SBox currentSBox)
        {
            ushort text = 0;
            for (int index = 0; index < 4; ++index)
            {
                if (Convert.ToInt32(currentSBox.btnSbox.Name[currentSBox.btnSbox.Name.Length - 1].ToString()) - 2 >= 0)
                    text |= (ushort)((uint)this.SBox[index, Convert.ToInt32(currentSBox.btnSbox.Name[currentSBox.btnSbox.Name.Length - 1].ToString()) - 2].BitsOut << (3 - index) * 4);
            }
            ushort num1 = this.ApplyPermutation(text);
            int int32 = Convert.ToInt32(currentSBox.btnSbox.Name[currentSBox.btnSbox.Name.Length - 2].ToString());
            byte num2 = 0;
            for (int index = 0; index < 4; ++index)
            {
                if (index == int32 - 1)
                    num2 = (byte)(((int)num1 & 15 << (3 - index) * 4) >> (3 - index) * 4);
            }
            return num2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Draw(Color.Black, 1);
            this.RedrawTrail();
        }

        private void Draw(Color color, int penWidth)
        {
            Pen pen = new Pen(color, (float)penWidth);
            Graphics graphics = this.CreateGraphics();
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    for (int index3 = 0; index3 < 4; ++index3)
                    {
                        graphics.DrawLine(pen, this.sBox[index3, index1].LineIn[index2].Start, this.sBox[index3, index1].LineIn[index2].End);
                        graphics.DrawLine(pen, this.sBox[index3, index1].LineOut[index2].Start, this.sBox[index3, index1].LineOut[index2].End);
                    }
                }
            }
            for (int index = 0; index < 16; ++index)
            {
                graphics.DrawLine(pen, this.lineInput[index].Start, this.lineInput[index].End);
                graphics.DrawLine(pen, this.lineOutput[index].Start, this.lineOutput[index].End);
            }
            pen.Dispose();
            graphics.Dispose();
        }

        private void RedrawTrail()
        {
            this.Draw(this.BackColor, 3);
            this.Draw(Color.Black, 1);
            Pen pen = new Pen(Color.Black, 3f);
            Graphics graphics = this.CreateGraphics();
            for (int index1 = 0; index1 < 4; ++index1)
            {
                for (int index2 = 0; index2 < 4; ++index2)
                {
                    if (this.sBox[index2, index1].Activated)
                    {
                        for (int index3 = 0; index3 < 4; ++index3)
                        {
                            if (((int)this.sBox[index2, index1].BitsIn & 1 << index3) >> index3 == 1)
                                graphics.DrawLine(pen, this.sBox[index2, index1].LineIn[index3].Start, this.sBox[index2, index1].LineIn[index3].End);
                            if (((int)this.sBox[index2, index1].BitsOut & 1 << index3) >> index3 == 1)
                                graphics.DrawLine(pen, this.sBox[index2, index1].LineOut[index3].Start, this.sBox[index2, index1].LineOut[index3].End);
                        }
                    }
                }
            }
            for (int index = 0; index < 16; ++index)
            {
                if (((int)this.sBox[index / 4, 0].BitsIn & 1 << index % 4) >> index % 4 == 1)
                    graphics.DrawLine(pen, this.LineInput[index].Start, this.LineInput[index].End);
                if (((int)this.sBox[index / 4, 3].BitsOut & 1 << index % 4) >> index % 4 == 1)
                    graphics.DrawLine(pen, this.LineOutput[index].Start, this.LineOutput[index].End);
            }
            pen.Dispose();
            graphics.Dispose();
        }

        private void Spn_SBoxClick(object sender, EventArgs e)
        {
            if (this.SBoxClick == null)
                return;
            this.SBoxClick(sender, e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Name = nameof(Spn);
            this.Size = new Size(290, 540);
            this.ResumeLayout(false);
        }

        public delegate void Spn_SBoxClickEventHandler(object sender, EventArgs e);
    }
}
