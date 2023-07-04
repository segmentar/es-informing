using Core;

namespace Core.Shared
{
    using System;

    public partial class SEEscapingInformation
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SEEscapingCluster) + ' ' + "::" + ' ' + nameof(SEEscapingInformation) + ' ' + '{',
                String.Empty + '.' + "information",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Result) + ':' + ' ' + $"[{Result}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ResultList) + ':' + ' ' + ". . ." + ' ' + $"[{ResultList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ResultList) + ':',
                String.Empty + String.Join('\n'.ToString(), ResultList)
            });
        }
    }
}
