using System;

// Token: 0x02000484 RID: 1156
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class apc : Attribute
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06001DAE RID: 7598 RVA: 0x000A46C8 File Offset: 0x000A28C8
	public string Name
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x000A46D0 File Offset: 0x000A28D0
	public apc(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040010C2 RID: 4290
	private string a;
}
