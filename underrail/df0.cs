using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F20 RID: 3872
[e79("Xpbl_Le_ProfessorRescuedFromJail")]
public sealed class df0 : dgy
{
	// Token: 0x06004EDB RID: 20187 RVA: 0x00236EA0 File Offset: 0x002350A0
	public df0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), c5x.Area).ao() as c5x;
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
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (c5x2 != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.a(new ar7(c5x2));
					a.c(true);
					array2[num2] = a;
					base.a(array2);
				}
				btm[] array3 = new btm[1];
				array3[0] = new dva(null, new Func<e6d, bool>(df0.a.a.a), null, null, null);
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_d6", "player_oldTent"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F21 RID: 3873
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004EDE RID: 20190 RVA: 0x00237070 File Offset: 0x00235270
		internal bool a(e6d A_0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
				{
					if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.f5)
					{
						d4n.b.a8().w();
						d4n.b.a8().an();
					}
				}
			}
			return true;
		}

		// Token: 0x0400204E RID: 8270
		public static readonly df0.a a = new df0.a();

		// Token: 0x0400204F RID: 8271
		public static Func<e6d, bool> b;
	}
}
