using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000DD8 RID: 3544
[e79("Dc_LoraDiesBecauseOfYou")]
public sealed class aoy : dgy
{
	// Token: 0x06004BE6 RID: 19430 RVA: 0x0020FFA4 File Offset: 0x0020E1A4
	public aoy()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			aoy.a a = new aoy.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("2f9f2c8a-e9dd-4152-b6bb-53359aef4e3c"), a.a.Area).ao() as c5x);
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
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					d92 d = new d92();
					d.a("events\\dc_loraDies");
					d.a(new ar7(new Guid("10ac6de5-9c2c-46d3-92ea-8548e04aa31f"), a.a.Area));
					d.b(new ar7(a.a));
					array3[num3] = d;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DD9 RID: 3545
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BE8 RID: 19432 RVA: 0x00210174 File Offset: 0x0020E374
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_moveLora", true);
			this.b.an();
			this.b.w();
			doq a_ = doq.a(Path.Combine(d5x.q(), "dc-flo_l2") + ".uzl");
			this.a.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x04001E9E RID: 7838
		public c5x a;

		// Token: 0x04001E9F RID: 7839
		public c5x b;
	}
}
