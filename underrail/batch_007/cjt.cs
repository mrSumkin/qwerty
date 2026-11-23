using System;

// Token: 0x020000A6 RID: 166
public static class cjt
{
	// Token: 0x060003BE RID: 958 RVA: 0x00011E3C File Offset: 0x0001003C
	public static void a(object A_0, string A_1)
	{
		if (A_0 == null)
		{
			throw new InvalidOperationException(string.Format("Variable cannot be null at this time: '{0}'", A_1));
		}
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00011E58 File Offset: 0x00010058
	public static void a(string A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			throw new InvalidOperationException(string.Format("String variable cannot be null or empty at this time: '{0}'", A_1));
		}
	}
}
