using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EA0 RID: 3744
[e79("Jy_PlayerAndGarrenGoInside")]
public sealed class c57 : dgy
{
	// Token: 0x06004D8C RID: 19852 RVA: 0x0022564C File Offset: 0x0022384C
	public c57()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c57.a a = new c57.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("65ed9af1-1ce5-4707-96fb-2e5e3a4fc065"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					ar7 ar = new ar7(new Guid("bd061247-d71e-4295-8e82-e8942b101c91"), a.a.Area);
					if (ar.ao() != null)
					{
						d2b aspect = ar.ao().GetAspect<d2b>();
						if (aspect != null)
						{
							aspect.a(false, false);
						}
						ar.ao().RemoveAspect<c3g>();
					}
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
					bool flag = a.a.Zone.g("PlayerInside") != null;
					csd csd = a.a.Zone.g("GarrenInside");
					if (flag && csd != null)
					{
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "PlayerInside"
							})
							{
								InitiatorRef = new ar7(a.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "GarrenInside"
							})
							{
								InitiatorRef = new ar7(a.b)
							}
						});
						if (a.b.t.b != null)
						{
							a.b.t.b.y6()["GuardLoc"] = new bt4("GarrenInside");
						}
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
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000EA1 RID: 3745
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D8E RID: 19854 RVA: 0x002258F4 File Offset: 0x00223AF4
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001FB9 RID: 8121
		public c5x a;

		// Token: 0x04001FBA RID: 8122
		public c5x b;
	}
}
