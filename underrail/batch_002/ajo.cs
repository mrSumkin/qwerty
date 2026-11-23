using System;

// Token: 0x0200047C RID: 1148
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class ajo : Attribute
{
	// Token: 0x06001D9B RID: 7579 RVA: 0x000A3DB0 File Offset: 0x000A1FB0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
	public ajo(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04001054 RID: 4180
	private string a;
}
