using System;

// Token: 0x02001DFA RID: 7674
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class d29 : Attribute
{
	// Token: 0x0600A9E4 RID: 43492 RVA: 0x003F2B20 File Offset: 0x003F0D20
	public string b()
	{
		return this.a;
	}

	// Token: 0x0600A9E5 RID: 43493 RVA: 0x003F2B28 File Offset: 0x003F0D28
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600A9E6 RID: 43494 RVA: 0x003F2B30 File Offset: 0x003F0D30
	public d29(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04003FA4 RID: 16292
	private string a;

	// Token: 0x04003FA5 RID: 16293
	private string b;
}
