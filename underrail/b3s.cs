using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E4B RID: 3659
[e79("Fo_DespawnCrowd")]
public sealed class b3s : dgy
{
	// Token: 0x06004CCE RID: 19662 RVA: 0x0021B488 File Offset: 0x00219688
	public b3s()
	{
		b3s.a a = new b3s.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			c5x c5x2 = new ar7(new Guid("5fbe9675-82e6-4945-b6a1-6f059f986f2a"), c5x.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("f523f820-d063-4f3b-9229-c64fb2b69f83"), c5x.Area).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("f9260bea-934e-49f0-b86b-7ee9a590ae94"), c5x.Area).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), c5x.Area).ao() as c5x;
			if (c5x != null)
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
				if (c5x2 != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a2 = new a5();
					a2.c(true);
					a2.a(new ar7(c5x2));
					array2[num2] = a2;
					base.a(array2);
				}
				if (c5x3 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a3 = new a5();
					a3.c(true);
					a3.a(new ar7(c5x3));
					array3[num3] = a3;
					base.a(array3);
				}
				if (c5x5 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a4 = new a5();
					a4.c(true);
					a4.a(new ar7(c5x5));
					array4[num4] = a4;
					base.a(array4);
				}
				if (c5x4 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a5 = new a5();
					a5.c(true);
					a5.a(new ar7(c5x4));
					array5[num5] = a5;
					base.a(array5);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array6[num6] = c8s;
				base.a(array6);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000E4C RID: 3660
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CD0 RID: 19664 RVA: 0x0021B718 File Offset: 0x00219918
		internal bool a(e6d A_0)
		{
			d60 addon = this.a.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"crowd"
				}))
				{
					b0b.w();
					b0b.an();
				}
			}
			return true;
		}

		// Token: 0x04001F39 RID: 7993
		public cnk a;
	}
}
