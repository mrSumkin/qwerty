using System;

// Token: 0x02000164 RID: 356
public sealed class b77 : exy
{
	// Token: 0x060008F4 RID: 2292 RVA: 0x00025548 File Offset: 0x00023748
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00025550 File Offset: 0x00023750
	public override string y8()
	{
		return "DialogModule";
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00025558 File Offset: 0x00023758
	public override void xd()
	{
		this.c = new bmz();
		bpo.RegisterService<eve>(this.c);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00025570 File Offset: 0x00023770
	public override void qg()
	{
		bpo.UnregisterService<eve>();
	}

	// Token: 0x040005CF RID: 1487
	private const string a = "DialogModule";

	// Token: 0x040005D0 RID: 1488
	private readonly Guid b = new Guid("{B3BFD384-4A55-4058-81AA-55C072C06ACE}");

	// Token: 0x040005D1 RID: 1489
	private bmz c;
}
