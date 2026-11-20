using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020015F8 RID: 5624
[eiz("TRA")]
[Serializable]
public sealed class df3 : a6k, ISerializable
{
	// Token: 0x06007BC7 RID: 31687 RVA: 0x0033E160 File Offset: 0x0033C360
	private df3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BC8 RID: 31688 RVA: 0x0033E16C File Offset: 0x0033C36C
	public df3()
	{
	}

	// Token: 0x06007BC9 RID: 31689 RVA: 0x0033E178 File Offset: 0x0033C378
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
		bfq.b("xpbl_TemporaryRewind" + Guid.NewGuid().ToString());
		bfq.c("xpbl_TemporaryRewind");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		c5x a_ = c5x;
		string a_2 = "Xpbl_TemporalRewind";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		a7j item = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
		qy.ad().Add(item);
		if (c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			etm a_7 = new etm(new ap9(c5x.h.b.aa()), "временному эффекту");
			bey.a(a_7, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			anw item2 = new anw(a_7);
			b8p item3 = new b8p(c5x, new ba0());
			qy.ad().Add(item2);
			qy.ad().Add(item3);
		}
		else
		{
			List<csk> classPropertyValue = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
			if (classPropertyValue != null)
			{
				int num = Math.Min(Enumerable.Sum<csk>(classPropertyValue, new Func<csk, int>(df3.a.a.a)), eqr.a(base.vg().e()));
				if (num == 0)
				{
					return dc4.e;
				}
				int num2 = Math.Min((int)(c5x.h.b.aa().Defense.q().zm() - c5x.h.b.aa().Defense.q().zo()), num);
				if (num2 == 0)
				{
					return dc4.e;
				}
				List<auv> list = qy.ad();
				d5u d5u = new d5u();
				d5u.a(num2);
				d5u.b(true);
				d5u.a(true);
				list.Add(new a4s(d5u, null, new ar7(c5x), null));
				qy.ad().Add(new a4s(new e13(), null, new ar7(c5x), null));
				qy.ad().Add(new amd(c5x.h.b, new els[]
				{
					new dk6(eqr.g * d0u.b, num2)
				}));
			}
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x020015F9 RID: 5625
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007BCC RID: 31692 RVA: 0x0033E4BC File Offset: 0x0033C6BC
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003132 RID: 12594
		public static readonly df3.a a = new df3.a();

		// Token: 0x04003133 RID: 12595
		public static Func<csk, int> b;
	}
}
