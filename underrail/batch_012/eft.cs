using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001757 RID: 5975
[eiz("UDCA")]
[Serializable]
public sealed class eft : a6k
{
	// Token: 0x060080A4 RID: 32932 RVA: 0x00365BA0 File Offset: 0x00363DA0
	private eft(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060080A5 RID: 32933 RVA: 0x00365BAC File Offset: 0x00363DAC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().c(d8o.f))
		{
			coh coh = null;
			if (c5x.h.b.aa().IsMobile && c5x.h.b.aa().IsInCombat)
			{
				bmj.a(base.vg().q(), new d53("Поймать не удалось!", adi.l, null, true));
				if (base.vg().q().h.b != null)
				{
					vr a_ = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().q().h.b.aa()), "{1} пытается поймать {0}, но терпит неудачу. Цель должна быть обездвижена или не в бою.", new Color?(adi.m), null);
					bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
					a7v.a(a_);
				}
				return dc4.e;
			}
			if (c5x.h.b.aa().FactionId == "lakeGame")
			{
				coh = new d48(ez2.CreateDefinitonProvider<ebz>("Plot\\capturedHopper"));
			}
			else if (c5x.h.b.aa().Name == "Бурильщик")
			{
				coh = new d48(ez2.CreateDefinitonProvider<ebz>("Plot\\capturedBorer"));
			}
			else if (c5x.h.b.aa().Name == "Пиявка")
			{
				coh = new d48(ez2.CreateDefinitonProvider<ebz>("Plot\\capturedLatcher"));
			}
			else if (c5x.h.b.aa().Name == "Кошка")
			{
				if (string.Equals(c5x.h.b.aa().Offense.u().Definition.az(), "Лазорц*", StringComparison.OrdinalIgnoreCase))
				{
					coh = new acz(ez2.CreateDefinitonProvider<cdk>("Plot\\capturedLaserCat"));
				}
				else
				{
					coh = new d48(ez2.CreateDefinitonProvider<ebz>("Plot\\capturedCat"));
				}
			}
			else if (c5x.h.b.am().StartsWith("xpbl_scrab", StringComparison.OrdinalIgnoreCase))
			{
				coh = new d48(ez2.CreateDefinitonProvider<ebz>("Plot\\xpbl\\capturedSmallCrab"));
			}
			if (coh != null)
			{
				c5x.an();
				mk mk = new mk();
				mk.StaticItems.z3(coh, true);
				mk.PublishEventsForPlayer = false;
				mk.ym(null, base.vg().q(), null);
				bmj.a(base.vg().q(), new d53(c5x.y8() + " - удалось поймать!", adi.r, null, true));
				base.vg().e().a(true);
				return dc4.c;
			}
		}
		bmj.a(base.vg().q(), new d53("Поймать не удалось!", adi.l, null, true));
		return dc4.e;
	}

	// Token: 0x060080A6 RID: 32934 RVA: 0x00365EEC File Offset: 0x003640EC
	public eft()
	{
	}
}
