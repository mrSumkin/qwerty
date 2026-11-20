using System;
using System.Diagnostics;

// Token: 0x02002150 RID: 8528
[bmq("1.1.0.10_CVW47_LancesSkimmerFix", "1.1.0.10", "cvw47", false)]
public sealed class e3j : fg
{
	// Token: 0x0600C8E7 RID: 51431 RVA: 0x0046F18C File Offset: 0x0046D38C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("cece053d-383a-466f-bea5-fd873d641663"), A_1.n("cvw47")).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				if (c5x.h.b.aa().Vehicle.g() == 0.0)
				{
					c5x.h.b.aa().Vehicle.a((double)c5x.h.b.aa().Vehicle.am());
				}
				if (c5x.h.b.aa().Vehicle.ag() == 0.0)
				{
					c5x.h.b.aa().Vehicle.b((double)c5x.h.b.aa().Vehicle.v());
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
