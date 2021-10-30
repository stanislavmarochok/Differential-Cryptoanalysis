// Decompiled with JetBrains decompiler
// Type: DiferencialnaKryptoanalyza.Classes.ValidationResult
// Assembly: DiferencialnaKryptoanalyza, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3670D41-7EF9-49F2-BBCD-880EF030CDEE
// Assembly location: D:\Other\Study\Ing\3 semester\I-NKS\zadanie-06\sources\LA_DA\DiferencialnaKryptoanalyza.exe

using DiferencialnaKryptoanalyza.Components;
using System.Collections.Generic;

namespace DiferencialnaKryptoanalyza.Classes
{
    public sealed class ValidationResult
    {
        public bool NullInputDiffernce { get; set; }

        public bool NullOutputDifference { get; set; }

        public List<SBox> SBoxWrongInputBits { get; set; }
    }
}
