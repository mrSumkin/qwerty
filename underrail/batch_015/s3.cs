using System;

// Token: 0x0200069D RID: 1693
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class s3 : Attribute
{
	// Token: 0x06002BF3 RID: 11251 RVA: 0x000FD180 File Offset: 0x000FB380
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000FD188 File Offset: 0x000FB388
	public string a()
	{
		return this.c;
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x000FD190 File Offset: 0x000FB390
	public s3(string A_0, string A_1)
	{
		this.a = A_0;
		this.c = A_1;
	}

	// Token: 0x0400190A RID: 6410
	private string a;

	// Token: 0x0400190B RID: 6411
	private string b;

	// Token: 0x0400190C RID: 6412
	private string c;
}
