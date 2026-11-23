using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000D55 RID: 3413
[e79("Xpbl_OpeningTheFort")]
public sealed class d0b : dgy
{
	// Token: 0x06004ABA RID: 19130 RVA: 0x00200450 File Offset: 0x001FE650
	public d0b()
	{
		d0b.b b = new d0b.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			d0b.c c = new d0b.c();
			c.c = b;
			c.a = (c.c.a.aqu().v().b() as c5x);
			if (c.a != null)
			{
				c.b = c.a.Area;
				if (c.b != null)
				{
					d0b.d d = new d0b.d();
					d.i = c;
					d.b = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), d.i.a.Area).ao() as c5x);
					d.a = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), d.i.a.Area).ao() as c5x);
					c5x c5x = new ar7(new Guid("34b8bf7c-45dc-45b5-a4a0-79fe5ee77c39"), d.i.a.Area).ao() as c5x;
					d.f = (new ar7(new Guid("f613302e-99a5-451c-9172-b845bc211152"), d.i.a.Area).ao() as c5x);
					d.g = (new ar7(new Guid("773484b5-c07b-49c0-9ee8-5aea6a05e748"), d.i.a.Area).ao() as c5x);
					d.h = (new ar7(new Guid("256697bc-d119-47f8-b155-0c6ae47d5c36"), d.i.a.Area).ao() as c5x);
					d.d = (new ar7(new Guid("bce13594-66b8-4590-a54d-0630178d09fa"), d.i.a.Area).ao() as c5x);
					d.c = d.d.GetAspect<axh>();
					d.e = (new ar7(new Guid("e76fa517-03bc-42ab-83a7-d5df18ae07b7"), d.i.a.Area).ao() as c5x);
					cky cky = (d.i.c.a.aqu().ac() as bv9).abu(asp.a, asp.f5);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(d0b.a.a.a));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("xpbl_e6", new Vector3(17f, 15f, 0f)));
					kw.IsAsync = true;
					array2[num2] = kw;
					base.a(array2);
					if (d.b != null && d.a != null && c5x != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(d.f), null, null, null)
						});
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.i), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.h), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(d.i.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					if (d.a != null && cky.a != h.a)
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(d.g), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						egx egx = new egx();
						egx.a("Охранники - заходите.");
						array3[num3] = new ace(egx)
						{
							TargetRef = new ar7(d.a)
						};
						base.a(array3);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(d.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(d.a), null, null, null)
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s = new s5();
						s.a(new ar7(d.f));
						s.a(new bt4("guard1_enter"));
						s.IsAsync = true;
						s.a(true);
						array4[num4] = s;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(d.g));
						s2.a(new bt4("guard2_enter"));
						s2.IsAsync = true;
						s2.a(true);
						array5[num5] = s2;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(d.h));
						s3.a(new bt4("guard3_enter"));
						s3.IsAsync = true;
						s3.a(true);
						array6[num6] = s3;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(d.i.c.a));
						array7[num7] = dva2;
						base.a(array7);
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_fu", "FromSouth"), true, new bool?(false), 0, null, true, false, false)
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						e2l e2l = new e2l();
						e2l.a("xpbl_e6");
						e2l.a(new css());
						array8[num8] = new ace(e2l);
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						d92 d2 = new d92();
						d2.a("events\\xpbl\\le_openingFort");
						d2.b(new ar7(d.b.qe(), new Guid("9d7046f1-4b98-4a6b-861b-8adc8a42b444"), new Guid("1d0db220-4a4f-4106-a370-1ddcfdfae9f4"), bl1.a));
						d2.a(new ar7(d.i.a.qe(), new Guid("9d7046f1-4b98-4a6b-861b-8adc8a42b444"), new Guid("1d0db220-4a4f-4106-a370-1ddcfdfae9f4"), bl1.a));
						array9[num9] = d2;
						base.a(array9);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						return;
					}
					btm[] array10 = new btm[1];
					int num10 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(d0b.a.a.b));
					array10[num10] = dva3;
					base.a(array10);
					base.a(new btm[]
					{
						new ace(new bu0("cp_expedition_openedKeep"))
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D56 RID: 3414
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004ABD RID: 19133 RVA: 0x00200D24 File Offset: 0x001FEF24
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x00200D48 File Offset: 0x001FEF48
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001DE9 RID: 7657
		public static readonly d0b.a a = new d0b.a();

		// Token: 0x04001DEA RID: 7658
		public static Func<e6d, bool> b;

		// Token: 0x04001DEB RID: 7659
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000D57 RID: 3415
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x00200D78 File Offset: 0x001FEF78
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			this.a.aqu().r()["loc_xpbl_e6_crowdPlaced"] = true;
			return true;
		}

		// Token: 0x04001DEC RID: 7660
		public cnk a;
	}

	// Token: 0x02000D58 RID: 3416
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004AC2 RID: 19138 RVA: 0x00200DC8 File Offset: 0x001FEFC8
		internal bool a(e6d A_0)
		{
			evm evm = new evm();
			evm.b(this.b.y8());
			evm.b(new Guid("e50c0055-43d2-4958-afea-df31beb83d45"));
			evm.a(new Guid("f6200458-5482-4e6c-bde4-492735e7b9b0"));
			evm.a(bbo.b);
			evm.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001DED RID: 7661
		public c5x a;

		// Token: 0x04001DEE RID: 7662
		public aud b;

		// Token: 0x04001DEF RID: 7663
		public d0b.b c;
	}

	// Token: 0x02000D59 RID: 3417
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004AC4 RID: 19140 RVA: 0x00200E28 File Offset: 0x001FF028
		internal bool f(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			this.b.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00200E44 File Offset: 0x001FF044
		internal bool e(e6d A_0)
		{
			if (this.c != null)
			{
				this.c.a(this.i.a, true, null);
			}
			if (this.d != null && this.d.o.b != null)
			{
				this.d.o.b.f = 1.35f;
			}
			if (this.e != null && this.e.o.b != null)
			{
				this.e.o.b.f = 1.32f;
			}
			return true;
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00200EF4 File Offset: 0x001FF0F4
		internal bool d(e6d A_0)
		{
			if (this.c != null)
			{
				this.c.a(this.i.a, false, null);
			}
			if (this.d != null && this.d.o.b != null)
			{
				this.d.o.b.f = 1f;
			}
			if (this.e != null && this.e.o.b != null)
			{
				this.e.o.b.f = 1f;
			}
			return true;
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00200FA4 File Offset: 0x001FF1A4
		internal bool c(e6d A_0)
		{
			if (this.c != null)
			{
				this.c.a(this.i.a, true, null);
			}
			if (this.d != null && this.d.o.b != null)
			{
				this.d.o.b.f = 1.35f;
			}
			if (this.e != null && this.e.o.b != null)
			{
				this.e.o.b.f = 1.32f;
			}
			return true;
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00201054 File Offset: 0x001FF254
		internal bool i(e6d A_0)
		{
			if (this.c != null)
			{
				this.c.a(this.i.a, false, null);
			}
			if (this.d != null && this.d.o.b != null)
			{
				this.d.o.b.f = 1f;
			}
			if (this.e != null && this.e.o.b != null)
			{
				this.e.o.b.f = 1f;
			}
			return true;
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x00201104 File Offset: 0x001FF304
		internal bool h(e6d A_0)
		{
			if (this.c != null)
			{
				this.c.a(this.i.a, true, null);
			}
			if (this.d != null && this.d.o.b != null)
			{
				this.d.o.b.f = 1.35f;
			}
			if (this.e != null && this.e.o.b != null)
			{
				this.e.o.b.f = 1.32f;
			}
			return true;
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x002011B4 File Offset: 0x001FF3B4
		internal bool g(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x002011C4 File Offset: 0x001FF3C4
		internal bool b(e6d A_0)
		{
			if (this.f.t.b != null)
			{
				this.f.t.b.y6()[ddq.ay] = new bt4("guard1_enter");
			}
			if (this.g.t.b != null)
			{
				this.g.t.b.y6()[ddq.ay] = new bt4("guard2_enter");
			}
			if (this.h.t.b != null)
			{
				this.h.t.b.y6()[ddq.ay] = new bt4("guard3_enter");
			}
			this.i.c.a.aqu().r()["loc_xpbl_fu_enteredWithAegis"] = true;
			return true;
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x002012B8 File Offset: 0x001FF4B8
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x04001DF0 RID: 7664
		public c5x a;

		// Token: 0x04001DF1 RID: 7665
		public c5x b;

		// Token: 0x04001DF2 RID: 7666
		public axh c;

		// Token: 0x04001DF3 RID: 7667
		public c5x d;

		// Token: 0x04001DF4 RID: 7668
		public c5x e;

		// Token: 0x04001DF5 RID: 7669
		public c5x f;

		// Token: 0x04001DF6 RID: 7670
		public c5x g;

		// Token: 0x04001DF7 RID: 7671
		public c5x h;

		// Token: 0x04001DF8 RID: 7672
		public d0b.c i;
	}
}
