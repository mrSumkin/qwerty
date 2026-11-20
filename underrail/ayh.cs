using System;

// Token: 0x0200101C RID: 4124
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public sealed class ayh : Attribute
{
	// Token: 0x06005517 RID: 21783 RVA: 0x0025A4DC File Offset: 0x002586DC
	public ayh(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040022B3 RID: 8883
	public string a;
}
