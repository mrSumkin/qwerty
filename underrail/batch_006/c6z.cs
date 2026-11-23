using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x02000563 RID: 1379
public sealed class c6z : exy
{
	// Token: 0x060023C3 RID: 9155 RVA: 0x000C6230 File Offset: 0x000C4430
	public override Guid qe()
	{
		return this.b;
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x000C6238 File Offset: 0x000C4438
	public override string y8()
	{
		return "TimelapseVertigo";
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x000C6240 File Offset: 0x000C4440
	public override ReadOnlyCollection<z6> qi()
	{
		return new List<z6>
		{
			this.c,
			this.d
		}.AsReadOnly();
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000C6268 File Offset: 0x000C4468
	public override void xd()
	{
		this.c = new d6f();
		this.d = new bl1();
		this.e = new qg();
		bpo.RegisterService<cnk>(this.c);
		bpo.RegisterService<bu6>(this.c);
		bpo.RegisterService<hs>(this.c);
		bpo.RegisterService<eil>(this.c);
		bpo.RegisterService<abd>(this.c);
		bpo.RegisterService<ewf>(this.d);
		bpo.RegisterService<b4b>(this.d);
		bpo.RegisterService<b49>(this.d);
		bpo.RegisterService<li>(this.e);
		bpo.RegisterService<acj>(new d18());
		bpo.RegisterService<er9>(new d1j());
		bpo.RegisterService<apo>(new ejh());
		bpo.RegisterService<cc8>(this.f);
		ea5.c();
		pp.b = this.c;
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x000C6334 File Offset: 0x000C4534
	public override void qg()
	{
		this.d.g();
		bpo.UnregisterService<cnk>();
		bpo.UnregisterService<hs>();
		bpo.UnregisterService<bu6>();
		bpo.UnregisterService<eil>();
		bpo.UnregisterService<abd>();
		bpo.UnregisterService<ewf>();
		bpo.UnregisterService<b4b>();
		bpo.UnregisterService<b49>();
		bpo.UnregisterService<li>();
		bpo.UnregisterService<acj>();
		bpo.UnregisterService<er9>();
		bpo.UnregisterService<apo>();
		bpo.UnregisterService<cc8>();
		if (pp.b == this.c)
		{
			pp.b = null;
		}
	}

	// Token: 0x040014B8 RID: 5304
	private const string a = "TimelapseVertigo";

	// Token: 0x040014B9 RID: 5305
	private readonly Guid b = new Guid("{1D008AB6-98E9-4900-B216-C4722DABBDEE}");

	// Token: 0x040014BA RID: 5306
	private d6f c;

	// Token: 0x040014BB RID: 5307
	private bl1 d;

	// Token: 0x040014BC RID: 5308
	private qg e;

	// Token: 0x040014BD RID: 5309
	private eka f = new eka();
}
