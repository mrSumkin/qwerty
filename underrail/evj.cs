using System;
using System.Diagnostics;

// Token: 0x02002100 RID: 8448
[bmq("1.0.3.4_LostVaultEntranceKeycardFix", "1.0.3.4", "lux-b9", false)]
public sealed class evj : fg
{
	// Token: 0x0600C84D RID: 51277 RVA: 0x00469E84 File Offset: 0x00468084
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("2aea6e96-6ebd-4a52-8088-8895954292d1"), A_1.n("lux-b9")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					foreach (coh coh in c7j.ItemContainer.z2())
					{
						if (coh.Definition.a5() == "key.lostVault_securitycard")
						{
							coh.CustomProperties["security_access:lostVault"] = 1;
						}
					}
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
