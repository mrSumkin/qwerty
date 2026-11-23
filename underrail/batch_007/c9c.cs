using System;
using System.Diagnostics;

// Token: 0x0200215B RID: 8539
[bmq("1.1.0.15_Wbb3_BalorModelChange", "1.1.0.15", "wbb3", false)]
public sealed class c9c : fg
{
	// Token: 0x0600C902 RID: 51458 RVA: 0x004700F4 File Offset: 0x0046E2F4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("56e5abe7-9ca1-4d52-922b-e55d2350cd52"), A_1.n("wbb3")).ao() as c5x;
			if (c5x != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a(bln.cs);
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
