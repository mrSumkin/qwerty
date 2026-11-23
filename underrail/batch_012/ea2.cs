using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules;

// Token: 0x02000EFD RID: 3837
[e79("Xphw_ExoBase_Trg1_TrainingStart")]
public sealed class ea2 : dgy
{
	// Token: 0x06004E87 RID: 20103 RVA: 0x00231FEC File Offset: 0x002301EC
	public ea2()
	{
		ea2.a a = new ea2.a();
		base..ctor();
		a.a = this;
		a.b = bpo.GetServiceOrThrow<cnk>();
		if (a.b != null && a.b.aqu() != null)
		{
			ea2.b b = new ea2.b();
			b.c = (a.b.aqu().v().b() as c5x);
			b.b = a.b.aqw().a();
			b.a = new aow();
			if (b.c != null && a.b != null && b.b != null)
			{
				ea2.c c = new ea2.c();
				c.e = b;
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				if (c.e.b != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(c.e.b.ab4(new string[]
					{
						"data"
					})) as c5x;
					if (c5x != null)
					{
						if (c5x.a("north"))
						{
							flag = true;
						}
						if (c5x.a("east"))
						{
							flag3 = true;
						}
						if (c5x.a("west"))
						{
							flag4 = true;
						}
						if (c5x.a("south"))
						{
							flag2 = true;
						}
					}
				}
				c.a = a.b.aqw().a().ab4(new string[]
				{
					"eyeCluster1"
				});
				c.b = a.b.aqw().a().ab4(new string[]
				{
					"eyeCluster2"
				});
				c.c = a.b.aqw().a().ab4(new string[]
				{
					"eyeCluster3"
				});
				c.d = a.b.aqw().a().ab4(new string[]
				{
					"eyeCluster4"
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.7))
				});
				if (dqp.a(a.b.aqw(), false, true))
				{
					btm[] array = new btm[1];
					int num = 0;
					egx egx = new egx();
					egx.a("::Вы слышите что-то высоко над собой.::");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(c.e.c)
					};
					base.a(array);
				}
				btm[] array2 = new btm[1];
				int num2 = 0;
				b6r b6r = new b6r();
				b6r.b(new Guid("d111cfb3-3946-48e7-822d-9089e89b8168"));
				b6r.a(new Guid("d5b79115-5b19-4af4-b2a1-2f0f6fa822cf"));
				b6r.b(c.e.c.Area.y8());
				b6r.a(bbo.c);
				array2[num2] = new ace(b6r);
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.7))
				});
				if (flag || flag4)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					kw kw = new kw();
					kw.a(new bt4("cam1"));
					kw.a(new float?(9f));
					kw.a(false);
					array3[num3] = kw;
					base.a(array3);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.f), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.e), null, null, null)
					});
				}
				if (flag || flag3)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4("cam2"));
					kw2.a(new float?(9f));
					kw2.a(false);
					array4[num4] = kw2;
					base.a(array4);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.h), null, null, null)
					});
				}
				if (flag2 || flag3)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					kw kw3 = new kw();
					kw3.a(new bt4("cam3"));
					kw3.a(new float?(9f));
					kw3.a(false);
					array5[num5] = kw3;
					base.a(array5);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.g), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.b), null, null, null)
					});
				}
				if (flag2 || flag4)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					kw kw4 = new kw();
					kw4.a(new bt4("cam4"));
					kw4.a(new float?(9f));
					kw4.a(false);
					array6[num6] = kw4;
					base.a(array6);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(c.c), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				kw kw5 = new kw();
				kw5.a(new bt4("cam5"));
				kw5.a(new float?(9f));
				kw5.a(false);
				array7[num7] = kw5;
				base.a(array7);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.e.a), null, null, null)
				});
			}
		}
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x00232740 File Offset: 0x00230940
	private void a(int A_0, c1a A_1)
	{
		if (!dqp.a(A_1, false, true))
		{
			return;
		}
		List<csd> list = dqp.a("deploy_trg_1", A_1);
		if (list != null && Enumerable.Any<csd>(list))
		{
			bool a_ = A_0 % 2 == 0;
			float a_2 = (A_0 % 2 == 0) ? 0.2f : 0.5f;
			bool a_3 = false;
			bu6 service = bpo.GetService<bu6>();
			if (service != null)
			{
				if (service.aq2() >= GameDifficulty.Hard)
				{
					a_3 = true;
				}
				else
				{
					list.RemoveAt(list.Count - 1);
				}
			}
			List<c5x> list2 = dqp.a(list, false, dqp.d(), a_, 0f, a_2, a_3, null);
			int num = 0;
			if (list2 != null && Enumerable.Any<c5x>(list2))
			{
				bool flag = false;
				foreach (c5x c5x in list2)
				{
					csd csd = A_1.g("dropDown_" + A_0.ToString() + "_" + num++.ToString());
					if (c5x.t.b != null)
					{
						c5x.t.b.y6().RemoveProperty(ddq.ay);
						c5x.t.b.y6()[ddq.bz] = "player";
						c5x.t.b.y6()[ddq.b0] = 8;
					}
					ny aspect = c5x.GetAspect<ny>();
					if (aspect != null)
					{
						int a = cux.a;
						awx awx = new awx();
						awx awx2 = awx;
						awx2.a(awx2.kh() | m7.b);
						awx.ad().Add(new bxp(c5x, csd.Direction));
						awx.ad().Add(new bm3(A_0 * 100 + cuo.a.Next(0, 3) * 100));
						List<auv> list3 = awx.ad();
						b16 b = new b16();
						b.a(new int?(0));
						list3.Add(new a4s(b, null, new ar7(c5x), null));
						List<auv> list4 = awx.ad();
						epw epw = new epw();
						epw.a(new CharacterState?(CharacterState.Custom3));
						list4.Add(new a4s(epw, null, new ar7(c5x), null));
						awx.ad().Add(new a8v(c5x, new Vector3(csd.Location.X, csd.Location.Y, csd.Location.Z + 2f)));
						List<auv> list5 = awx.ad();
						bpr bpr = new bpr(c5x.j.b, csd.Location, new float?((float)16), null);
						bpr.a(false);
						bpr.b(false);
						list5.Add(bpr);
						awx.ad().Add(new au0(c5x.Area, csd.Location, "DustImpact", 1, double.MaxValue, new float?((float)1), new int?(a), null));
						if (!flag)
						{
							flag = true;
							awx.ad().Add(new bm3(100));
							List<auv> list6 = awx.ad();
							bfq bfq = new bfq();
							bfq.a(bvl.d);
							bfq.b("land_rocks");
							bfq.c("DestructableRocksDestroyed");
							bfq.a(c9z.a);
							bfq.a(true);
							bfq.a(0.2f);
							list6.Add(new a4s(bfq, null, null, null));
							List<auv> list7 = awx.ad();
							bfq bfq2 = new bfq();
							bfq2.a(bvl.d);
							bfq2.b("land_metal");
							bfq2.c("Xphw_ExoskeletonJumpLand");
							bfq2.a(c9z.a);
							bfq2.a(true);
							bfq2.a(0.3f);
							list7.Add(new a4s(bfq2, null, null, null));
						}
						awx.ad().Add(new e4t(c5x.h.b, CharacterState.Custom3, a, 0, null, 1));
						List<auv> list8 = awx.ad();
						b16 b2 = new b16();
						b2.a(null);
						list8.Add(new a4s(b2, null, new ar7(c5x), null));
						List<auv> list9 = awx.ad();
						epw epw2 = new epw();
						epw2.a(null);
						list9.Add(new a4s(epw2, null, new ar7(c5x), null));
						aspect.a(awx, atp.a, true, false);
					}
				}
			}
		}
	}

	// Token: 0x02000EFE RID: 3838
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E8A RID: 20106 RVA: 0x00232BC8 File Offset: 0x00230DC8
		internal bool b(e6d A_0)
		{
			this.a.a(1, this.b.aqw());
			return true;
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00232BE4 File Offset: 0x00230DE4
		internal bool a(e6d A_0)
		{
			this.a.a(2, this.b.aqw());
			return true;
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00232C00 File Offset: 0x00230E00
		internal bool c(e6d A_0)
		{
			this.a.a(3, this.b.aqw());
			return true;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00232C1C File Offset: 0x00230E1C
		internal bool d(e6d A_0)
		{
			this.a.a(4, this.b.aqw());
			return true;
		}

		// Token: 0x04002012 RID: 8210
		public ea2 a;

		// Token: 0x04002013 RID: 8211
		public cnk b;
	}

	// Token: 0x02000EFF RID: 3839
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004E8F RID: 20111 RVA: 0x00232C40 File Offset: 0x00230E40
		internal bool a(e6d A_0)
		{
			b0b b0b = Enumerable.FirstOrDefault<b0b>(this.b.ab4(new string[]
			{
				"endBattleCheck"
			}));
			if (b0b != null)
			{
				t6 aspect = b0b.GetAspect<t6>();
				if (aspect != null)
				{
					aspect.a(true);
				}
			}
			this.a.v(this.c, this.c, null);
			return true;
		}

		// Token: 0x04002014 RID: 8212
		public aow a;

		// Token: 0x04002015 RID: 8213
		public d60 b;

		// Token: 0x04002016 RID: 8214
		public c5x c;
	}

	// Token: 0x02000F00 RID: 3840
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004E91 RID: 20113 RVA: 0x00232CAC File Offset: 0x00230EAC
		internal bool f(e6d A_0)
		{
			foreach (b0b b0b in this.a)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, false);
			}
			return true;
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x00232D18 File Offset: 0x00230F18
		internal bool e(e6d A_0)
		{
			foreach (b0b b0b in this.a)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, true);
			}
			return true;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00232D84 File Offset: 0x00230F84
		internal bool d(e6d A_0)
		{
			foreach (b0b b0b in this.b)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, false);
			}
			return true;
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00232DF0 File Offset: 0x00230FF0
		internal bool h(e6d A_0)
		{
			foreach (b0b b0b in this.b)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, true);
			}
			return true;
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00232E5C File Offset: 0x0023105C
		internal bool g(e6d A_0)
		{
			foreach (b0b b0b in this.c)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, false);
			}
			return true;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00232EC8 File Offset: 0x002310C8
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in this.c)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, true);
			}
			return true;
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00232F34 File Offset: 0x00231134
		internal bool a(e6d A_0)
		{
			foreach (b0b b0b in this.d)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, false);
			}
			return true;
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00232FA0 File Offset: 0x002311A0
		internal bool c(e6d A_0)
		{
			foreach (b0b b0b in this.d)
			{
				c5x a_ = (c5x)b0b;
				this.e.a.c(a_, true);
			}
			return true;
		}

		// Token: 0x04002017 RID: 8215
		public List<b0b> a;

		// Token: 0x04002018 RID: 8216
		public List<b0b> b;

		// Token: 0x04002019 RID: 8217
		public List<b0b> c;

		// Token: 0x0400201A RID: 8218
		public List<b0b> d;

		// Token: 0x0400201B RID: 8219
		public ea2.b e;
	}
}
