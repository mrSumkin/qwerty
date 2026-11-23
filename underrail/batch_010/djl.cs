using System;
using System.Diagnostics;

// Token: 0x020020DF RID: 8415
[bmq("1.1.5.0_Wbb3_BalorAddLiftingBelt", "1.1.5.0", "wbb3", false)]
public sealed class djl : fg
{
	// Token: 0x0600C817 RID: 51223 RVA: 0x00468768 File Offset: 0x00466968
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
					aspect.aa().Gear.e().a(new cjh(ez2.CreateDefinitonProvider<c27>("armor\\liftingBelt")), true);
					aspect.aa().bl();
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
