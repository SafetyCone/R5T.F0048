using System;


namespace R5T.F0048
{
	public class SolutionNameTokens : ISolutionNameTokens
	{
		#region Infrastructure

	    public static ISolutionNameTokens Instance { get; } = new SolutionNameTokens();

	    private SolutionNameTokens()
	    {
        }

	    #endregion
	}
}