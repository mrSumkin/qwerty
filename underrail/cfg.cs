using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CA7 RID: 3239
[e79("lux_uwa_playerTransformationRitual")]
public sealed class cfg : dgy
{
	// Token: 0x06004920 RID: 18720 RVA: 0x001DE8A8 File Offset: 0x001DCAA8
	public cfg()
	{
		cfg.a a = new cfg.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.c = (a.a.aqu().v().b() as c5x);
			a.b = (new ar7(new Guid("f4eedc64-e18b-4aa7-b1ef-58ad8ba948b9"), a.c.Area).ao() as c5x);
			foreach (b0b b0b in a.a.aqw().a().ab4(new string[]
			{
				"lux-uwa_usables"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.s != null)
				{
					c5x.ae = new float?(0f);
					bb2 bb = c5x.GetAspect<bim>() as bb2;
					if (bb != null)
					{
						bb.a(false);
					}
				}
			}
			c5x c5x2 = new ar7(new Guid("07823e37-6686-46bf-addb-4b85311ed77f"), a.c.Area).ao() as c5x;
			if (c5x2 != null && c5x2.s != null)
			{
				bb2 bb2 = c5x2.GetAspect<bim>() as bb2;
				if (bb2 != null)
				{
					bb2.a(false);
				}
			}
			if (a.c != null)
			{
				cfg.b b = new cfg.b();
				b.b = a;
				b.a = b.b.c;
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (b.b.b != null)
				{
					btm[] array = new btm[1];
					int num = 0;
					egx egx = new egx();
					egx.a("Соберитесь с мыслями \u0097 и приготовьтесь к трансформированию!");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(b.b.b)
					};
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
					});
				}
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("Climb_2"));
				kw.a(false);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c6w c6w = new c6w();
				c6w.a(new ar7(b.a));
				c6w.IsAsync = false;
				c6w.a = new Func<auv>(b.a);
				array3[num3] = c6w;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				c6w c6w2 = new c6w();
				c6w2.a(new ar7(b.b.c));
				c6w2.IsAsync = false;
				c6w2.a = new Func<auv>(b.b.a);
				array4[num4] = c6w2;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				c6w c6w3 = new c6w();
				c6w3.a(new ar7(b.b.c));
				c6w3.IsAsync = true;
				c6w3.a = new Func<auv>(b.c);
				array5[num5] = c6w3;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.IsAsync = true;
				dva.a(new Func<e6d, bool>(b.b.c));
				array6[num6] = dva;
				base.a(array6);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				c6w c6w4 = new c6w();
				c6w4.a(new ar7(b.a));
				c6w4.IsAsync = false;
				c6w4.a = new Func<auv>(b.b);
				array7[num7] = c6w4;
				base.a(array7);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.a), null, null, null)
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				nb nb = new nb();
				nb.a(bvl.d);
				nb.a(true);
				array8[num8] = new ace(nb);
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CA8 RID: 3240
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004922 RID: 18722 RVA: 0x001DED74 File Offset: 0x001DCF74
		internal bool b(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x001DED84 File Offset: 0x001DCF84
		internal auv a()
		{
			c5x c5x = new ar7(new Guid("05fe33af-352e-4b6e-afed-5d54f0a1756d"), this.c.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d6c9586d-75cf-45de-bf50-20f0325febc7"), this.c.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("1bee869f-3fa5-4d25-811a-65f086c5a51c"), this.c.Area).ao() as c5x;
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				ah7 ah = this.a.aqw().i("ForceWallLantern");
				if (ah != null)
				{
					ah.Light = new ae8(ah.Light.d(), 0.45f, ah.Light.a());
					ah.LightFadeRate = 0.1f;
					ah.d();
				}
				ah7 ah2 = this.a.aqw().i("OculusFlash");
				if (ah2 != null)
				{
					ah2.Enabled = true;
					ah2.d();
				}
				List<auv> list = awx.ad();
				a4s a4s = new a4s(new bfq("OculusThunder"), null, null, null);
				a4s.b(new ar7(this.c));
				list.Add(a4s);
				new Vector3(this.c.Location.X, this.c.Location.Y, this.c.Location.Z - 0.6f);
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.3);
				ad6 item = ad;
				bm3 item2 = new bm3(35);
				awx.ad().Add(item);
				ad6 ad2 = new ad6(c5x3);
				ad2.b(0.0);
				ad2.c(1.0);
				ad2.a(0.5);
				item = ad2;
				awx.ad().Add(item);
				awx.ad().Add(item2);
				ad6 ad3 = new ad6(c5x2);
				ad3.b(0.0);
				ad3.c(1.0);
				ad3.a(0.3);
				item = ad3;
				awx.ad().Add(item);
				List<auv> list2 = awx.ad();
				a4s a4s2 = new a4s(new bfq("OculusThunder"), null, null, null);
				a4s2.b(new ar7(this.c));
				list2.Add(a4s2);
			}
			return awx;
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x001DF02C File Offset: 0x001DD22C
		internal bool c(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("05fe33af-352e-4b6e-afed-5d54f0a1756d"), this.c.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d6c9586d-75cf-45de-bf50-20f0325febc7"), this.c.Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("1bee869f-3fa5-4d25-811a-65f086c5a51c"), this.c.Area).ao() as c5x;
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				c5x.ae = new float?(0f);
				c5x2.ae = new float?(0f);
				c5x3.ae = new float?(0f);
				ah7 ah = this.a.aqw().i("ForceWallLantern");
				if (ah != null)
				{
					ah.Light = new ae8(ah.Light.d(), 1f, ah.Light.a());
					ah.d();
				}
				ah7 ah2 = this.a.aqw().i("OculusFlash");
				if (ah2 != null)
				{
					ah2.Enabled = false;
					ah2.d();
				}
			}
			return true;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x001DF168 File Offset: 0x001DD368
		internal bool a(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x04001CE9 RID: 7401
		public cnk a;

		// Token: 0x04001CEA RID: 7402
		public c5x b;

		// Token: 0x04001CEB RID: 7403
		public c5x c;
	}

	// Token: 0x02000CA9 RID: 3241
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004927 RID: 18727 RVA: 0x001DF184 File Offset: 0x001DD384
		internal auv a()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Throw)), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new b16(new int?(2)), null, null, null);
			a4s2.b(new ar7(this.a));
			list2.Add(a4s2);
			for (int i = 0; i <= 9; i++)
			{
				if (i % 2 == 1)
				{
					List<auv> list3 = awx.ad();
					a4s a4s3 = new a4s(new b16(new int?(2)), null, null, null);
					a4s3.b(new ar7(this.a));
					list3.Add(a4s3);
				}
				else
				{
					List<auv> list4 = awx.ad();
					a4s a4s4 = new a4s(new b16(new int?(3)), null, null, null);
					a4s4.b(new ar7(this.a));
					list4.Add(a4s4);
				}
				awx.ad().Add(new bm3(400));
			}
			return awx;
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x001DF298 File Offset: 0x001DD498
		internal auv c()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("PlasmaHit"), null, null, null);
			a4s.b(new ar7(this.b.c));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z);
			awx.ad().Add(new au0(this.b.c.Area, a_, "ExplosionHE_O_Weak_Flame1", 1, double.MaxValue, new float?(0.9f), null, null));
			this.a.h.b.ao = new Color?(new Color(128, 64, 0, 255));
			return awx;
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x001DF39C File Offset: 0x001DD59C
		internal auv b()
		{
			c5x c5x = new ar7(new Guid("2b543825-4a28-42e2-b24b-2ac01f6aea0f"), this.b.c.Area).ao() as c5x;
			if (c5x != null)
			{
				a2o a2o = c5x.GetAspect<cd0>() as a2o;
				if (a2o != null)
				{
					a2o.a = "Creatures\\" + this.b.c.h.b.g.a[CharacterState.Die].b;
				}
			}
			this.a.Size = new Vector3(0.1f, 0.1f, 0f);
			int num = 35;
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new epw(new CharacterState?(CharacterState.Die)), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new b16(new int?(1)), null, null, null);
			a4s2.b(new ar7(this.a));
			list2.Add(a4s2);
			awx.ad().Add(new a8v(this.a, new Vector3(11.96875f, 11.822916f, 4f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(12.270834f, 12.479166f, 4f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(12.552084f, 13.322916f, 4f)));
			awx.ad().Add(new au0(this.a.Area, new Vector3(12.552084f, 13.322916f, 4f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.177083f, 14.447916f, 4f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(12.8125f, 14.520834f, 3f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.4375f, 15.520832f, 3f)));
			awx.ad().Add(new au0(this.a.Area, new Vector3(13.4375f, 15.520832f, 3f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(12.770834f, 15.145831f, 2f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.291667f, 16.041668f, 2f)));
			awx.ad().Add(new bm3(num));
			List<auv> list3 = awx.ad();
			a4s a4s3 = new a4s(new b16(new int?(2)), null, null, null);
			a4s3.b(new ar7(this.a));
			list3.Add(a4s3);
			awx.ad().Add(new au0(this.a.Area, new Vector3(13.927083f, 17.03125f, 2f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			awx.ad().Add(new a8v(this.a, new Vector3(13.927083f, 17.03125f, 2f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.510417f, 16.90625f, 1f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.891668f, 17.641665f, 1f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.891668f, 17.641665f, 0.2f)));
			awx.ad().Add(new bm3(num));
			awx.ad().Add(new a8v(this.a, new Vector3(13.591667f, 17.583334f, 0.2f)));
			awx.ad().Add(new au0(this.b.c.Area, new Vector3(13.591667f, 17.583334f, 0.2f), "SmokeBombPuff", 1, double.MaxValue, new float?(0.9f), null, null));
			List<auv> list4 = awx.ad();
			a4s a4s4 = new a4s(new bfq("QuietRockCrash"), null, null, null);
			a4s4.b(new ar7(this.b.c));
			list4.Add(a4s4);
			List<auv> list5 = awx.ad();
			a4s a4s5 = new a4s(new b16(new int?(3)), null, null, null);
			a4s5.b(new ar7(this.a));
			list5.Add(a4s5);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list6 = awx.ad();
			a4s a4s6 = new a4s(new b16(new int?(4)), null, null, null);
			a4s6.b(new ar7(this.a));
			list6.Add(a4s6);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list7 = awx.ad();
			a4s a4s7 = new a4s(new b16(new int?(5)), null, null, null);
			a4s7.b(new ar7(this.a));
			list7.Add(a4s7);
			awx.ad().Add(new bm3(num - 10));
			List<auv> list8 = awx.ad();
			a4s a4s8 = new a4s(new b16(new int?(6)), null, null, null);
			a4s8.b(new ar7(this.a));
			list8.Add(a4s8);
			return awx;
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x001DFA74 File Offset: 0x001DDC74
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("2b543825-4a28-42e2-b24b-2ac01f6aea0f"), this.b.c.Area).ao() as c5x;
			if (c5x != null)
			{
				this.a.h.b.f(true);
				c5x.o.b.b = new Point(7, 1);
				this.a.ae = new float?(0f);
				c5x.ae = new float?((float)1);
			}
			return true;
		}

		// Token: 0x04001CEC RID: 7404
		public c5x a;

		// Token: 0x04001CED RID: 7405
		public cfg.a b;
	}
}
