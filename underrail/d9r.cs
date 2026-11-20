using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015F7 RID: 5623
[eiz("S76")]
[Serializable]
public sealed class d9r : a6k, ISerializable
{
	// Token: 0x06007BC4 RID: 31684 RVA: 0x0033DE04 File Offset: 0x0033C004
	private d9r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BC5 RID: 31685 RVA: 0x0033DE10 File Offset: 0x0033C010
	public d9r()
	{
	}

	// Token: 0x06007BC6 RID: 31686 RVA: 0x0033DE1C File Offset: 0x0033C01C
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
		if (c5x != base.vg().q() && c5x.h.b.a(base.vg().q().h.b) < h.d)
		{
			awq.a(qy, base.vg().q(), c5x, true, true);
		}
		bfq bfq = new bfq();
		bfq.b("xpbl_TemporalStasis" + Guid.NewGuid().ToString());
		bfq.c("xpbl_TemporalStasis");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		List<auv> list = qy.ad();
		c5x a_ = c5x;
		string a_2 = "Xpbl_TemporalStasisBack";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		List<auv> list2 = qy.ad();
		c5x a_7 = c5x;
		string a_8 = "Xpbl_TemporalStasisMid";
		int a_9 = 1;
		double maxValue2 = double.MaxValue;
		bool a_10 = false;
		bool a_11 = true;
		a_6 = dz6.b();
		list2.Add(new a7j(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false, null));
		List<auv> list3 = qy.ad();
		c5x a_12 = c5x;
		string a_13 = "Xpbl_TemporalStasisFront";
		int a_14 = 1;
		double maxValue3 = double.MaxValue;
		bool a_15 = false;
		bool a_16 = true;
		a_6 = dz6.b();
		list3.Add(new a7j(a_12, a_13, a_14, maxValue3, a_15, a_16, null, null, null, a_6, false, null));
		if (c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			etm a_17 = new etm(new ap9(c5x.h.b.aa()), "временному эффекту");
			bey.a(a_17, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			anw item = new anw(a_17);
			b8p item2 = new b8p(c5x, new ba0());
			qy.ad().Add(item);
			qy.ad().Add(item2);
		}
		else
		{
			int a_18 = base.vg().e().b8().Offense.ag()[PsiSchool.TemporalManipulation].b() * dlj.f;
			qy.ad().Add(new amd(c5x.h.b, new els[]
			{
				new amy(dlj.e * d0u.b + 10, a_18)
			}));
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
