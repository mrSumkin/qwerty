using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020015F5 RID: 5621
[eiz("L75")]
[Serializable]
public sealed class c76 : a6k, ISerializable
{
	// Token: 0x06007BBE RID: 31678 RVA: 0x0033D85C File Offset: 0x0033BA5C
	private c76(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BBF RID: 31679 RVA: 0x0033D868 File Offset: 0x0033BA68
	public c76()
	{
	}

	// Token: 0x06007BC0 RID: 31680 RVA: 0x0033D874 File Offset: 0x0033BA74
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
		awq.a(qy, base.vg().q(), c5x, true, true);
		bfq bfq = new bfq();
		bfq.b("xpbl_TemporalSlow" + Guid.NewGuid().ToString());
		bfq.c("xpbl_TemporalSlow");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		c5x a_ = c5x;
		string a_2 = "Xpbl_TemporalSlow";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		float? a_6 = dz6.b();
		a7j item = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
		qy.ad().Add(item);
		if (c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			etm a_7 = new etm(new ap9(c5x.h.b.aa()), "эффекту времени или замедления");
			bey.a(a_7, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			anw item2 = new anw(a_7);
			b8p item3 = new b8p(c5x, new ba0());
			qy.ad().Add(item2);
			qy.ad().Add(item3);
		}
		else
		{
			qy.ad().Add(new amd(c5x.h.b, new els[]
			{
				new bzq(c4n.a(base.vg().e()) * d0u.b, c4n.d(base.vg().e()), c4n.c(base.vg().e()), c4n.b(base.vg().e()))
			}));
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
