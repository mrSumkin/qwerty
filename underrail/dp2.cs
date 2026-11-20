using System;

// Token: 0x02000699 RID: 1689
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class dp2 : Attribute
{
	// Token: 0x06002BE9 RID: 11241 RVA: 0x000FD0F8 File Offset: 0x000FB2F8
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002BEA RID: 11242 RVA: 0x000FD100 File Offset: 0x000FB300
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x000FD108 File Offset: 0x000FB308
	public dp2(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04001901 RID: 6401
	private string a;

	// Token: 0x04001902 RID: 6402
	private string b;
}
