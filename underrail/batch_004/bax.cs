using System;

// Token: 0x0200120F RID: 4623
public sealed class bax
{
	// Token: 0x06006351 RID: 25425 RVA: 0x002ADE04 File Offset: 0x002AC004
	public static bax a()
	{
		return bax.a;
	}

	// Token: 0x06006352 RID: 25426 RVA: 0x002ADE0C File Offset: 0x002AC00C
	public static void a(bax A_0)
	{
		bax.a = A_0;
	}

	// Token: 0x040029D6 RID: 10710
	[ThreadStatic]
	private static bax a;
}
