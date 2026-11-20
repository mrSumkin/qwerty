using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000E77 RID: 3703
[e79("Rkl_EdgarAndHuntersLeave")]
public sealed class ey1 : dgy
{
	// Token: 0x06004D2E RID: 19758 RVA: 0x00220170 File Offset: 0x0021E370
	public ey1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				aud aud = c5x.Area;
				if (aud != null)
				{
					ey1.a a = new ey1.a();
					a.a = new EntityAspectReference<cnb, bim>(aud, new Guid("ca1d944e-3bb1-4ce3-8dad-59ebcff78131")).ao();
					a.b = new EntityAspectReference<cnb, bim>(aud, new Guid("054110c0-7d2c-4669-82a8-0dd99cdc7b95")).ao();
					c5x a_ = new ar7(new Guid("df4662a5-4c33-4820-9752-6a6de23792a4"), c5x.Area).ao() as c5x;
					c5x a_2 = new ar7(new Guid("3b4d720f-fc94-4e6e-adc5-8fae9df44ced"), c5x.Area).ao() as c5x;
					c5x a_3 = new ar7(new Guid("e9f507ab-09ef-49bf-9652-acb3c41730eb"), c5x.Area).ao() as c5x;
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
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array2[num2] = dva;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.c(true);
					a2.a(new ar7(a_));
					array3[num3] = a2;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.c(false);
					a3.a(new ar7(a_2));
					array4[num4] = a3;
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a4 = new a5();
					a4.c(false);
					a4.a(new ar7(a_3));
					array5[num5] = a4;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array6[num6] = c8s;
					base.a(array6);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E78 RID: 3704
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D30 RID: 19760 RVA: 0x002203A8 File Offset: 0x0021E5A8
		internal bool a(e6d A_0)
		{
			if (this.a != null)
			{
				this.a.d(true);
			}
			if (this.b != null)
			{
				this.b.d(true);
			}
			return true;
		}

		// Token: 0x04001F7E RID: 8062
		public cnb a;

		// Token: 0x04001F7F RID: 8063
		public cnb b;
	}
}
