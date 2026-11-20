using System;

// Token: 0x02001F4F RID: 8015
[ayj("PlaceLeperPoisonBearTrap")]
public sealed class agi : blb
{
	// Token: 0x0600BB27 RID: 47911 RVA: 0x004143F0 File Offset: 0x004125F0
	public override string y8()
	{
		return "Place Leper Poison Bear Trap";
	}

	// Token: 0x0600BB28 RID: 47912 RVA: 0x004143F8 File Offset: 0x004125F8
	public override string os()
	{
		return "PlaceLeperPoisonBearTrap";
	}

	// Token: 0x0600BB29 RID: 47913 RVA: 0x00414400 File Offset: 0x00412600
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.q;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Traps/LeperPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			ezx.u,
			num,
			l4.a(ezx.t, false),
			(int)(ezx.r * 100.0),
			ezx.s
		});
	}
}
