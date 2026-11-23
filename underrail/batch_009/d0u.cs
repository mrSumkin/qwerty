using System;
using System.Collections.Generic;

// Token: 0x020018D4 RID: 6356
public static class d0u
{
	// Token: 0x060086CE RID: 34510 RVA: 0x0037D298 File Offset: 0x0037B498
	static d0u()
	{
		d0u.f[d98.a] = false;
		d0u.f[d98.b] = false;
		d0u.f[d98.c] = true;
		d0u.f[d98.d] = false;
		d0u.f[d98.e] = false;
		d0u.f[d98.f] = false;
		d0u.f[d98.g] = false;
	}

	// Token: 0x060086CF RID: 34511 RVA: 0x0037D33C File Offset: 0x0037B53C
	public static Dictionary<d98, int> a()
	{
		if (d0u.g == null)
		{
			d0u.g = new Dictionary<d98, int>();
			d0u.g[d98.a] = 15;
			d0u.g[d98.b] = 0;
			d0u.g[d98.c] = 25;
			d0u.g[d98.d] = 20;
			d0u.g[d98.f] = 40;
			d0u.g[d98.g] = 0;
		}
		d0u.g[d98.e] = euf.b().ZoneTransitionApCost;
		return d0u.g;
	}

	// Token: 0x040033FC RID: 13308
	public static readonly TimeSpan a = TimeSpan.FromSeconds(15.0);

	// Token: 0x040033FD RID: 13309
	public static readonly int b = 5000;

	// Token: 0x040033FE RID: 13310
	public static readonly float c = 0.08f;

	// Token: 0x040033FF RID: 13311
	internal static readonly int d = 50;

	// Token: 0x04003400 RID: 13312
	public static readonly int e = 10000;

	// Token: 0x04003401 RID: 13313
	public static readonly Dictionary<d98, bool> f = new Dictionary<d98, bool>();

	// Token: 0x04003402 RID: 13314
	public static Dictionary<d98, int> g;
}
