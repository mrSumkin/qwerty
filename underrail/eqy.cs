using System;
using Ouroboros.Playfield.References;

// Token: 0x02000EAC RID: 3756
[e79("Gms_GorskyLeaves")]
public sealed class eqy : dgy
{
	// Token: 0x06004D9B RID: 19867 RVA: 0x00226808 File Offset: 0x00224A08
	public eqy()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				EntityAspectReference<bim, bim> entityAspectReference = new EntityAspectReference<bim, bim>(c5x.Area, new Guid("c53c533c-2d83-41c8-9785-e4422f28f3b5"));
				if (entityAspectReference.ao() != null)
				{
					entityAspectReference.ao().g(true);
				}
				c5x c5x2 = new ar7(new Guid("aa359bf3-88d5-4feb-9d69-eba3e50925d8"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("4ac85867-ad45-4d94-8659-108e3b45649c"), c5x.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), c5x.Area).ao() as c5x;
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
				if (c5x2 != null)
				{
					btm[] array2 = new btm[1];
					int num2 = 0;
					a5 a = new a5();
					a.a(new ar7(c5x2));
					array2[num2] = a;
					base.a(array2);
				}
				if (c5x3 != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x3));
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
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array5[num5] = c8s;
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}
}
