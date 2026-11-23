using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001491 RID: 5265
[eiz("HA")]
[Serializable]
public sealed class evc : a6k, ISerializable
{
	// Token: 0x060076A6 RID: 30374 RVA: 0x00323614 File Offset: 0x00321814
	private evc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060076A7 RID: 30375 RVA: 0x00323620 File Offset: 0x00321820
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		d2b aspect = c5x.GetAspect<d2b>();
		if (aspect == null)
		{
			return dc4.e;
		}
		bool flag = (base.vg().q().g & e2b.d) > (e2b)0;
		int a_ = azb.b(base.vg().e().b9());
		c9b c9b = aspect.a(base.vg().q().h.b, LockType.Electronic, a_);
		switch (c9b)
		{
		case c9b.a:
		{
			if (flag)
			{
				evc.b(c5x);
				a7v.a(new ai6());
				bmj.a(c5x, new d53("Замок открыт", adi.h, null, false));
			}
			e3q e3q = base.vg().e().b8() as e3q;
			if (e3q != null)
			{
				if (e3q.e() == ExperienceSystem.Classic)
				{
					int a_2 = Convert.ToInt32((double)c2h.d(c2h.d(base.vg().q().h.b.aa()), aspect.p()) * aspect.b());
					base.vg().q().h.b.a(a_2, null);
				}
				cxc.a(eyy.bm);
			}
			return dc4.c;
		}
		case c9b.b:
			if (flag)
			{
				evc.a(c5x);
				a7v.a(new bj6("Недостаточно навыка."));
				bmj.a(c5x, new d53("Недостаточно навыка", adi.m, null, false));
			}
			return dc4.e;
		case c9b.c:
			if (flag)
			{
				evc.a(c5x);
				a7v.a(new bj6("Этот замок нельзя вскрыть."));
				bmj.a(c5x, new d53("Невозможно", adi.m, null, false));
			}
			return dc4.e;
		case c9b.d:
			if (flag)
			{
				a7v.a(new bj6("Уже открыто."));
			}
			return dc4.e;
		case c9b.e:
			if (flag)
			{
				a7v.a(new bj6("Этот замок нельзя вскрыть таким образом, поскольку это не электронный замок."));
				bmj.a(c5x, new d53("Невозможно", adi.m, null, false));
			}
			return dc4.e;
		case c9b.f:
			break;
		case c9b.g:
			bmj.a(c5x, new d53("Нет питания", adi.l, null, true));
			return dc4.e;
		default:
			if (c9b == c9b.h)
			{
				return dc4.e;
			}
			break;
		}
		return dc4.e;
	}

	// Token: 0x060076A8 RID: 30376 RVA: 0x00323894 File Offset: 0x00321A94
	private static void b(c5x A_0)
	{
		aru b = A_0.v.b;
		if (b != null)
		{
			b.a("hack", "HackingSuccess", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x060076A9 RID: 30377 RVA: 0x003238CC File Offset: 0x00321ACC
	private static void a(c5x A_0)
	{
		aru b = A_0.v.b;
		if (b != null)
		{
			b.a("hack", "HackingFailure", 1f, c9z.a, false, false);
		}
	}

	// Token: 0x060076AA RID: 30378 RVA: 0x00323904 File Offset: 0x00321B04
	public evc()
	{
	}
}
