using System;
using System.Runtime.Serialization;

// Token: 0x0200155D RID: 5469
[eiz("YPS")]
[Serializable]
public sealed class eco : d64, ISerializable
{
	// Token: 0x060079D6 RID: 31190 RVA: 0x0032FCA4 File Offset: 0x0032DEA4
	private eco(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079D7 RID: 31191 RVA: 0x0032FCB0 File Offset: 0x0032DEB0
	public eco()
	{
	}

	// Token: 0x060079D8 RID: 31192 RVA: 0x0032FCBC File Offset: 0x0032DEBC
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
			cwt cwt = euf.a(base.c().aa(), base.b().aa(), a_, cmn, 0.0, base.b().a8().l(), base.c().aa().Darkvision, cd.CurrentBullet, awq.f(base.c()), a_2, false, null, null, true, null);
			cwt.k = "Выстрел навскидку";
			awq.a(base.c(), base.b(), cwt, cd, null, true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}
}
