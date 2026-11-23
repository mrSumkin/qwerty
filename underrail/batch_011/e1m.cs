using System;
using System.Collections.Generic;

// Token: 0x02001132 RID: 4402
[euj]
public sealed class e1m
{
	// Token: 0x06005E35 RID: 24117 RVA: 0x0027ECE0 File Offset: 0x0027CEE0
	[ayh("ElectroshockAura_DamageTaken")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null && A_1 != null && A_1.Area != null && A_1.Zone != null && A_1.h.b != null)
		{
			cwt cwt;
			A_2.QuickGet("attackResult", out cwt);
			List<csk> list;
			A_2.QuickGet("damage", out list);
			cru cru;
			A_2.QuickGet("stats", out cru);
			if (cwt != null && cru != null && !cwt.w && cwt.z && cwt.i != null && cwt.i.d != Guid.Empty)
			{
				amc amc = aw1.a(cwt.i.d, A_1.Area);
				if (amc != null)
				{
					coh coh = A_1.h.b.aa().Gear.l().Item;
					if (coh != null)
					{
						if (coh.Battery == 0.0)
						{
							return;
						}
						coh.Battery = Math.Max(0.0, coh.Battery - cs4.f);
					}
					cwt a_ = d2t.a(A_1.h.b.aa(), amc.aa());
					dtb dtb = d2t.a(A_1.h.b, amc, a_);
					if (dtb != null)
					{
						A_1.Zone.ActionManager.g9(dtb, atp.a);
						dz6.a(dtb);
					}
				}
			}
		}
	}
}
