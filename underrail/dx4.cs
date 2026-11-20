using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x02000225 RID: 549
public sealed class dx4 : exy
{
	// Token: 0x06000F43 RID: 3907 RVA: 0x00040014 File Offset: 0x0003E214
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0004001C File Offset: 0x0003E21C
	public override string y8()
	{
		return "OuroborosPlayfield";
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00040024 File Offset: 0x0003E224
	public override ReadOnlyCollection<z6> qi()
	{
		return new List<z6>
		{
			this.c
		}.AsReadOnly();
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x0004003C File Offset: 0x0003E23C
	public override void xd()
	{
		this.c = new c8();
		bpo.RegisterService<d6j>(this.c);
		bpo.RegisterService<bxz>(this.c);
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00040060 File Offset: 0x0003E260
	public override void qg()
	{
		if (this.c != null)
		{
			this.c.a();
			this.c = null;
		}
		bpo.UnregisterService<d6j>();
		bpo.UnregisterService<bxz>();
	}

	// Token: 0x0400091D RID: 2333
	private const string a = "OuroborosPlayfield";

	// Token: 0x0400091E RID: 2334
	private readonly Guid b = new Guid("{5879C84C-8365-4bf2-91D0-9D44DB693759}");

	// Token: 0x0400091F RID: 2335
	private c8 c;
}
