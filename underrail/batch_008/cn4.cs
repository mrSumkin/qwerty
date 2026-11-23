using System;

// Token: 0x02001F53 RID: 8019
[ayj("PlaceBlindingPoisonBearTrap")]
public sealed class cn4 : blb
{
	// Token: 0x0600BB46 RID: 47942 RVA: 0x0041464C File Offset: 0x0041284C
	public override string y8()
	{
		return "Place Blinding Poison Bear Trap";
	}

	// Token: 0x0600BB47 RID: 47943 RVA: 0x00414654 File Offset: 0x00412854
	public override string os()
	{
		return "PlaceBlindingPoisonBearTrap";
	}

	// Token: 0x0600BB48 RID: 47944 RVA: 0x00414660 File Offset: 0x00412860
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.l;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Traps/BlindingPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			ezx.p,
			num,
			l4.a(ezx.o, false),
			ezx.m,
			ezx.n
		});
	}
}
