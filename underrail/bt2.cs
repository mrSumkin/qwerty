using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020015F3 RID: 5619
[eiz("L76")]
[Serializable]
public sealed class bt2 : a6k, ISerializable
{
	// Token: 0x06007BB8 RID: 31672 RVA: 0x0033D43C File Offset: 0x0033B63C
	private bt2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BB9 RID: 31673 RVA: 0x0033D448 File Offset: 0x0033B648
	public bt2()
	{
	}

	// Token: 0x06007BBA RID: 31674 RVA: 0x0033D454 File Offset: 0x0033B654
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
		bfq.b("xpbl_EntropicRecurrence" + Guid.NewGuid().ToString());
		bfq.c("xpbl_EntropicRecurrence");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		List<auv> list = qy.ad();
		c5x a_ = c5x;
		string a_2 = "Xpbl_EntropRecApplyBack";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		List<auv> list2 = qy.ad();
		c5x a_7 = c5x;
		string a_8 = "Xpbl_EntropRecApplyMid";
		int a_9 = 1;
		double maxValue2 = double.MaxValue;
		bool a_10 = true;
		bool a_11 = true;
		a_6 = dz6.b();
		list2.Add(new a7j(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false, null));
		List<auv> list3 = qy.ad();
		c5x a_12 = c5x;
		string a_13 = "Xpbl_EntropRecApplyFront";
		int a_14 = 1;
		double maxValue3 = double.MaxValue;
		bool a_15 = true;
		bool a_16 = true;
		a_6 = dz6.b();
		list3.Add(new a7j(a_12, a_13, a_14, maxValue3, a_15, a_16, null, null, null, a_6, false, null));
		if (!c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			List<csk> list4 = c5x.h.b.aa().CustomProperties.GetClassPropertyValue<List<csk>>(ddm.g);
			if (list4 != null)
			{
				if (Enumerable.Sum<csk>(list4, new Func<csk, int>(bt2.a.a.a)) != 0)
				{
					list4 = euf.a(list4);
					double num = e6s.a(base.vg().e());
					List<csk> list5 = new List<csk>();
					foreach (csk csk in list4)
					{
						if (csk.Amount > 0)
						{
							list5.Add(new csk(csk.DamageType, (int)Math.Max(1.0, (double)csk.Amount * num / (double)e6s.l)));
						}
					}
					aj8 aj = new aj8(e6s.l * d0u.b, base.vg().e().b8(), list5);
					qy.ad().Add(new amd(c5x.h.b, new els[]
					{
						aj
					}));
					goto IL_3B0;
				}
			}
			return dc4.e;
		}
		etm a_17 = new etm(new ap9(c5x.h.b.aa()), "временному эффекту");
		bey.a(a_17, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
		anw item = new anw(a_17);
		b8p item2 = new b8p(c5x, new ba0());
		qy.ad().Add(item);
		qy.ad().Add(item2);
		IL_3B0:
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x020015F4 RID: 5620
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007BBD RID: 31677 RVA: 0x0033D850 File Offset: 0x0033BA50
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003130 RID: 12592
		public static readonly bt2.a a = new bt2.a();

		// Token: 0x04003131 RID: 12593
		public static Func<csk, int> b;
	}
}
