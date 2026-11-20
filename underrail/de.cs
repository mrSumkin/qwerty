using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200146E RID: 5230
[eiz("SCXA")]
[Serializable]
public sealed class de : a6k, ISerializable
{
	// Token: 0x0600761D RID: 30237 RVA: 0x0031E50C File Offset: 0x0031C70C
	private de(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600761E RID: 30238 RVA: 0x0031E518 File Offset: 0x0031C718
	public de()
	{
	}

	// Token: 0x0600761F RID: 30239 RVA: 0x0031E520 File Offset: 0x0031C720
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh == null && coh.Battery >= (double)e3e.f)
		{
			return dc4.e;
		}
		coh.Battery -= (double)e3e.f;
		if (c5x.h.b.aa().Passive || !c5x.h.b.aa().b(d8o.e) || c5x.h.b.aa().d(CharacterImmunities.AiScrambling))
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "скремблированию");
			bey.a(a_, base.vg().q().h.b.aa(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
		}
		else
		{
			awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
			c5x.c().a("ScrambleAi");
			boj.a(c5x, "AiScramble_Cast_Back", 1, double.MaxValue, false, true, null, null, null, null, false);
			boj.a(c5x, "AiScramble_Cast_Front", 1, double.MaxValue, false, true, null, null, null, null, false);
			double num = e3e.a(base.vg().e(), c5x.h.b.aa(), 1);
			if (cuo.a.NextDouble() < num)
			{
				int num2 = 1;
				for (int i = 2; i <= e3e.c; i++)
				{
					double num3 = e3e.a(base.vg().e(), c5x.h.b.aa(), i);
					if (cuo.a.NextDouble() < num3)
					{
						num2 = i;
					}
				}
				afx a_2 = new afx(num2 * d0u.b);
				c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
			}
			else
			{
				c6f a_3 = new c6f(new ap9(c5x.h.b.aa()), new ap9(base.vg().q().h.b.aa()), "скремблированию");
				bey.a(a_3, base.vg().q().h.b.aa(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_3);
				bmj.a(c5x, new dym());
			}
		}
		return dc4.c;
	}
}
