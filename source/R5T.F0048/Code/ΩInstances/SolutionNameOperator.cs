using System;


namespace R5T.F0048
{
	public class SolutionNameOperator : ISolutionNameOperator
	{
		#region Infrastructure

	    public static ISolutionNameOperator Instance { get; } = new SolutionNameOperator();

	    private SolutionNameOperator()
	    {
        }

	    #endregion
	}
}