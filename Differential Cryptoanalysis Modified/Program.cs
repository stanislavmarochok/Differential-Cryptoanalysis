// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Program
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using System;
using System.Windows.Forms;

namespace DiferencialnaKryptoanalyza
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new DiferencialnaKryptoanalyza.Main());
        }
    }
}
