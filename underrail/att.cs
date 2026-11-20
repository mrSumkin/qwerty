using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001828 RID: 6184
[eiz("HTRAA")]
[Serializable]
public sealed class att : a6k, ISerializable, enp
{
	// Token: 0x060083B8 RID: 33720 RVA: 0x0036F1F0 File Offset: 0x0036D3F0
	private att(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060083B9 RID: 33721 RVA: 0x0036F1FC File Offset: 0x0036D3FC
	public att()
	{
	}

	// Token: 0x060083BA RID: 33722 RVA: 0x0036F208 File Offset: 0x0036D408
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
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.a = c3u.a;
		cd1 cd = ath.a();
		efk a_ = base.vg().e().b8();
		efk a_2 = c5x.h.b.aa();
		cmn a_3 = cmn;
		double a_4 = 0.0;
		cd1 a_5 = cd;
		cwt cwt = euf.a(a_, a_2, a_3, a_4, null, 1.0, a_5, true);
		cwt.f.Clear();
		cwt.k = "Ошейник страданий";
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, cd, this);
		return dc4.c;
	}

	// Token: 0x060083BB RID: 33723 RVA: 0x0036F348 File Offset: 0x0036D548
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_0 != null && !A_1.aa().Dead && A_2.b)
		{
			if (A_1.aa().b(d8o.b | d8o.c))
			{
				boj.a(A_1.a8(), "BloodImpact", 1, double.MaxValue, true, true, null, null, null, null, false);
				A_1.a8().c().a(Guid.NewGuid().ToString(), "BearTrapActivate", 1f, c9z.a, false, false);
				coh coh = base.vg().e().b9() as coh;
				if (coh != null)
				{
					coh coh2 = coh.fy();
					coh2.Stealable = false;
					coh2.Lootable = true;
					A_1.aa().Bag.z3(coh2, true);
					base.vg().e().a(true);
				}
				int num;
				if (A_1.aa().Defense.af()[DamageType.Mechanical].c() >= 1.0)
				{
					num = 0;
				}
				else
				{
					num = euf.a(ath.c, 1.0).Amount;
				}
				int a_ = Convert.ToInt32(Math.Ceiling((double)num / (double)ath.d));
				c97 a_2 = new c97(A_0.aa().FactionId, ath.d * d0u.b, a_);
				A_1.aa().StatusEffects.a(a_2, false, false, false);
				awq.a(A_0, A_1, ath.e);
				return;
			}
			etm a_3 = new etm(new ap9(A_1.aa()), "ошейник страданий");
			bey.a(a_3, base.vg().e().b8(), A_1.aa(), A_1);
			a7v.a(a_3);
			bmj.a(A_1.a8(), new ba0());
		}
	}
}
