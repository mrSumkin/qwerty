using System;
using System.Diagnostics;

// Token: 0x020021A6 RID: 8614
[bmq("1.0.1.5_JyeDeputyBehavior", "1.0.1.5", "jye1", false)]
public sealed class ce0 : fg
{
	// Token: 0x0600C9A0 RID: 51616 RVA: 0x00475240 File Offset: 0x00473440
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("351f9eb8-ceea-4607-86e9-2eef6c6d14c8"), A_1.n("jye1")).ao() as c5x;
			if (c5x != null)
			{
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null && aspect.ac() != "jye_deputy")
				{
					aspect.b("jye_deputy");
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
