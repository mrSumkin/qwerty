using System;
using System.Runtime.CompilerServices;

// Token: 0x02000C9F RID: 3231
[e79("dun_up_it_bossFightStart")]
public sealed class btl : dgy
{
	// Token: 0x0600490F RID: 18703 RVA: 0x001DE068 File Offset: 0x001DC268
	public btl()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			btl.b b = new btl.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				btl.a a = new btl.a();
				a.c = b;
				a.c.a.i.b.a(true, false);
				a.b = (new ar7(new Guid("500aac65-7a35-43eb-bfa5-91c9e4a049b3"), a.c.a.Area).ao() as c5x);
				(new ar7(new Guid("e2bb878b-7d27-406c-a3fb-fbef4f1280e1"), a.c.a.Area).ao() as c5x).s.b.g(true);
				btl.a a2 = a;
				ad6 ad = new ad6(a.b);
				ad.b(0.45);
				ad.c(0.0);
				ad.a(0.0005);
				a2.a = ad;
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
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array[num] = dva;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("FromDomOutside"));
				kw.a(false);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.IsAsync = false;
				dva2.a(new Func<e6d, bool>(a.c.a));
				array3[num3] = dva2;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.5))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(btl.c.a.a));
				array4[num4] = dva3;
				base.a(array4);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.c.b));
				array5[num5] = dva4;
				base.a(array5);
			}
		}
	}

	// Token: 0x02000CA0 RID: 3232
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004912 RID: 18706 RVA: 0x001DE37C File Offset: 0x001DC57C
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001CDE RID: 7390
		public static readonly btl.c a = new btl.c();

		// Token: 0x04001CDF RID: 7391
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000CA1 RID: 3233
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004914 RID: 18708 RVA: 0x001DE3AC File Offset: 0x001DC5AC
		internal bool a(e6d A_0)
		{
			af7 af = ea5.b("DITJCDSE");
			if (af != null)
			{
				af(this.a, this.a, null);
			}
			return true;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x001DE3E0 File Offset: 0x001DC5E0
		internal bool b(e6d A_0)
		{
			new co1().ym(this.a, this.a, null);
			return true;
		}

		// Token: 0x04001CE0 RID: 7392
		public c5x a;
	}

	// Token: 0x02000CA2 RID: 3234
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004917 RID: 18711 RVA: 0x001DE404 File Offset: 0x001DC604
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			dtb dtb = new dtb();
			dtb.ad().Add(this.a);
			dtb.ad().Add(new c7(this.b, false, false, true, false));
			this.c.a.Zone.ActionManager.g9(dtb, atp.a);
			return true;
		}

		// Token: 0x04001CE1 RID: 7393
		public ad6 a;

		// Token: 0x04001CE2 RID: 7394
		public c5x b;

		// Token: 0x04001CE3 RID: 7395
		public btl.b c;
	}
}
