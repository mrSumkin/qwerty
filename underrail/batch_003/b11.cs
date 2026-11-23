using System;
using System.Diagnostics;

// Token: 0x02002165 RID: 8549
[bmq("1.1.0.11_Xpbl_hc4_SetPesticideGrenadesContainerJob", "1.1.0.11", "xpbl_hc4", false)]
public sealed class b11 : fg
{
	// Token: 0x0600C917 RID: 51479 RVA: 0x00470DA0 File Offset: 0x0046EFA0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("6ad5dced-e605-46c6-8c7f-8b9a377f3bb1"), A_1.n("xpbl_hc4")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null && c7j.m().Count <= 0)
				{
					c4f c4f = new c4f();
					c4f.Properties["loc_xpbl_hc_foundPesticideGrenades"] = true;
					c7j.m().Add(c4f);
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
