using System;
using System.Runtime.Serialization;

// Token: 0x02001535 RID: 5429
[eiz("DSA")]
[Serializable]
public sealed class b6g : d64, ISerializable
{
	// Token: 0x06007943 RID: 31043 RVA: 0x0032C544 File Offset: 0x0032A744
	private b6g(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007944 RID: 31044 RVA: 0x0032C550 File Offset: 0x0032A750
	public b6g()
	{
	}

	// Token: 0x06007945 RID: 31045 RVA: 0x0032C55C File Offset: 0x0032A75C
	protected override bool gq()
	{
		if (!base.gq())
		{
			return false;
		}
		cd1 cd = base.c().aa().Offense.u();
		if (cd.TypedDefinition != null && base.b().a8().j == cgy.b && base.b().a8().Area == base.c().a8().Area && cd.LoadedAmmo.Count == 2)
		{
			double a_ = aw1.b(base.c().a8(), base.b().a8());
			double a_2 = awq.a(base.vg().e(), base.b(), a_);
			cmn a_3 = awq.a(base.c(), base.b(), null, null);
			for (int i = 0; i < 2; i++)
			{
				cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, a_3, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
				cwt.k = "Двойной выстрел";
				new ec6().pe(base.c(), base.b(), cd, cwt, cd.LoadedAmmo[0], null, null);
				awq.a(base.c(), cd);
			}
			return true;
		}
		return false;
	}
}
