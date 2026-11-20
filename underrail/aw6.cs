using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000E79 RID: 3705
[e79("Rkl_EdgarAndPlayerArrive")]
public sealed class aw6 : dgy
{
	// Token: 0x06004D31 RID: 19761 RVA: 0x002203DC File Offset: 0x0021E5DC
	public aw6()
	{
		aw6.b b = new aw6.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			aw6.a a = new aw6.a();
			a.a = (b.a.aqu().v().b() as c5x);
			if (a.a != null)
			{
				aud aud = a.a.Area;
				if (aud != null)
				{
					bpo.GetService<ps>().alm(true);
					a.b = new EntityAspectReference<cnb, bim>(aud, new Guid("ca1d944e-3bb1-4ce3-8dad-59ebcff78131")).ao();
					a.c = new EntityAspectReference<cnb, bim>(aud, new Guid("054110c0-7d2c-4669-82a8-0dd99cdc7b95")).ao();
					a.d = (new ar7(new Guid("df4662a5-4c33-4820-9752-6a6de23792a4"), a.a.Area).ao() as c5x);
					c5x c5x = new ar7(new Guid("3b4d720f-fc94-4e6e-adc5-8fae9df44ced"), a.a.Area).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("e9f507ab-09ef-49bf-9652-acb3c41730eb"), a.a.Area).ao() as c5x;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					kw kw = new kw();
					kw.a(new bt4("rkl2", new Vector3(9f, 11f, 0f)));
					kw.IsAsync = true;
					array[num] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b));
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
					s.a(new bt4("playerIn"));
					s.IsAsync = true;
					s.a(true);
					array3[num3] = s;
					base.a(array3);
					if (a.d != null)
					{
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.d));
						s2.a(new bt4("beckIn"));
						s2.IsAsync = true;
						array4[num4] = s2;
						base.a(array4);
					}
					if (c5x != null)
					{
						btm[] array5 = new btm[1];
						int num5 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(c5x));
						s3.a(new bt4("hunter1in"));
						s3.IsAsync = true;
						array5[num5] = s3;
						base.a(array5);
					}
					if (c5x2 != null)
					{
						btm[] array6 = new btm[1];
						int num6 = 0;
						s5 s4 = new s5();
						s4.a(new ar7(c5x2));
						s4.a(new bt4("hunter2in"));
						s4.IsAsync = true;
						array6[num6] = s4;
						base.a(array6);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					if (a.d != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
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

	// Token: 0x02000E7A RID: 3706
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D33 RID: 19763 RVA: 0x0022075C File Offset: 0x0021E95C
		internal bool a(e6d A_0)
		{
			bv9 bv = this.a.aqu().ac() as bv9;
			bv.a(asp.cy, asp.a, h.a, null, true, false, false);
			bv.a(asp.cy, asp.cx, h.a, null, true, false, false);
			return true;
		}

		// Token: 0x04001F80 RID: 8064
		public cnk a;
	}

	// Token: 0x02000E7B RID: 3707
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D35 RID: 19765 RVA: 0x002207C4 File Offset: 0x0021E9C4
		internal bool b(e6d A_0)
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

		// Token: 0x06004D36 RID: 19766 RVA: 0x002207F8 File Offset: 0x0021E9F8
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F81 RID: 8065
		public c5x a;

		// Token: 0x04001F82 RID: 8066
		public cnb b;

		// Token: 0x04001F83 RID: 8067
		public cnb c;

		// Token: 0x04001F84 RID: 8068
		public c5x d;
	}
}
