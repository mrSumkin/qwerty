using System;
using TimelapseVertigo.Rules;

// Token: 0x02000CCA RID: 3274
[e79("Xpbl_Ww_PretRat_PraetoriansLeave")]
public sealed class ccf : dgy
{
	// Token: 0x06004994 RID: 18836 RVA: 0x001EAE24 File Offset: 0x001E9024
	public ccf()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				a5 a = new a5();
				a.a(new ar7(new Guid("03b08acb-007c-4646-a5ee-fde0403d015f"), c5x.Area));
				a.c(false);
				array2[num2] = a;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				a5 a2 = new a5();
				a2.a(new ar7(new Guid("23190f7d-fa68-438a-83cf-7375db156b8b"), c5x.Area));
				a2.c(false);
				array3[num3] = a2;
				base.a(array3);
				if (serviceOrThrow.aqu().ae() == GameDifficulty.Hard || serviceOrThrow.aqu().ae() == GameDifficulty.Dominating)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(new Guid("97eb9bd0-c7d4-4485-8f02-c8f7f0a9c3aa"), c5x.Area));
					a3.c(false);
					array4[num4] = a3;
					base.a(array4);
				}
				btm[] array5 = new btm[1];
				int num5 = 0;
				a5 a4 = new a5();
				a4.a(new ar7(new Guid("1368f4c4-e3a1-454c-91a0-9f1e6e11b732"), c5x.Area));
				a4.c(false);
				array5[num5] = a4;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				a5 a5 = new a5();
				a5.a(new ar7(new Guid("4ec19fe8-e951-4bfb-99fa-23f83ddb0310"), c5x.Area));
				a5.c(false);
				array6[num6] = a5;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array7[num7] = c8s;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
