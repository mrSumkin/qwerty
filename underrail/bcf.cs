using System;

// Token: 0x02001F5A RID: 8026
[ayj("PlaceCaveEarPoisonBearTrap")]
public sealed class bcf : blb
{
	// Token: 0x0600BB66 RID: 47974 RVA: 0x00414B44 File Offset: 0x00412D44
	public override string y8()
	{
		return "Place Poisoned Bear Trap";
	}

	// Token: 0x0600BB67 RID: 47975 RVA: 0x00414B4C File Offset: 0x00412D4C
	public override string os()
	{
		return "PlaceCaveEarPoisonBearTrap";
	}

	// Token: 0x0600BB68 RID: 47976 RVA: 0x00414B54 File Offset: 0x00412D54
	public override string bp(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("Traps/CaveEarPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(cl5.d(a_), false)
		});
	}
}
