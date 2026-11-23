using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000DAF RID: 3503
[e79("Dc_DespawnFaceless")]
public sealed class eov : dgy
{
	// Token: 0x06004B92 RID: 19346 RVA: 0x0020BA24 File Offset: 0x00209C24
	public eov()
	{
		eov.a a = new eov.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000DB0 RID: 3504
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B94 RID: 19348 RVA: 0x0020BB8C File Offset: 0x00209D8C
		internal bool a(e6d A_0)
		{
			this.a.aqu().a(new bw0("dc-de3", new cqe(), 1));
			this.a.aqu().a(new bw0("dc-tchb", new cqe(), 1));
			new cqe().av(this.b.Zone, this.a.aqu());
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.b.Area.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.ch)
				{
					c5x.w();
					c5x.an();
				}
			}
			return true;
		}

		// Token: 0x04001E64 RID: 7780
		public cnk a;

		// Token: 0x04001E65 RID: 7781
		public c5x b;
	}
}
