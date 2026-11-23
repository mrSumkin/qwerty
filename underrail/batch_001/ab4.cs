using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000BC2 RID: 3010
[euj]
public sealed class ab4
{
	// Token: 0x060044E0 RID: 17632 RVA: 0x001BD8DC File Offset: 0x001BBADC
	[ayh("LIJDLP")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		a64 a = new a64(new fv(ez2.CreateDefinitonProvider<a1k>("components\\armors\\supersteelFiber")), false, false);
		a.na(20);
		a.nc(24);
		a.a(true);
		coh coh = Enumerable.FirstOrDefault<coh>(a.np());
		if (coh != null)
		{
			mk mk = new mk();
			mk.StaticItems.z3(coh, true);
			mk.GiveTo = bvl.d;
			mk.PublishEventsForPlayer = true;
			mk.ym(A_0, A_1, null);
		}
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x001BD950 File Offset: 0x001BBB50
	[ayh("LIJUMW")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		mk mk = new mk();
		mk.StaticItems.z3(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\spiritMushroom"))
		{
			Stacks = 4
		}, true);
		mk.StaticItems.z3(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\redDreamMushroom"))
		{
			Stacks = 5
		}, true);
		mk.StaticItems.z3(new fv(ez2.CreateDefinitonProvider<a1k>("components\\plants\\Mindshroom"))
		{
			Stacks = 5
		}, true);
		mk.GiveTo = bvl.d;
		mk.PublishEventsForPlayer = true;
		mk.ym(A_0, A_1, null);
	}
}
