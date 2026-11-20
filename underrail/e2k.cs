using System;
using System.Runtime.Serialization;

// Token: 0x02001598 RID: 5528
[eiz("ASA")]
[Serializable]
public sealed class e2k : d64, ISerializable
{
	// Token: 0x06007AAF RID: 31407 RVA: 0x00335B04 File Offset: 0x00333D04
	private e2k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007AB0 RID: 31408 RVA: 0x00335B10 File Offset: 0x00333D10
	public e2k()
	{
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x00335B1C File Offset: 0x00333D1C
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn cmn = awq.a(base.c(), base.b(), null, null);
			cmn.b += base.c().aa().Offense.an();
			cmn.d += (double)base.c().aa().GetSpecializationValue<dzm>(true) * dzm.a;
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 1000.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			cwt.k = "Прицельный выстрел";
			awq.a(base.c(), base.b(), cwt, cd, null, null);
			if (base.vg().q().IsPlayer && !cwt.b)
			{
				cxc.a(eyy.b2);
			}
			return true;
		}
		return false;
	}
}
