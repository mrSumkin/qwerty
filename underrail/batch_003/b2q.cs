using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F3F RID: 3903
[e79("Xpbl_Le_TakeProfessorBackAndAbandonJet")]
public sealed class b2q : dgy
{
	// Token: 0x06004F14 RID: 20244 RVA: 0x00239EB8 File Offset: 0x002380B8
	public b2q()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b2q.a a = new b2q.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				bool flag = a.a.Area != null;
				a.b = (new ar7(aju.a, new Guid("744531ad-c1af-4a62-af65-4f26ed53f207"), new Guid("2fdce21d-73ff-484e-9929-1d9d686aeef3"), bl1.a).ao() as c5x);
				if (flag)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
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
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_d5", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
					});
					base.a(new btm[]
					{
						new ace(new an9())
						{
							InitiatorRef = new ar7(aju.a, new Guid("9b12167a-09d6-488c-a45d-c0c968225b7c"), new Guid("61fa2bf3-e47b-4008-bbeb-75f2c57a143d"), bl1.a)
						}
					});
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_d6", "player_oldTent"), false, new bool?(false), 0, null, false, false, false)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.a(false);
					array2[num2] = c8s;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					if (a.b != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F40 RID: 3904
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F16 RID: 20246 RVA: 0x0023A120 File Offset: 0x00238320
		internal bool b(e6d A_0)
		{
			this.b = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), this.a.Area).ao() as c5x);
			return true;
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x0023A150 File Offset: 0x00238350
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(this.a.qe(), new Guid("744531ad-c1af-4a62-af65-4f26ed53f207"), new Guid("2fdce21d-73ff-484e-9929-1d9d686aeef3"), bl1.a).ao() as c5x;
			if (c5x != null)
			{
				c5x.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			}
			return true;
		}

		// Token: 0x0400206F RID: 8303
		public c5x a;

		// Token: 0x04002070 RID: 8304
		public c5x b;
	}
}
