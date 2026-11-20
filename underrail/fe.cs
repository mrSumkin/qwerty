using System;

// Token: 0x0200047B RID: 1147
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class fe : Attribute
{
	// Token: 0x06001D99 RID: 7577 RVA: 0x000A3D98 File Offset: 0x000A1F98
	public string a()
	{
		return this.a;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
	public fe(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04001053 RID: 4179
	private string a;
}
