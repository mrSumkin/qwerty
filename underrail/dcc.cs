using System;

// Token: 0x020000D0 RID: 208
[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public sealed class dcc : Attribute
{
	// Token: 0x06000490 RID: 1168 RVA: 0x00014904 File Offset: 0x00012B04
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0001490C File Offset: 0x00012B0C
	public dcc(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400044B RID: 1099
	private string a;
}
