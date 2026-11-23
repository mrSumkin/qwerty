using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000E80 RID: 3712
[e79("Rkl_BeckArrives")]
public sealed class e1t : dgy
{
	// Token: 0x06004D3C RID: 19772 RVA: 0x00220DB8 File Offset: 0x0021EFB8
	public e1t()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			e1t.a a = new e1t.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				aud aud = a.a.Area;
				if (aud != null)
				{
					bpo.GetService<ps>().alm(true);
					a.b = new EntityAspectReference<cnb, bim>(aud, new Guid("ca1d944e-3bb1-4ce3-8dad-59ebcff78131")).ao();
					a.c = new EntityAspectReference<cnb, bim>(aud, new Guid("054110c0-7d2c-4669-82a8-0dd99cdc7b95")).ao();
					a.d = (new ar7(new Guid("47d3dc37-3dbc-4514-9404-56ceebd19983"), a.a.Area).ao() as c5x);
					c5x a_ = new ar7(new Guid("3b4d720f-fc94-4e6e-adc5-8fae9df44ced"), a.a.Area).ao() as c5x;
					c5x a_2 = new ar7(new Guid("e9f507ab-09ef-49bf-9652-acb3c41730eb"), a.a.Area).ao() as c5x;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					kw kw = new kw();
					kw.a(new bt4("rkl2", new Vector3(9f, 11f, 0f)));
					array[num] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.a));
					array2[num2] = dva;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					s5 s = new s5();
					s.a(new ar7(a.a));
					s.a(new bt4("playerRetreat"));
					s.IsAsync = true;
					s.a(true);
					array3[num3] = s;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.d));
					s2.a(new bt4("beckIn"));
					s2.IsAsync = true;
					array4[num4] = s2;
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(a_));
					s3.a(new bt4("hunter1in"));
					s3.IsAsync = true;
					array5[num5] = s3;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(a_2));
					s4.a(new bt4("hunter2in"));
					s4.IsAsync = true;
					array6[num6] = s4;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					if (a.d != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E81 RID: 3713
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D3E RID: 19774 RVA: 0x002210D8 File Offset: 0x0021F2D8
		internal bool a(e6d A_0)
		{
			if (this.b != null)
			{
				this.b.d(true);
			}
			if (this.c != null)
			{
				this.c.d(true);
			}
			return true;
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x0022110C File Offset: 0x0021F30C
		internal bool b(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F88 RID: 8072
		public c5x a;

		// Token: 0x04001F89 RID: 8073
		public cnb b;

		// Token: 0x04001F8A RID: 8074
		public cnb c;

		// Token: 0x04001F8B RID: 8075
		public c5x d;
	}
}
