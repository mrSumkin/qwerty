using System;

// Token: 0x02000186 RID: 390
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class dmo : Attribute
{
	// Token: 0x06000B8F RID: 2959 RVA: 0x0002FA8C File Offset: 0x0002DC8C
	public string a()
	{
		return this.c;
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x0002FA94 File Offset: 0x0002DC94
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
	public string c()
	{
		return this.d;
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
	public void b(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
	public int b()
	{
		return this.e;
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0002FABC File Offset: 0x0002DCBC
	public void b(int A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
	public int d()
	{
		return this.f;
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
	public void a(int A_0)
	{
		this.f = A_0;
	}

	// Token: 0x040006E0 RID: 1760
	public const int a = 80;

	// Token: 0x040006E1 RID: 1761
	public const int b = 40;

	// Token: 0x040006E2 RID: 1762
	private string c;

	// Token: 0x040006E3 RID: 1763
	private string d;

	// Token: 0x040006E4 RID: 1764
	private int e;

	// Token: 0x040006E5 RID: 1765
	private int f;
}
