using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DF6 RID: 3574
[e79("Tch_StartTremorsWhenTalkingToEidein")]
public sealed class vz : dgy
{
	// Token: 0x06004C21 RID: 19489 RVA: 0x00212A1C File Offset: 0x00210C1C
	public vz()
	{
		vz.a a = new vz.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		a.a = bpo.GetService<ps>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && a.a != null)
		{
			a.b = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.b != null && a.b.Area != null)
			{
				vz.b b = new vz.b();
				b.b = a;
				b.a = (new ar7(new Guid("fa4af03c-26e5-4107-93ea-bb94815b0be0"), b.b.b.Area).ao() as c5x);
				if (b.a != null)
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
					egx egx = new egx();
					egx.a("Вы тоже это чувствуете?");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DF7 RID: 3575
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C23 RID: 19491 RVA: 0x00212C08 File Offset: 0x00210E08
		internal bool a(e6d A_0)
		{
			this.a.ane(2000, null, null, null, null, null);
			this.b.c().a("EarthquakeShort");
			return true;
		}

		// Token: 0x04001EC1 RID: 7873
		public ps a;

		// Token: 0x04001EC2 RID: 7874
		public c5x b;
	}

	// Token: 0x02000DF8 RID: 3576
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C25 RID: 19493 RVA: 0x00212C78 File Offset: 0x00210E78
		internal bool a(e6d A_0)
		{
			this.b.b.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001EC3 RID: 7875
		public c5x a;

		// Token: 0x04001EC4 RID: 7876
		public vz.a b;
	}
}
