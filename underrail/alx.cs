using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x020001A4 RID: 420
public sealed class alx : exy
{
	// Token: 0x06000C1A RID: 3098 RVA: 0x0003078C File Offset: 0x0002E98C
	public override Guid qe()
	{
		return this.d;
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x00030794 File Offset: 0x0002E994
	public override string y8()
	{
		return this.e;
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x000307A0 File Offset: 0x0002E9A0
	public override void qf()
	{
		this.b = new j();
		bpo.RegisterService<chr>(this.b);
		this.c = new ajd();
		bpo.RegisterService<d9d>(this.c);
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		this.a = new bso(serviceOrThrow.lg(), this.b, this.c);
		bpo.RegisterService<bcm>(this.a);
		bpo.RegisterService<d1a>(this.a);
		this.f = new amo(this.a);
		this.g = new eux(this.a);
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00030834 File Offset: 0x0002EA34
	public override void qg()
	{
		bpo.UnregisterService<bcm>();
		bpo.UnregisterService<d1a>();
		bpo.UnregisterService<chr>();
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x00030848 File Offset: 0x0002EA48
	public override ReadOnlyCollection<ajx> qh()
	{
		return new List<ajx>
		{
			this.f
		}.AsReadOnly();
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x00030860 File Offset: 0x0002EA60
	public override ReadOnlyCollection<z6> qi()
	{
		return new List<z6>
		{
			this.g
		}.AsReadOnly();
	}

	// Token: 0x0400072D RID: 1837
	private bso a;

	// Token: 0x0400072E RID: 1838
	private j b;

	// Token: 0x0400072F RID: 1839
	private ajd c;

	// Token: 0x04000730 RID: 1840
	private readonly Guid d = new Guid("{3C8C734A-B1F6-42f8-A247-A3CB10661DB0}");

	// Token: 0x04000731 RID: 1841
	private string e = "OuroborosGUI";

	// Token: 0x04000732 RID: 1842
	private ajx f;

	// Token: 0x04000733 RID: 1843
	private z6 g;
}
