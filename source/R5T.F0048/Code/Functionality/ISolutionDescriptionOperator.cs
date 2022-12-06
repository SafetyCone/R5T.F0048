using System;

using R5T.T0132;


namespace R5T.F0048
{
	[FunctionalityMarker]
	public partial interface ISolutionDescriptionOperator : IFunctionalityMarker
	{
		public string GetSolutionDescription_FromLibraryDescription(string libraryDescription)
		{
			// The solution description is just the library description.
			var solutionDescription = libraryDescription;
			return solutionDescription;
		}
	}
}