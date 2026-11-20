using System;

// Token: 0x02001E0E RID: 7694
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class a1 : Attribute
{
	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600AA5D RID: 43613 RVA: 0x003F3B68 File Offset: 0x003F1D68
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x0600AA5E RID: 43614 RVA: 0x003F3B70 File Offset: 0x003F1D70
	public a1(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x04003FBE RID: 16318
	private string a;
}
