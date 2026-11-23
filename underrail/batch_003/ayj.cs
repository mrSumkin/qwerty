using System;

// Token: 0x02001E5B RID: 7771
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class ayj : Attribute
{
	// Token: 0x0600AC3E RID: 44094 RVA: 0x003F934C File Offset: 0x003F754C
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600AC3F RID: 44095 RVA: 0x003F9354 File Offset: 0x003F7554
	public ayj(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400401D RID: 16413
	private string a;
}
