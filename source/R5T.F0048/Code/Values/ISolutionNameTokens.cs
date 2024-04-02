using System;

using R5T.T0131;


namespace R5T.F0048
{
	[ValuesMarker]
	public partial interface ISolutionNameTokens : IValuesMarker
	{
        /// <inheritdoc cref="F0044.INameTokens.Construction"/>
        public string Construction => Instances.NameTokens.Construction;
    }
}