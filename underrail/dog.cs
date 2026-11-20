using System;

// Token: 0x02001F54 RID: 8020
[ayj("PlaceSpiritPoisonBearTrap")]
public sealed class dog : blb
{
	// Token: 0x0600BB4A RID: 47946 RVA: 0x00414758 File Offset: 0x00412958
	public override string y8()
	{
		return "Place Poisoned Bear Trap";
	}

	// Token: 0x0600BB4B RID: 47947 RVA: 0x00414760 File Offset: 0x00412960
	public override string os()
	{
		return "PlaceSpiritPoisonBearTrap";
	}

	// Token: 0x0600BB4C RID: 47948 RVA: 0x0041476C File Offset: 0x0041296C
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.i;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Traps/SpiritPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			num,
			l4.a(ezx.h, false),
			(int)(ezx.j * 100.0)
		});
	}
}
