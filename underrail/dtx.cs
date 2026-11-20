using System;
using System.Collections.Generic;
using System.Linq;
using Ouroboros.Playfield.References;

// Token: 0x02001134 RID: 4404
[euj]
public sealed class dtx
{
	// Token: 0x06005E39 RID: 24121 RVA: 0x0027EF54 File Offset: 0x0027D154
	[ayh("PrecognitionTick")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.h.b.aa() != null && A_1.h.b.aa().Offense.aa().zo() < 1f && Enumerable.FirstOrDefault<doy>(A_1.h.b.aa().StatusEffects.Get<doy>()) != null)
		{
			bl6 bl = ecf.a(dgk.Get<a9y>(), new eru(new EntityAspectReference<amc, amc>(A_1.h.b)), null) as bl6;
			if (bl != null)
			{
				cp.a(bl, A_1, false);
			}
		}
	}

	// Token: 0x06005E3A RID: 24122 RVA: 0x0027F010 File Offset: 0x0027D210
	[ayh("GrantPsionicTransceiver_Tick")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null && A_1.t.b != null)
		{
			e12 e = null;
			object obj;
			if (A_2 != null && A_2.TryGetValue("DynamicEffect", out obj))
			{
				e = (obj as e12);
			}
			int num = (e != null) ? e.a() : 4;
			d02 service = bpo.GetService<d02>();
			int num2 = 0;
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && d4n.b.a8() != A_1 && !d4n.b.aa().Passive && d4n.b.aa().Feats.Contains<c3v>() && aw1.b(A_1, d4n.b.a8()) <= 15.0)
					{
						num2++;
					}
				}
			}
			if (num2 > 0)
			{
				ck3 ck = Enumerable.FirstOrDefault<ck3>(A_1.h.b.aa().StatusEffects.Get<ck3>());
				if (ck == null)
				{
					ck = new ck3();
					ck.Stacks = num2 * num;
					A_1.h.b.aa().StatusEffects.a(ck, false, false, false);
					return;
				}
				ck.Stacks = num2 * num;
				ck.ad();
			}
		}
	}

	// Token: 0x06005E3B RID: 24123 RVA: 0x0027F1BC File Offset: 0x0027D3BC
	[ayh("ExothermicAura_Heartbeat")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.h.b != null)
		{
			bzi bzi = Enumerable.FirstOrDefault<bzi>(A_1.h.b.aa().StatusEffects.Get<bzi>());
			ata ata = Enumerable.FirstOrDefault<ata>(A_1.h.b.aa().StatusEffects.Get<ata>());
			bbe bbe = Enumerable.FirstOrDefault<bbe>(A_1.h.b.aa().StatusEffects.Get<bbe>());
			if (bzi != null && !bzi.a)
			{
				A_1.h.b.aa().StatusEffects.d(bzi);
			}
			if (ata != null)
			{
				A_1.h.b.aa().StatusEffects.d(ata);
			}
			if (bbe != null)
			{
				A_1.h.b.aa().StatusEffects.d(bbe);
			}
		}
	}
}
