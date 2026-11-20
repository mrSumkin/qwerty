using System;

// Token: 0x02001844 RID: 6212
public static class bey
{
	// Token: 0x0600846E RID: 33902 RVA: 0x00371F3C File Offset: 0x0037013C
	public static void a(eyx A_0, cwt A_1, amc A_2 = null)
	{
		if (A_1 != null)
		{
			bey.a(A_0, A_1.i, A_1.j, A_2);
		}
	}

	// Token: 0x0600846F RID: 33903 RVA: 0x00371F58 File Offset: 0x00370158
	public static void a(eyx A_0, efk A_1, efk A_2, amc A_3 = null)
	{
		bey.a(A_0, (A_1 != null) ? new ap9(A_1) : null, (A_2 != null) ? new ap9(A_2) : null, A_3);
	}

	// Token: 0x06008470 RID: 33904 RVA: 0x00371F88 File Offset: 0x00370188
	public static void a(eyx A_0, ap9 A_1, ap9 A_2, amc A_3 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if ((A_2 != null && A_2.b == serviceOrThrow.aqu().v().FactionId) || (A_1 != null && A_1.b == serviceOrThrow.aqu().v().FactionId))
		{
			A_0.j().a(true);
			return;
		}
		if (A_3 != null)
		{
			A_0.j().a().Add(new k1(A_3.a8()));
			A_0.j().a().Add(new cur(A_3));
		}
	}

	// Token: 0x06008471 RID: 33905 RVA: 0x0037202C File Offset: 0x0037022C
	public static void a(eyx A_0, efk A_1, amc A_2 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_1 != null && A_1.FactionId == serviceOrThrow.aqu().v().FactionId)
		{
			A_0.j().a(true);
			return;
		}
		if (A_2 != null)
		{
			A_0.j().a().Add(new k1(A_2.a8()));
			A_0.j().a().Add(new cur(A_2));
		}
	}
}
