using System;
using System.IO;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000E19 RID: 3609
[e79("Tch_DrinkingWithGeorgis")]
public sealed class c41 : dgy
{
	// Token: 0x06004C75 RID: 19573 RVA: 0x00216700 File Offset: 0x00214900
	public c41()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c41.a a = new c41.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c41.b b = new c41.b();
				b.e = a;
				b.a = b.e.a.Area;
				if (b.a != null)
				{
					b.d = (new ar7(new Guid("622d21d7-292e-4492-9a5e-d98182a53ef6"), b.e.a.Area).ao() as c5x);
					b.b = new EntityAspectReference<cnb, bim>(b.a, new Guid("b8577de9-3a4b-4c21-b9b4-53af581f692f")).ao();
					b.c = new EntityAspectReference<cnb, bim>(b.a, new Guid("1250882c-9940-4206-b29d-eee92d0755c9")).ao();
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
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_tch_georgis_gotWasted", new bool?(false)).Value)
					{
						if (b.b != null && b.b.q())
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.d), null, null, null)
							});
						}
						if (b.c != null && b.c.q())
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.c), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.b), null, null, null)
						});
					}
					else
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.e.a), null, null, null)
						});
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array2[num2] = c8s;
					base.a(array2);
					if (b.d != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
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

	// Token: 0x02000E1A RID: 3610
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C77 RID: 19575 RVA: 0x002169C0 File Offset: 0x00214BC0
		internal bool a(e6d A_0)
		{
			new eb7(new Guid?(new Guid("df873276-a3e8-4668-bd62-8c1f8434b001")), false).ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001EF3 RID: 7923
		public c5x a;
	}

	// Token: 0x02000E1B RID: 3611
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C79 RID: 19577 RVA: 0x002169F0 File Offset: 0x00214BF0
		internal bool d(e6d A_0)
		{
			this.b.d(false);
			return true;
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00216A00 File Offset: 0x00214C00
		internal bool c(e6d A_0)
		{
			this.c.d(false);
			return true;
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00216A10 File Offset: 0x00214C10
		internal bool b(e6d A_0)
		{
			a0l.a(this.e.a, "player_drink", true);
			a0l.a(this.d, "georgis_drink", true);
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-labche_l" + 2.ToString()) + ".uzl");
			this.a.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00216A88 File Offset: 0x00214C88
		internal bool a(e6d A_0)
		{
			this.e.a.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EF4 RID: 7924
		public aud a;

		// Token: 0x04001EF5 RID: 7925
		public cnb b;

		// Token: 0x04001EF6 RID: 7926
		public cnb c;

		// Token: 0x04001EF7 RID: 7927
		public c5x d;

		// Token: 0x04001EF8 RID: 7928
		public c41.a e;
	}
}
