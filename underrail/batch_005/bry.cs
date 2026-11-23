using System;
using System.Linq;

// Token: 0x020007D5 RID: 2005
public static class bry
{
	// Token: 0x06003241 RID: 12865 RVA: 0x00136814 File Offset: 0x00134A14
	public static c5x a(c5x A_0)
	{
		if (A_0.h.b != null && A_0.h.b.aa().Gear.h() == null)
		{
			xm xm = new xm();
			xm.na(10);
			xm.nc(15);
			cgd cgd = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
			if (cgd != null)
			{
				cgd.Battery = (double)cgd.MaxBattery;
				A_0.h.b.aa().Gear.h().a(cgd, true);
			}
		}
		return A_0;
	}
}
