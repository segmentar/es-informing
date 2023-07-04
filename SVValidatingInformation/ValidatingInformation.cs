using Core;

namespace Core.Shared
{
    using System;

    public partial class SVValidatingInformation
    {
        public SVValidate Validate = default(SVValidate);

        public SVValidator Validator = default(SVValidator);

        public SVValidation Validation = default(SVValidation);

        public SFFilter Filter = default;

        public SFFiltered Filtered = default(SFFiltered);

        public SFFiltration Filtration = default(SFFiltration);

        public Int32 Position = -1;

        public Int32 Feedback = -1;

        public SVValidatingInformation()
        {
            return;
        }

        ~SVValidatingInformation()
        {
            return;
        }
    }
}
