using System;

// Token: 0x02000D01 RID: 3329
[e79("Cc_TunnelerGangLeaves")]
public sealed class ehz : dgy
{
	// Token: 0x06004A01 RID: 18945 RVA: 0x001F1194 File Offset: 0x001EF394
	public ehz()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("f0871be6-7a0f-4a53-abac-50ae5e4e286b"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("06193007-ead5-4f7b-8570-6598ea6dc054"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("d00548f9-e6b9-4855-8ab6-5cedaaab7320"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("b913e769-b02c-4213-ab87-cfce856172cb"), c5x.Area).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("47a45ecd-e9fd-44c2-9eb3-7f407b158654"), c5x.Area).ao() as c5x;
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
				if (c5x3 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x3));
					a2.c(true);
					array3[num3] = a2;
					base.a(array3);
				}
				if (c5x4 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(c5x4));
					a3.c(true);
					array4[num4] = a3;
					base.a(array4);
				}
				if (c5x5 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a4 = new a5();
					a4.a(new ar7(c5x5));
					a4.c(true);
					array5[num5] = a4;
					base.a(array5);
				}
				if (c5x6 != null)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					a5 a5 = new a5();
					a5.a(new ar7(c5x6));
					a5.c(true);
					array6[num6] = a5;
					base.a(array6);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array7[num7] = c8s;
				base.a(array7);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
