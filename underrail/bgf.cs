using System;

// Token: 0x02000708 RID: 1800
public sealed class bgf
{
	// Token: 0x06002EBB RID: 11963 RVA: 0x001087F4 File Offset: 0x001069F4
	public bgf(aw4 A_0, int A_1 = 0, int A_2 = 2147483647, string A_3 = null, Func<bool> A_4 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
	}

	// Token: 0x040019FA RID: 6650
	public aw4 a;

	// Token: 0x040019FB RID: 6651
	public int b;

	// Token: 0x040019FC RID: 6652
	public int c;

	// Token: 0x040019FD RID: 6653
	public string d;

	// Token: 0x040019FE RID: 6654
	public Func<bool> e;
}
