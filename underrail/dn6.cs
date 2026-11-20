using System;
using System.Diagnostics;

// Token: 0x020020BC RID: 8380
[bmq("1.1.5.3_Up7_QuakeDurabilityFix", "1.1.5.3", "up7", false)]
public sealed class dn6 : fg
{
	// Token: 0x0600C7E4 RID: 51172 RVA: 0x00466E20 File Offset: 0x00465020
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("8b829b60-10db-4d64-ae25-669b397b6c33"), A_1.n("up7")).ao() as c5x;
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
