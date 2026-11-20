using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CBA RID: 3258
[e79("Xpbl_KirillLab2_VitekGameEnding")]
public sealed class b68 : dgy
{
	// Token: 0x06004964 RID: 18788 RVA: 0x001E7178 File Offset: 0x001E5378
	public b68()
	{
		b68.a a = new b68.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array[num] = dva;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				bfq bfq = new bfq();
				bfq.c("CircuitBreakerSwitch");
				bfq.a(0.6f);
				array2[num2] = new ace(bfq)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				bfq bfq2 = new bfq();
				bfq2.c("CircuitBreakerSwitch");
				bfq2.a(0.7f);
				array3[num3] = new ace(bfq2)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				bfq bfq3 = new bfq();
				bfq3.c("CircuitBreakerSwitch");
				bfq3.a(0.8f);
				array4[num4] = new ace(bfq3)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				bfq bfq4 = new bfq();
				bfq4.c("CircuitBreakerSwitchPowerDown");
				bfq4.a(1f);
				bfq4.c(true);
				array5[num5] = new ace(bfq4)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				base.a(new btm[]
				{
					new ace(new dom())
				});
			}
		}
	}

	// Token: 0x02000CBB RID: 3259
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004966 RID: 18790 RVA: 0x001E74A0 File Offset: 0x001E56A0
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.c);
			}
			dvn dvn = new dvn();
			dvn.a(new float?(0f));
			dvn.b(this.a.aqw().y8());
			dvn.a("none");
			dvn.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x001E7504 File Offset: 0x001E5704
		internal bool d(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("2ab684c9-5956-4e06-9451-205f28507404"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				if (c5x.p.b != null)
				{
					c5x.p.b.a[1].c = null;
					c5x.p.b.a[1].d = new float?(0f);
					c5x.p.b.a[2].c = null;
					c5x.p.b.a[2].d = new float?(0.65f);
				}
				c5x.RemoveAspect<aru>();
			}
			c5x c5x2 = new ar7(new Guid("76ff1308-b5b9-4a49-a30f-6a2a5705cef3"), this.b.Area).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.RemoveAspect<aru>();
			}
			bzm bzm = new bzm();
			bzm.a(false);
			bzm.a("HallwayLight");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x001E7638 File Offset: 0x001E5838
		internal bool c(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("fbe24446-a859-4e73-8a42-42e7fdf47ad7"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("515760ce-a934-421c-9345-2009cfe98d1e"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.p.b != null)
			{
				c5x.p.b.a[1].d = new float?(0f);
			}
			if (c5x2 != null && c5x2.p.b != null)
			{
				c5x2.p.b.a[1].d = new float?(0f);
			}
			return true;
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x001E7708 File Offset: 0x001E5908
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("1204c001-a5fb-4571-8000-817fa322f71c"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("f4341467-ad15-4334-9505-83a4cc43abdc"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.p.b != null)
			{
				foreach (cd0 cd in c5x.p.b.a)
				{
					if (cd is etz)
					{
						cd.d = new float?(0f);
					}
				}
			}
			if (c5x2 != null && c5x2.p.b != null)
			{
				foreach (cd0 cd2 in c5x2.p.b.a)
				{
					if (cd2 is etz)
					{
						cd2.d = new float?(0f);
					}
				}
			}
			return true;
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x001E7860 File Offset: 0x001E5A60
		internal bool e(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), this.b.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d7374739-8043-4aa8-9bd3-96b5889c8e3c"), this.b.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("10d7775c-df3a-443f-bb2e-d6a3d3815252"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.ae = new float?(0f);
			}
			if (c5x3 != null)
			{
				c5x3.ae = new float?(0f);
			}
			if (c5x2 != null)
			{
				c5x2.ae = new float?(0f);
			}
			bzm bzm = new bzm();
			bzm.a(false);
			bzm.a("ViteksGlow");
			bzm.ym(this.b, null, null);
			return true;
		}

		// Token: 0x04001D09 RID: 7433
		public cnk a;

		// Token: 0x04001D0A RID: 7434
		public c5x b;
	}
}
