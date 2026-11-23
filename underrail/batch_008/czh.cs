using System;

// Token: 0x020000B0 RID: 176
public static class czh
{
	// Token: 0x060003FC RID: 1020 RVA: 0x00013384 File Offset: 0x00011584
	public static void a(object A_0, string A_1)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException(A_1);
		}
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00013394 File Offset: 0x00011594
	public static void a(string A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			throw new ArgumentException("String argument cannot be null or empty.", A_1);
		}
	}
}
