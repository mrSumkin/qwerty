using System;

// Token: 0x020006C5 RID: 1733
public static class bmj
{
	// Token: 0x06002CC1 RID: 11457 RVA: 0x000FF698 File Offset: 0x000FD898
	public static void a(b0b A_0, c3r A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			bpo.GetServiceOrThrow<ps>().alf().aiz(A_0, A_1);
		}
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x000FF6B8 File Offset: 0x000FD8B8
	public static cmh b(b0b A_0)
	{
		if (A_0 != null)
		{
			return bpo.GetServiceOrThrow<ps>().alf().ai0(A_0);
		}
		return null;
	}

	// Token: 0x06002CC3 RID: 11459 RVA: 0x000FF6D4 File Offset: 0x000FD8D4
	public static void a(b0b A_0)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<ps>().alf().ai1(A_0);
		}
	}
}
