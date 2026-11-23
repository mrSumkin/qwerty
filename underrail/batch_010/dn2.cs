using System;

// Token: 0x02001A39 RID: 6713
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
internal sealed class dn2 : Attribute
{
	// Token: 0x0600918D RID: 37261 RVA: 0x0039D2CC File Offset: 0x0039B4CC
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600918E RID: 37262 RVA: 0x0039D2D4 File Offset: 0x0039B4D4
	public dn2(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400382E RID: 14382
	private string a;
}
