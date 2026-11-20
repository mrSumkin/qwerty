using System;

// Token: 0x02000FFC RID: 4092
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class bs6 : Attribute
{
	// Token: 0x0600542C RID: 21548 RVA: 0x002541B4 File Offset: 0x002523B4
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600542D RID: 21549 RVA: 0x002541BC File Offset: 0x002523BC
	public bs6(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04002262 RID: 8802
	private string a;
}
