using System;

using R5T.F0044;
using R5T.Z0000;


namespace R5T.F0048
{
    public static class Instances
    {
        public static INameOperator NameOperator { get; } = F0044.NameOperator.Instance;
        public static INameTokens NameTokens { get; } = F0044.NameTokens.Instance;
        public static ISolutionNameTokens SolutionNameTokens { get; } = F0048.SolutionNameTokens.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}