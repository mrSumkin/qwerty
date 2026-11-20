using System;
using TimelapseVertigo.Common;

// Token: 0x02000486 RID: 1158
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class e79 : Attribute
{
	// Token: 0x06001DB7 RID: 7607 RVA: 0x000A4760 File Offset: 0x000A2960
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x000A4768 File Offset: 0x000A2968
	public e79(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x000A4778 File Offset: 0x000A2978
	public e79(TimelapseWorkflows A_0) : this(A_0.ToString())
	{
	}

	// Token: 0x040010C5 RID: 4293
	private string a;
}
