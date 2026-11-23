using System;
using System.Runtime.Serialization;

// Token: 0x0200183F RID: 6207
[eiz("QDAA")]
[Serializable]
public sealed class al2 : d64, ISerializable
{
	// Token: 0x06008467 RID: 33895 RVA: 0x00371D60 File Offset: 0x0036FF60
	private al2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008468 RID: 33896 RVA: 0x00371D6C File Offset: 0x0036FF6C
	public al2()
	{
	}

	// Token: 0x06008469 RID: 33897 RVA: 0x00371D78 File Offset: 0x0036FF78
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
			cwt.k = "Быстрый выхват";
			awq.a(base.c(), base.b(), cwt, cd, null, true, null, null, null, false, false, true, null, null);
			return true;
		}
		return false;
	}
}
