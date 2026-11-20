using System;
using System.Collections.Generic;

// Token: 0x02000FB1 RID: 4017
[euj]
public sealed class d31
{
	// Token: 0x06005258 RID: 21080 RVA: 0x0024D970 File Offset: 0x0024BB70
	[ayh("EnergyShieldEmpowerment_Tick")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa().Gear.l().Item != null)
		{
			A_1.h.b.aa().Gear.l().Item.Battery = Math.Max(0.0, A_1.h.b.aa().Gear.l().Item.Battery - aqd.f);
		}
	}
}
