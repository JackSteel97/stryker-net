namespace Stryker.Core.Options.Inputs
{
    public class ScoreIgnoresNoCoverageInput : Input<bool?>
    {
        public override bool? Default => false;

        protected override string Description => @"Setting this flag makes Stryker ignore any NoCoverage mutants when calculating the mutation score, effectively forcing their count to be zero";

        public bool Validate()
        {
            return SuppliedInput ?? false;
        }
    }
}
