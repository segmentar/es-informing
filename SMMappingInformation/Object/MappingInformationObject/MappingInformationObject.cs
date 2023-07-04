using Core;

namespace Core.Shared
{
    using System;

    public partial class SMMappingInformation
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SMMappingCluster) + ' ' + "::" + ' ' + nameof(SMMappingInformation) + ' ' + '{',
                String.Empty + '.' + "information",
                String.Empty + '}'
            });
        }
    }
}
