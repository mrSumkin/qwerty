using System;

// Token: 0x020004C1 RID: 1217
[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
public sealed class cgf : Attribute
{
	// Token: 0x06001F17 RID: 7959 RVA: 0x000AC2B4 File Offset: 0x000AA4B4
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000AC2BC File Offset: 0x000AA4BC
	public cgf(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040013AE RID: 5038
	private string a;
}
