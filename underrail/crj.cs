using System;

// Token: 0x02001F4D RID: 8013
[ayj("PlaceHeartbreakPoisonBearTrap")]
public sealed class crj : blb
{
	// Token: 0x0600BB1D RID: 47901 RVA: 0x00414244 File Offset: 0x00412444
	public override string y8()
	{
		return "Place Heartbreak Poison Bear Trap";
	}

	// Token: 0x0600BB1E RID: 47902 RVA: 0x0041424C File Offset: 0x0041244C
	public override string os()
	{
		return "PlaceHeartbreakPoisonBearTrap";
	}

	// Token: 0x0600BB1F RID: 47903 RVA: 0x00414258 File Offset: 0x00412458
	public override string bp(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		int num = ezx.v;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<dt>())
		{
			num = (int)((double)num * (1.0 + dt.a(A_0)));
		}
		return qv.a("Traps/HeartbreakPoisonBearTrap", new object[]
		{
			blb.a().a(true),
			(int)(blb.c * 100.0),
			l4.a(blb.d, false),
			l4.a(blb.e, false),
			ezx.z,
			num,
			l4.a(ezx.y, false),
			ezx.x
		});
	}
}
