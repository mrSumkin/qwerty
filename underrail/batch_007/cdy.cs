using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015F6 RID: 5622
[eiz("L74")]
[Serializable]
public sealed class cdy : a6k, ISerializable
{
	// Token: 0x06007BC1 RID: 31681 RVA: 0x0033DAE0 File Offset: 0x0033BCE0
	private cdy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BC2 RID: 31682 RVA: 0x0033DAEC File Offset: 0x0033BCEC
	public cdy()
	{
	}

	// Token: 0x06007BC3 RID: 31683 RVA: 0x0033DAF4 File Offset: 0x0033BCF4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		bfq bfq = new bfq();
		bfq.b("xpbl_TemporalHaste" + Guid.NewGuid().ToString());
		bfq.c("xpbl_TemporalHaste");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		List<auv> list = qy.ad();
		c5x a_ = c5x;
		string a_2 = "Xpbl_TemporalHasteBack";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		List<auv> list2 = qy.ad();
		c5x a_7 = c5x;
		string a_8 = "Xpbl_TemporalHasteFront";
		int a_9 = 1;
		double maxValue2 = double.MaxValue;
		bool a_10 = false;
		bool a_11 = true;
		a_6 = dz6.b();
		list2.Add(new a7j(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false, null));
		if (c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			etm a_12 = new etm(new ap9(c5x.h.b.aa()), "временному эффекту");
			bey.a(a_12, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			anw item = new anw(a_12);
			b8p item2 = new b8p(c5x, new ba0());
			qy.ad().Add(item);
			qy.ad().Add(item2);
		}
		else
		{
			qy.ad().Add(new amd(c5x.h.b, new els[]
			{
				new c3k(c0o.b(base.vg().e()) * d0u.b, c0o.c(base.vg().e()), base.vg().e().b8().Offense.ag()[PsiSchool.TemporalManipulation].b())
			}));
			if (!c5x.h.b.aa().StatusEffects.a(c3k.a))
			{
				List<auv> list3 = qy.ad();
				b00 b = new b00();
				b.a(c0o.c(base.vg().e()));
				b.b(c0o.e);
				list3.Add(new a4s(b, null, new ar7(c5x), null));
			}
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
