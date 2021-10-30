using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DiferencialnaKryptoanalyza.Properties
{
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [DebuggerNonUserCode]
    internal class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals((object)DiferencialnaKryptoanalyza.Properties.Resources.resourceMan, (object)null))
                    DiferencialnaKryptoanalyza.Properties.Resources.resourceMan = new ResourceManager("DiferencialnaKryptoanalyza.Properties.Resources", typeof(DiferencialnaKryptoanalyza.Properties.Resources).Assembly);
                return DiferencialnaKryptoanalyza.Properties.Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => DiferencialnaKryptoanalyza.Properties.Resources.resourceCulture;
            set => DiferencialnaKryptoanalyza.Properties.Resources.resourceCulture = value;
        }
    }
}
