using System;

// Token: 0x0200016B RID: 363
public sealed class cqg : exy
{
	// Token: 0x06000934 RID: 2356 RVA: 0x00026374 File Offset: 0x00024574
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x0002637C File Offset: 0x0002457C
	public override string y8()
	{
		return "OuroborosEvents";
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00026384 File Offset: 0x00024584
	public override void xd()
	{
		this.c = new dq1();
		bpo.RegisterService<eta>(this.c);
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0002639C File Offset: 0x0002459C
	public override void qg()
	{
		bpo.UnregisterService<eta>();
	}

	// Token: 0x040005E2 RID: 1506
	private const string a = "OuroborosEvents";

	// Token: 0x040005E3 RID: 1507
	private readonly Guid b = new Guid("{98265C2D-7176-4f19-B352-D458DCC00CB4}");

	// Token: 0x040005E4 RID: 1508
	private dq1 c;
}
