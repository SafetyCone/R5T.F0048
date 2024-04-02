using System;

using R5T.T0132;


namespace R5T.F0048
{
	[FunctionalityMarker]
	public partial interface ISolutionNameOperator : IFunctionalityMarker
	{
		public string Adjust_Name_ForPrivacy(
			string unadjustedSolutionName,
			bool isPrivate)
		{
			var output = Instances.NameOperator.AdjustNameForPrivacy(
				unadjustedSolutionName,
				isPrivate);

			return output;
		}

		public string Append_Token(
			string solutionName,
			string token)
        {
			var tokenSeparator = this.GetTokenSeparator();

			var output = $"{solutionName}{tokenSeparator}{token}";
			return output;
        }

        public string Get_ConstructionSolutionName(string solutionName)
		{
			var constructionSolutionName = this.Append_Token(
				solutionName,
				Instances.SolutionNameTokens.Construction);

			return constructionSolutionName;
		}

        public string GetTokenSeparator()
        {
			var tokenSeparator = Instances.Strings.Period;
			return tokenSeparator;
        }

		public string Get_SolutionName(string libraryName)
		{
			// The solution name is just the library name.
			var output = libraryName;
			return output;
		}

		public string GetUnadjustedSolutionName_FromUnadjustedLibraryName(string unadjustedLibraryName)
		{
			// The unadjusted solution name is just the unadjusted library name.
			var unadjustedSolutionName = unadjustedLibraryName;
			return unadjustedSolutionName;
		}
	}
}