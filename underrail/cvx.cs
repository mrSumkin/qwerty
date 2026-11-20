using System;
using System.Diagnostics;

// Token: 0x0200219E RID: 8606
[bmq("1.0.1.5_MerchantsMoneyAndPDA", "1.0.1.5", "lu-b22u", false)]
public sealed class cvx : fg
{
	// Token: 0x0600C990 RID: 51600 RVA: 0x00474758 File Offset: 0x00472958
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("5020983a-c770-4b18-b90b-1732246717a8"), A_1.n("lu-b22u")).ao() as c5x;
			if (c5x != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_loc_lu-b22_placedMoneyAndPDA", new bool?(false)).Value)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<dj3>("plot\\MerchantsPDA"));
					coh coh2 = new d48(ez2.CreateDefinitonProvider<a54>("currency\\StygianCoin"))
					{
						Stacks = 210
					};
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_loc_lu-b22_placedMoneyAndPDA"] = true;
					}
					if (coh2 != null)
					{
						c7j.ItemContainer.z3(coh2, true);
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
