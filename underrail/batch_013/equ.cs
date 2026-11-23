using System;
using System.Diagnostics;

// Token: 0x02002161 RID: 8545
[bmq("1.1.5.1_Wbb3_BalorsHammerDurabilityFix", "1.1.5.1", "wbb3", true)]
public sealed class equ : fg
{
	// Token: 0x0600C90E RID: 51470 RVA: 0x00470828 File Offset: 0x0046EA28
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
					aspect.aa().Offense.u().Durability = (double)aspect.aa().Offense.u().TypedDefinition.yj();
					aspect.aa().Offense.q().Durability = (double)aspect.aa().Offense.q().TypedDefinition.yj();
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
