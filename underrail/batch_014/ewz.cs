using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F45 RID: 3909
[e79("Xpbl_Cc_RayShowsJets")]
public sealed class ewz : dgy
{
	// Token: 0x06004F27 RID: 20263 RVA: 0x0023B414 File Offset: 0x00239614
	public ewz()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ewz.a a = new ewz.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_cc_ray_leadToExpensiveJets", new bool?(false)).Value;
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("931fe8a1-ccf5-47c2-9164-3b8b2324237b"), a.a.Area).ao() as c5x);
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
					if (value)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
					}
					else
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
					}
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F46 RID: 3910
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F29 RID: 20265 RVA: 0x0023B5E4 File Offset: 0x002397E4
		internal bool c(e6d A_0)
		{
			a0l.a(this.a, "player_expensiveJets", true);
			a0l.a(this.b, "ray_expensiveJets", true);
			if (this.b.t.b != null)
			{
				this.b.t.b.y6()[ddq.ay] = new bt4("ray_expensiveJets");
			}
			return true;
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x0023B654 File Offset: 0x00239854
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_cheapJets", true);
			a0l.a(this.b, "ray_cheapJets", true);
			if (this.b.t.b != null)
			{
				this.b.t.b.y6()[ddq.ay] = new bt4("ray_cheapJets");
			}
			return true;
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x0023B6C4 File Offset: 0x002398C4
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400207B RID: 8315
		public c5x a;

		// Token: 0x0400207C RID: 8316
		public c5x b;
	}
}
