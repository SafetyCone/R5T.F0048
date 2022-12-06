using System;


namespace R5T.F0048
{
	public class SolutionDescriptionOperator : ISolutionDescriptionOperator
	{
		#region Infrastructure

	    public static ISolutionDescriptionOperator Instance { get; } = new SolutionDescriptionOperator();

	    private SolutionDescriptionOperator()
	    {
        }

	    #endregion
	}
}