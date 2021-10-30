// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Classes.Spn_SettingsEventArgs
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using System;

namespace DiferencialnaKryptoanalyza.Classes
{
    public class Spn_SettingsEventArgs : EventArgs
    {
        public bool updateKey { get; set; }

        public bool updateSubstitution { get; set; }

        public bool updateRunTestCount { get; set; }

        public uint Key { get; set; }

        public ushort[] Substitution { get; set; }

        public int RunTestCount { get; set; }

        public Spn_SettingsEventArgs(
          uint Key,
          bool updateKey,
          ushort[] Substitution,
          bool updateSubstitution,
          int RunTestCount,
          bool updateRunTestCount)
        {
            this.Key = Key;
            this.updateKey = updateKey;
            this.Substitution = Substitution;
            this.updateSubstitution = updateSubstitution;
            this.RunTestCount = RunTestCount;
            this.updateRunTestCount = updateRunTestCount;
        }
    }
}
