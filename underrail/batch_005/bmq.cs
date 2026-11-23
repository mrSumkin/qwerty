using System;

// Token: 0x0200069E RID: 1694
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class bmq : Attribute
{
	// Token: 0x06002BF6 RID: 11254 RVA: 0x000FD1A8 File Offset: 0x000FB3A8
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x000FD1B0 File Offset: 0x000FB3B0
	public string d()
	{
		return this.b;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x000FD1B8 File Offset: 0x000FB3B8
	public string a()
	{
		return this.c;
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x000FD1C0 File Offset: 0x000FB3C0
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
	public bmq(string A_0, string A_1, string A_2, bool A_3 = false)
	{
		this.a = A_0;
		this.c = A_1;
		this.b = A_2;
		this.d = A_3;
	}

	// Token: 0x0400190D RID: 6413
	private string a;

	// Token: 0x0400190E RID: 6414
	private string b;

	// Token: 0x0400190F RID: 6415
	private string c;

	// Token: 0x04001910 RID: 6416
	private bool d;
}
