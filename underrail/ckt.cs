using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x020021B6 RID: 8630
[bmq("1.0.1.11_Cc15_LjubostankasJackhammer", "1.0.1.11", "cc15", false)]
public sealed class ckt : fg
{
	// Token: 0x0600C9C2 RID: 51650 RVA: 0x004763C0 File Offset: 0x004745C0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("36d241af-3297-485f-b731-9729f0c19580"), A_1.n("cc15")).ao() as c5x;
			if (c5x != null && c5x.h.b != null && Enumerable.FirstOrDefault<coh>(c5x.h.b.aa().Bag.b("jackhammer")) != null)
			{
				Enumerable.FirstOrDefault<coh>(c5x.h.b.aa().Bag.b("jackhammer")).MaxBatteryLegacy = 100;
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
