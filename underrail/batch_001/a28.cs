using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D92 RID: 3474
[e79("Xpbl_Wumb_MoveCrate")]
public sealed class a28 : dgy
{
	// Token: 0x06004B5C RID: 19292 RVA: 0x00208F6C File Offset: 0x0020716C
	public a28()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				a28.a a = new a28.a();
				a.a = (new ar7(new Guid("ba3374e2-324e-4c4c-b677-ccf1199af54e"), c5x.Area).ao() as c5x);
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
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D93 RID: 3475
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B5E RID: 19294 RVA: 0x002090C0 File Offset: 0x002072C0
		internal bool a(e6d A_0)
		{
			this.a.Location = new Vector3(35f, 36f, 0f);
			this.a.ah();
			if (this.a.s.b != null)
			{
				this.a.s.b.g(false);
			}
			return true;
		}

		// Token: 0x04001E44 RID: 7748
		public c5x a;
	}
}
