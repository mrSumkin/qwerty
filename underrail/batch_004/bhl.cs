using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000E4D RID: 3661
[e79("Fo5_DrainTank")]
public sealed class bhl : dgy
{
	// Token: 0x06004CD1 RID: 19665 RVA: 0x0021B79C File Offset: 0x0021999C
	public bhl()
	{
		bhl.b b = new bhl.b();
		base..ctor();
		b.a = this;
		b.b = bpo.GetServiceOrThrow<cnk>();
		if (b.b != null && b.b.aqu() != null)
		{
			bhl.a a = new bhl.a();
			a.c = b;
			a.b = (a.c.b.aqu().v().b() as c5x);
			a.a = new ar7(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"), a.b.Area);
			if (a.b != null)
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
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(bhl.c.a.a));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("cutsceneCamera2"));
				kw.a(true);
				array3[num3] = kw;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.b));
				array4[num4] = dva2;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array5[num5] = c8s;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.c.b));
				array6[num6] = dva3;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.a));
				array7[num7] = dva4;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(a.c.a));
				array8[num8] = dva5;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				b6r b6r = new b6r();
				b6r.b(new Guid("cf5b1a22-9867-4b0a-b73f-602006f21856"));
				b6r.a(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"));
				b6r.a(bbo.b);
				b6r.b("fo5");
				array9[num9] = new ace(b6r)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(a.d));
				array10[num10] = dva6;
				base.a(array10);
				btm[] array11 = new btm[1];
				int num11 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(a.c));
				array11[num11] = dva7;
				base.a(array11);
				btm[] array12 = new btm[1];
				int num12 = 0;
				dva dva8 = new dva(null, null, null, null, null);
				dva8.a(new Func<e6d, bool>(bhl.c.a.b));
				array12[num12] = dva8;
				base.a(array12);
				btm[] array13 = new btm[1];
				int num13 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4(a.b.Area.y8(), a.b.Location));
				kw2.a(true);
				array13[num13] = kw2;
				base.a(array13);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x06004CD2 RID: 19666 RVA: 0x0021BBFC File Offset: 0x00219DFC
	private void a(aud A_0, int A_1, int A_2)
	{
		ak1 ak = A_0.b(A_1, A_2);
		if (ak != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<c5x>(Enumerable.Where<c5x>(Enumerable.OfType<c5x>(ak.c.Values), new Func<c5x, bool>(bhl.c.a.a)));
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}

	// Token: 0x02000E4E RID: 3662
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004CD5 RID: 19669 RVA: 0x0021BC7C File Offset: 0x00219E7C
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x0021BCA0 File Offset: 0x00219EA0
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x0021BCC4 File Offset: 0x00219EC4
		internal bool a(c5x A_0)
		{
			return A_0.o.b != null && A_0.o.b.a == "Floor\\LiquidMetal";
		}

		// Token: 0x04001F3A RID: 7994
		public static readonly bhl.c a = new bhl.c();

		// Token: 0x04001F3B RID: 7995
		public static Func<e6d, bool> b;

		// Token: 0x04001F3C RID: 7996
		public static Func<e6d, bool> c;

		// Token: 0x04001F3D RID: 7997
		public static Func<c5x, bool> d;
	}

	// Token: 0x02000E4F RID: 3663
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004CD9 RID: 19673 RVA: 0x0021BD00 File Offset: 0x00219F00
		internal bool b(e6d A_0)
		{
			aud aud = this.b.aqw().n("fo5");
			if (aud != null)
			{
				for (int i = 11; i <= 15; i++)
				{
					this.a.a(aud, 19, i);
				}
				for (int j = 20; j <= 24; j++)
				{
					this.a.a(aud, j, 11);
				}
			}
			return true;
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x0021BD6C File Offset: 0x00219F6C
		internal bool a(e6d A_0)
		{
			aud aud = this.b.aqw().n("fo5");
			if (aud != null)
			{
				for (int i = 21; i <= 24; i++)
				{
					for (int j = 13; j <= 15; j++)
					{
						this.a.a(aud, i, j);
					}
				}
			}
			ah7 ah = this.b.aqw().i("metalIllumination");
			if (ah != null)
			{
				ah.Enabled = false;
				ah.d();
			}
			return true;
		}

		// Token: 0x04001F3E RID: 7998
		public bhl a;

		// Token: 0x04001F3F RID: 7999
		public cnk b;
	}

	// Token: 0x02000E50 RID: 3664
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CDC RID: 19676 RVA: 0x0021BDFC File Offset: 0x00219FFC
		internal bool b(e6d A_0)
		{
			if (this.a.ao() != null)
			{
				new b1a(this.c.b.aqu().v().c()).be(this.a.ao());
			}
			return true;
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x0021BE4C File Offset: 0x0021A04C
		internal bool a(e6d A_0)
		{
			aud aud = this.c.b.aqw().n("fo5");
			if (aud != null)
			{
				for (int i = 12; i <= 15; i++)
				{
					this.c.a.a(aud, 20, i);
				}
				for (int j = 21; j <= 24; j++)
				{
					this.c.a.a(aud, j, 12);
				}
			}
			csd csd = this.b.Zone.g("beastDeath");
			if (csd != null)
			{
				c5x c5x = vq.a("object\\plot\\Fo_BeastRemains", csd, true);
				if (c5x != null)
				{
					t6 t = new t6(c5x);
					t.b(0);
					t.a(100);
					t.d().Add(new ap2());
					c5x.SetAspect<t6>(t);
				}
			}
			return true;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x0021BF2C File Offset: 0x0021A12C
		internal bool d(e6d A_0)
		{
			cno cno = this.b.Area.Divinations.a("tankDiv");
			if (cno != null)
			{
				cno.b(this.c.b.aqu().v().c());
			}
			return true;
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x0021BF7C File Offset: 0x0021A17C
		internal bool c(e6d A_0)
		{
			if (this.a.ao() != null)
			{
				this.a.ao().w();
				this.a.ao().VisualPriority = -1;
				this.a.ao().Size = new Vector3(1f, 1f, 1f);
				this.a.ao().ah();
			}
			return true;
		}

		// Token: 0x04001F40 RID: 8000
		public ar7 a;

		// Token: 0x04001F41 RID: 8001
		public c5x b;

		// Token: 0x04001F42 RID: 8002
		public bhl.b c;
	}
}
