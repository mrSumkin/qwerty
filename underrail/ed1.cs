using System;
using System.IO;
using System.Runtime.CompilerServices;

// Token: 0x02000D94 RID: 3476
[e79("Xpbl_Md_PumpWaterOut")]
public sealed class ed1 : dgy
{
	// Token: 0x06004B5F RID: 19295 RVA: 0x00209124 File Offset: 0x00207324
	public ed1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ed1.a a = new ed1.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("652ec464-d797-4bec-992d-c7f6a9a539f1"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("4d4648b4-4e8f-451b-9087-6d6ecc0d5ddb"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("41540a99-1a95-4423-ad81-68e940ef298a"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new os(TimeSpan.FromSeconds(1.0))
				});
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
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D95 RID: 3477
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B61 RID: 19297 RVA: 0x002092E8 File Offset: 0x002074E8
		internal bool a(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_md_l" + 2.ToString()) + ".uzl");
			this.a.Zone.a(a_, 1, null);
			d60 d = this.a.Zone.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"removeWater"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null)
					{
						c5x.ae = new float?(0f);
					}
				}
			}
			if (this.b != null && this.b.s.b != null)
			{
				this.b.s.b.g(true);
			}
			if (this.c != null)
			{
				bb2 bb = this.c.GetAspect<bim>() as bb2;
				if (bb != null)
				{
					bb.a(true);
				}
			}
			if (this.d != null)
			{
				bb2 bb2 = this.d.GetAspect<bim>() as bb2;
				if (bb2 != null)
				{
					bb2.a(true);
				}
			}
			return true;
		}

		// Token: 0x04001E45 RID: 7749
		public c5x a;

		// Token: 0x04001E46 RID: 7750
		public c5x b;

		// Token: 0x04001E47 RID: 7751
		public c5x c;

		// Token: 0x04001E48 RID: 7752
		public c5x d;
	}
}
