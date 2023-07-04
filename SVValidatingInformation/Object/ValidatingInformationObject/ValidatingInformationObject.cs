using Core;

namespace Core.Shared
{
    using System;

    public partial class SVValidatingInformation
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(SVValidatingCluster) + ' ' + "::" + ' ' + nameof(SVValidatingInformation) + ' ' + '{',
                String.Empty + '.' + "information",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Validate) + ':' + ' ' + ". . ." + ' ' + $"[{Validate.Equals(default(SVValidate))}]",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Validator) + ':' + ' ' + ". . ." + ' ' + $"[{Validator.Equals(default(SVValidator))}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Validation) + ':' + ' ' + ". . ." + ' ' + $"[{Validation.Equals(default(SVValidation))}]",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Filter) + ':' + ' ' + ". . ." + ' ' + $"[{Filter == default}]",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Filtered) + ':' + ' ' + ". . ." + ' ' + $"[{Filtered.Equals(default(SFFiltered))}]",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Filtration) + ':' + ' ' + ". . ." + ' ' + $"[{Filtration.Equals(default(SFFiltration))}]",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Feedback) + ':' + ' ' + Feedback,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Validate) + ':',
                String.Empty + Validate,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Validator) + ':',
                String.Empty + Validator,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Validation) + ':',
                String.Empty + Validation,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Filter) + ':',
                String.Empty + Filter,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(Filtered) + ':',
                String.Empty + Filtered
            });
        }
    }
}
