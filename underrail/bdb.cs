using System;

// Token: 0x02000213 RID: 531
public sealed class bdb : exy
{
	// Token: 0x06000EE6 RID: 3814 RVA: 0x0003E6EC File Offset: 0x0003C8EC
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
	public override string y8()
	{
		return "OuroborosPathfinding";
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0003E6FC File Offset: 0x0003C8FC
	public override void xd()
	{
		this.c = new djf();
		bpo.RegisterService<wu>(this.c);
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0003E714 File Offset: 0x0003C914
	public override void qg()
	{
		bpo.UnregisterService<wu>();
	}

	// Token: 0x040008EB RID: 2283
	private const string a = "OuroborosPathfinding";

	// Token: 0x040008EC RID: 2284
	private readonly Guid b = new Guid("{778A5028-0A2D-4335-8B9E-577D1B305427}");

	// Token: 0x040008ED RID: 2285
	private djf c;
}
