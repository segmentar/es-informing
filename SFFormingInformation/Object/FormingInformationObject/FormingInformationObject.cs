using Core;

namespace Core.Shared
{
    using System;

    public partial class SFFormingInformation
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SFFormingCluster) + ' ' + "::" + ' ' + nameof(SFFormingInformation) + ' ' + '{',
                String.Empty + '.' + "information",
                String.Empty + '}'
            });
        }
    }
}
