using System;
using System.Collections.Generic;

// Token: 0x02000FB6 RID: 4022
[euj]
public sealed class b32
{
	// Token: 0x06005272 RID: 21106 RVA: 0x0024DCD4 File Offset: 0x0024BED4
	[ayh("MetallineEnergizationJoblets_Tick")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa().Gear.l().Item != null)
		{
			A_1.h.b.aa().Gear.l().Item.Battery = Math.Max(0.0, A_1.h.b.aa().Gear.l().Item.Battery - eus.f);
		}
	}
}
