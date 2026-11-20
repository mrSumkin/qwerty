using System;
using System.Diagnostics;

// Token: 0x020021B9 RID: 8633
[bmq("1.0.1.11_GMS2Desk", "1.0.1.11", "GammaCompound2", false)]
public sealed class hl : fg
{
	// Token: 0x0600C9C8 RID: 51656 RVA: 0x00476730 File Offset: 0x00474930
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("14c14a28-e3b2-4765-ba75-ac67e43db05d"), A_1.n("GammaCompound2")).ao() as c5x;
			if (c5x != null)
			{
				c5x.q("Desk");
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
