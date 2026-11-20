using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001489 RID: 5257
[eiz("CV1")]
[Serializable]
public sealed class c7r : a6k, ISerializable
{
	// Token: 0x0600767F RID: 30335 RVA: 0x003222B8 File Offset: 0x003204B8
	private c7r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007680 RID: 30336 RVA: 0x003222C4 File Offset: 0x003204C4
	public c7r()
	{
	}

	// Token: 0x06007681 RID: 30337 RVA: 0x003222D0 File Offset: 0x003204D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		pa pa = c5x.GetAspect<bim>() as pa;
		if (pa == null)
		{
			return dc4.e;
		}
		bool flag = (base.vg().q().g & e2b.d) > (e2b)0;
		c9b c9b = pa.c(base.vg().q().h.b, base.vg().e().b9() as coh);
		if (c9b == c9b.a)
		{
			if (flag)
			{
				a7v.a(new h0("Вы закрываете вентиляционную решётку.", null));
				bmj.a(c5x, new d53("Вентиляционная решётка закрыта", adi.h, null, false));
			}
			c7r.b(c5x);
			return dc4.c;
		}
		if (c9b == c9b.b)
		{
			if (flag)
			{
				a7v.a(new h0("Недостаточно навыка.", new Color?(adi.m)));
				bmj.a(c5x, new d53("Недостаточно навыка", adi.m, null, false));
			}
			c7r.a(c5x);
			return dc4.e;
		}
		if (c9b != c9b.f)
		{
			return dc4.e;
		}
		if (flag)
		{
			a7v.a(new h0("Вентиляционная решётка была слишком повреждена при открывании.", new Color?(adi.m)));
			bmj.a(c5x, new d53("Невозможно", adi.m, null, false));
		}
		return dc4.e;
	}

	// Token: 0x06007682 RID: 30338 RVA: 0x00322460 File Offset: 0x00320660
	private static void b(c5x A_0)
	{
		A_0.c().a("open-close", "VentilationShaftClose", 1f, c9z.a, false, false);
	}

	// Token: 0x06007683 RID: 30339 RVA: 0x00322480 File Offset: 0x00320680
	private static void a(c5x A_0)
	{
	}
}
