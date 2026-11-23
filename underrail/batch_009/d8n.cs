using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001478 RID: 5240
[eiz("HWV")]
[Serializable]
public sealed class d8n : a6k, ISerializable
{
	// Token: 0x06007644 RID: 30276 RVA: 0x0031FEB4 File Offset: 0x0031E0B4
	private d8n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007645 RID: 30277 RVA: 0x0031FEC0 File Offset: 0x0031E0C0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		wv wv = c5x.GetAspect<bim>() as wv;
		if (wv == null || wv.g() == null)
		{
			return dc4.e;
		}
		wv.a(base.vg().q().h.b);
		bool flag = (base.vg().q().g & e2b.d) > (e2b)0;
		cjq.a(base.vg().e().b9());
		if (wv.g().af())
		{
			if (flag)
			{
				a7v.a(new h0("Зажигание уже включено.", new Color?(adi.m)));
				bmj.a(c5x, new d53("Зажигание уже включено", adi.m, null, false));
			}
			d8n.a(c5x);
			return dc4.e;
		}
		if (wv.g().t() > base.vg().e().b8().Skills.Get<dca>().g())
		{
			if (flag)
			{
				a7v.a(new h0("Недостаточно навыка.", new Color?(adi.m)));
				bmj.a(c5x, new d53("Недостаточно навыка", adi.m, null, false));
			}
			d8n.a(c5x);
			return dc4.e;
		}
		wv.g().a(true);
		if (flag)
		{
			d8n.b(c5x);
			a7v.a(new h0("Зажигание.", new Color?(adi.h)));
			bmj.a(c5x, new d53("Зажигание", adi.h, null, false));
		}
		e3q e3q = base.vg().e().b8() as e3q;
		if (e3q != null && e3q.e() == ExperienceSystem.Classic)
		{
			int a_ = Convert.ToInt32(c2h.d(c2h.d(base.vg().q().h.b.aa()), wv.g().t()));
			base.vg().q().h.b.a(a_, null);
		}
		return dc4.c;
	}

	// Token: 0x06007646 RID: 30278 RVA: 0x0032010C File Offset: 0x0031E30C
	public d8n()
	{
	}

	// Token: 0x06007647 RID: 30279 RVA: 0x00320118 File Offset: 0x0031E318
	private static void b(c5x A_0)
	{
		aru b = A_0.v.b;
		if (b != null)
		{
			b.a("lockpick", "LockpickSuccess", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x06007648 RID: 30280 RVA: 0x00320150 File Offset: 0x0031E350
	private static void a(c5x A_0)
	{
		aru b = A_0.v.b;
		if (b != null)
		{
			b.a("lockpick", "LockpickFailure", 1f, c9z.a, false, false);
		}
	}
}
