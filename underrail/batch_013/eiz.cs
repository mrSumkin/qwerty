using System;

// Token: 0x020000D1 RID: 209
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false, AllowMultiple = false)]
public sealed class eiz : Attribute
{
	// Token: 0x06000492 RID: 1170 RVA: 0x0001491C File Offset: 0x00012B1C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00014924 File Offset: 0x00012B24
	public eiz(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400044C RID: 1100
	private string a;
}
