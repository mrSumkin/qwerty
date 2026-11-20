using System;

// Token: 0x020001C0 RID: 448
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class aut : Attribute
{
	// Token: 0x06000D52 RID: 3410 RVA: 0x00038CE0 File Offset: 0x00036EE0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00038CE8 File Offset: 0x00036EE8
	public aut(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040007E0 RID: 2016
	private string a;
}
