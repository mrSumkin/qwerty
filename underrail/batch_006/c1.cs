using System;

// Token: 0x020000AE RID: 174
[eiz("eaPCEA")]
[Serializable]
public class c1 : EventArgs
{
	// Token: 0x060003F4 RID: 1012 RVA: 0x000132D4 File Offset: 0x000114D4
	public object b()
	{
		return this.a;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x000132DC File Offset: 0x000114DC
	public object a()
	{
		return this.b;
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x000132E4 File Offset: 0x000114E4
	public c1(object A_0, object A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04000431 RID: 1073
	private object a;

	// Token: 0x04000432 RID: 1074
	private object b;
}
