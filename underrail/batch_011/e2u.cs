using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CA3 RID: 3235
[e79("Jye_TakeMauraToFarVent")]
public sealed class e2u : dgy
{
	// Token: 0x06004918 RID: 18712 RVA: 0x001DE474 File Offset: 0x001DC674
	public e2u()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			e2u.a a = new e2u.a();
			serviceOrThrow.aqu().r()["quest_jyrescueMission_mauraEscaped"] = true;
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				c5x c5x = new ar7(new Guid("3339102b-fbeb-48af-a6db-4679d9387877"), a.a.Area).ao() as c5x;
				a.b = (new ar7(new Guid("9f216624-4736-4c7e-b4bf-a1a227670dd5"), a.a.Area).ao() as c5x);
				if (c5x != null)
				{
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
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x));
					a2.c(true);
					array2[num2] = a2;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					bfq bfq = new bfq();
					bfq.c("VentilationShaftEnterExit");
					array3[num3] = new ace(bfq)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array4[num4] = c8s;
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000CA4 RID: 3236
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600491A RID: 18714 RVA: 0x001DE684 File Offset: 0x001DC884
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "playerAfterMaura", true);
			if (this.b != null)
			{
				cnb cnb = this.b.GetAspect<bim>() as cnb;
				if (cnb != null)
				{
					cnb.d(false);
				}
			}
			return true;
		}

		// Token: 0x04001CE4 RID: 7396
		public c5x a;

		// Token: 0x04001CE5 RID: 7397
		public c5x b;
	}
}
