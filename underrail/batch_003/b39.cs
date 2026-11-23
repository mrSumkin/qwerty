using System;
using System.Diagnostics;

// Token: 0x02002126 RID: 8486
[bmq("1.1.2.1_GMS3_BanditDialogFix", "1.1.2.1", "GammaCompound3", false)]
public sealed class b39 : fg
{
	// Token: 0x0600C898 RID: 51352 RVA: 0x0046BE78 File Offset: 0x0046A078
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("40027910-4da2-4518-9fb6-29b4f158bafd"), A_1.n("GammaCompound3")).ao() as c5x;
			if (c5x != null)
			{
				bn5 bn = c5x.GetAspect<j7>() as bn5;
				if (bn != null && !bn.e())
				{
					bn.b(true);
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
