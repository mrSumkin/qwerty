using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016DF RID: 5855
[eiz("HB0")]
[Serializable]
public sealed class zg : a6k, ISerializable
{
	// Token: 0x06007F5D RID: 32605 RVA: 0x0035EF68 File Offset: 0x0035D168
	private zg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F5E RID: 32606 RVA: 0x0035EF74 File Offset: 0x0035D174
	public zg()
	{
	}

	// Token: 0x06007F5F RID: 32607 RVA: 0x0035EF80 File Offset: 0x0035D180
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		if (c5x.j == cgy.b && c5x.Area == base.vg().q().Area)
		{
			amc b = base.vg().q().h.b;
			amc b2 = c5x.h.b;
			if (b != null && b2 != null && !b2.aa().Dead)
			{
				cwt cwt = euf.a(b.aa(), b2.aa(), awq.b(b, b2, null), 0.0, null, 1.0, null, true);
				cwt cwt2 = new cwt();
				cwt2.x = AmmoType.Sledgehammer;
				cwt2.i = cwt.i;
				cwt2.e = cwt.e;
				cwt2.b = cwt.b;
				cwt2.h = ImpactSpeed.VeryLow;
				cwt2.z = true;
				cwt2.aa = cwt.aa;
				cwt2.j = cwt.j;
				cwt2.k = "Таран головой";
				cwt2.f.Add(euf.a(aso.c, (double)(cwt2.e ? 2 : 1)));
				zg.a a_ = new zg.a();
				awq.a(b, b2, cwt2, b.aa().Offense.u(), a_);
				return dc4.c;
			}
		}
		return dc4.e;
	}

	// Token: 0x020016E0 RID: 5856
	[eiz("HB0A")]
	[Serializable]
	private new sealed class a : enp, ISerializable
	{
		// Token: 0x06007F60 RID: 32608 RVA: 0x0035F134 File Offset: 0x0035D334
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x0035F13C File Offset: 0x0035D33C
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x0035F140 File Offset: 0x0035D340
		public a()
		{
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x0035F14C File Offset: 0x0035D34C
		public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
		{
			if (A_1 != null && A_1.a8() != null && A_2.b && A_3.a != null && !A_1.aa().c(d8o.e) && !A_1.aa().Passive)
			{
				if (A_1.aa().d(CharacterImmunities.Unbalancing))
				{
					etm a_ = new etm(new ap9(A_1.aa()), "неустойчивости");
					bey.a(a_, A_0.aa(), A_1.aa(), A_1);
					a7v.a(a_);
					bmj.a(A_1.a8(), new ba0());
					return;
				}
				elk a_2 = new elk(d0u.b * 2);
				A_1.aa().StatusEffects.a(a_2, false, false, false);
				if (cuo.a.NextDouble() < aso.d)
				{
					if (A_1.aa().a(CharacterImmunities.Stun))
					{
						etm a_3 = new etm(new ap9(A_1.aa()), "оглушению");
						bey.a(a_3, A_0.aa(), A_1.aa(), A_1);
						a7v.a(a_3);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					els a_4 = awq.a(A_1.aa(), d0u.b);
					A_1.aa().StatusEffects.a(a_4, false, false, false);
				}
			}
		}
	}
}
