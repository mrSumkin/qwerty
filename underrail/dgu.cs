using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E51 RID: 3665
[e79("Fo_BeastDies")]
public sealed class dgu : dgy
{
	// Token: 0x06004CE0 RID: 19680 RVA: 0x0021BFF0 File Offset: 0x0021A1F0
	public dgu()
	{
		dgu.a a = new dgu.a();
		base..ctor();
		a.a = this;
		a.b = bpo.GetServiceOrThrow<cnk>();
		if (a.b != null && a.b.aqu() != null)
		{
			dgu.b b = new dgu.b();
			b.b = a;
			b.a = (b.b.b.aqu().v().b() as c5x);
			if (b.a != null)
			{
				dgu.c c = new dgu.c();
				c.h = b;
				ar7 ar = new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), c.h.a.Area);
				ar7 ar2 = new ar7(new Guid("f9260bea-934e-49f0-b86b-7ee9a590ae94"), c.h.a.Area);
				ar7 ar3 = new ar7(new Guid("49aa4d48-1321-4df8-8afb-b872eca2b379"), c.h.a.Area);
				c.a = new ar7();
				c.b = new ar7(new Guid("02c1950d-4b22-47da-a212-2fed9e5f9ae5"), c.h.a.Area);
				c.d = new ar7(new Guid("ba0e1f12-cee3-463d-ae34-74acb6113adb"), c.h.a.Area);
				c.e = new ar7(new Guid("a0dc74d6-8acd-439c-8b47-b0e51a695722"), c.h.a.Area);
				ar7 a_ = new ar7(new Guid("d8ba1244-ff5d-439d-8d3f-593c2a01ea88"), c.h.a.Area);
				c.c = new ar7(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"), c.h.a.Area);
				c.f = new ar7(new Guid("21928db4-46c2-443c-b8ca-351094b6648b"), c.h.a.Area);
				c.g = new ar7(new Guid("5af048ef-9e0d-4fa1-812d-9db098621d08"), c.h.a.Area);
				c5x c5x = ar.ao() as c5x;
				c5x c5x2 = ar2.ao() as c5x;
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
				if (c5x != null)
				{
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "global:fo_dan"
						})
						{
							InitiatorRef = ar
						}
					});
				}
				if (c5x2 != null)
				{
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "global:fo_saban"
						})
						{
							InitiatorRef = ar2
						}
					});
				}
				if (ar3.ao() != null)
				{
					base.a(new btm[]
					{
						new ace(new be6
						{
							DestinationWaypoint = "global:fo_plasmaSentry"
						})
						{
							InitiatorRef = ar3
						}
					});
				}
				base.a(new btm[]
				{
					new ace(new be6
					{
						DestinationWaypoint = "lever"
					})
					{
						InitiatorRef = new ar7(c.h.a)
					}
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("cutsceneCamera1"));
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(c.g));
				array4[num4] = dva;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				s5 s = new s5();
				s.a(c.a);
				s.a(new bt4("beastDeath"));
				s.a(true);
				array5[num5] = s;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.OperateShort);
				bb.a(new ar7(c.h.a));
				array6[num6] = bb;
				base.a(array6);
				base.a(new btm[]
				{
					new ace(new bfq("MetalLever"))
					{
						TargetRef = c.b
					}
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(c.f));
				array7[num7] = dva2;
				base.a(array7);
				btm[] array8 = new btm[1];
				int num8 = 0;
				b6r b6r = new b6r();
				b6r.b(new Guid("cf5b1a22-9867-4b0a-b73f-602006f21856"));
				b6r.a(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"));
				b6r.a(bbo.c);
				b6r.b("fo5");
				array8[num8] = new ace(b6r)
				{
					TargetRef = c.b
				};
				base.a(array8);
				btm[] array9 = new btm[1];
				int num9 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("cutsceneCamera2"));
				array9[num9] = kw2;
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(c.e));
				array10[num10] = dva3;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("LargeArcFurnaceDoor"))
					{
						TargetRef = c.b
					}
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				bfq bfq = new bfq("bubbling", "LargeArcFurnaceBubbling");
				bfq.a(true);
				bfq.a(c9z.b);
				bfq.d(true);
				array11[num11] = new ace(bfq)
				{
					TargetRef = c.g
				};
				base.a(array11);
				btm[] array12 = new btm[1];
				int num12 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(c.d));
				array12[num12] = dva4;
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.3))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(c.h.b.a));
				array13[num13] = dva5;
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.9))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(c.h.b.c));
				array14[num14] = dva6;
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new bfq("BladelingDies"))
					{
						TargetRef = c.b
					}
				});
				base.a(new btm[]
				{
					new ace(new bfq("FireballSpread"))
					{
						TargetRef = c.b
					}
				});
				btm[] array15 = new btm[1];
				int num15 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(c.h.b.b));
				array15[num15] = dva7;
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				bb8 bb2 = new bb8();
				bb2.a(CharacterState.Die);
				bb2.a(c.a);
				array16[num16] = bb2;
				base.a(array16);
				btm[] array17 = new btm[1];
				int num17 = 0;
				a5 a2 = new a5();
				a2.a(c.a);
				array17[num17] = a2;
				base.a(array17);
				btm[] array18 = new btm[1];
				int num18 = 0;
				a5 a3 = new a5();
				a3.a(a_);
				array18[num18] = a3;
				base.a(array18);
				btm[] array19 = new btm[1];
				int num19 = 0;
				dva dva8 = new dva(null, null, null, null, null);
				dva8.a(new Func<e6d, bool>(c.h.a));
				array19[num19] = dva8;
				base.a(array19);
				btm[] array20 = new btm[1];
				int num20 = 0;
				dva dva9 = new dva(null, null, null, null, null);
				dva9.a(new Func<e6d, bool>(c.b));
				array20[num20] = dva9;
				base.a(array20);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array21 = new btm[1];
				int num21 = 0;
				dva dva10 = new dva(null, null, null, null, null);
				dva10.a(new Func<e6d, bool>(c.a));
				array21[num21] = dva10;
				base.a(array21);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("LargeArcFurnaceDoor"))
					{
						TargetRef = c.b
					}
				});
				btm[] array22 = new btm[1];
				int num22 = 0;
				c6w c6w = new c6w();
				c6w.a = new Func<auv>(c.a);
				c6w.a(c.f);
				array22[num22] = c6w;
				base.a(array22);
				btm[] array23 = new btm[1];
				int num23 = 0;
				dva dva11 = new dva(null, null, null, null, null);
				dva11.a(new Func<e6d, bool>(c.c));
				array23[num23] = dva11;
				base.a(array23);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array24 = new btm[1];
				int num24 = 0;
				e2l e2l = new e2l();
				e2l.a(new qm());
				e2l.a(1);
				e2l.a("fo1");
				array24[num24] = new ace(e2l);
				base.a(array24);
				base.a(new btm[]
				{
					new di4(new c2w("fo1", "player_publicSpeaking"), true, new bool?(false), 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x06004CE1 RID: 19681 RVA: 0x0021CA14 File Offset: 0x0021AC14
	private void a(aud A_0, int A_1, int A_2)
	{
		ak1 ak = A_0.b(A_1, A_2);
		if (ak != null)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == aju.x && !c5x.f && (c5x.o.b == null || !(c5x.o.b.a == "Floor\\LiquidMetal")) && c5x.Size.X < 2f)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}

	// Token: 0x02000E52 RID: 3666
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CE3 RID: 19683 RVA: 0x0021CAFC File Offset: 0x0021ACFC
		internal bool a(e6d A_0)
		{
			ah7 ah = this.b.aqw().i("metalIllumination");
			if (ah != null)
			{
				ah.Enabled = true;
				ae8 a_ = ah.Light;
				a_.a(0.7f);
				ah.Light = a_;
				ah.d();
			}
			return true;
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x0021CB50 File Offset: 0x0021AD50
		internal bool c(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "fo5_l2") + ".uzl");
			this.b.aqw().a(a_, 1, null);
			ah7 ah = this.b.aqw().i("metalIllumination");
			if (ah != null)
			{
				ah.Enabled = true;
				ae8 a_2 = ah.Light;
				a_2.a(1f);
				ah.Light = a_2;
				ah.d();
			}
			return true;
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x0021CBD4 File Offset: 0x0021ADD4
		internal bool b(e6d A_0)
		{
			this.b.aqu().r()["loc_fo_mineReopened"] = true;
			csd csd = this.b.aqw().g("beastDeath");
			boj.a(csd.Area, csd.Location, null, "ScorchGround", 1, double.MaxValue, null, null, null, null);
			return true;
		}

		// Token: 0x04001F43 RID: 8003
		public dgu a;

		// Token: 0x04001F44 RID: 8004
		public cnk b;
	}

	// Token: 0x02000E53 RID: 3667
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004CE7 RID: 19687 RVA: 0x0021CC74 File Offset: 0x0021AE74
		internal bool a(e6d A_0)
		{
			for (int i = 21; i <= 27; i++)
			{
				for (int j = 13; j <= 15; j++)
				{
					this.b.a.a(this.a.Area, i, j);
				}
			}
			for (int k = 25; k <= 27; k++)
			{
				this.b.a.a(this.a.Area, k, 16);
			}
			return true;
		}

		// Token: 0x04001F45 RID: 8005
		public c5x a;

		// Token: 0x04001F46 RID: 8006
		public dgu.a b;
	}

	// Token: 0x02000E54 RID: 3668
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004CE9 RID: 19689 RVA: 0x0021CCF8 File Offset: 0x0021AEF8
		internal bool g(e6d A_0)
		{
			csd a_ = this.h.b.b.aqw().g("FromEast");
			c5x c5x = vq.a("creatures\\bladeBeast", a_, false);
			if (c5x != null)
			{
				this.a.a(c5x);
			}
			return true;
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0021CD48 File Offset: 0x0021AF48
		internal bool f(e6d A_0)
		{
			c5x c5x = this.b.ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b = new Point(1, 0);
			}
			if (this.c.ao() != null)
			{
				this.c.ao().VisualPriority = -1;
				this.c.ao().Size = new Vector3(1f, 2f, 1f);
				this.c.ao().ah();
			}
			return true;
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x0021CDEC File Offset: 0x0021AFEC
		internal bool e(e6d A_0)
		{
			c5x c5x = this.a.ao() as c5x;
			if (c5x != null)
			{
				c5x.VisualDirection = HorizontalDirection.East;
			}
			return true;
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0021CE18 File Offset: 0x0021B018
		internal bool d(e6d A_0)
		{
			c5x c5x = this.d.ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.i.b != null)
			{
				dtb dtb = new dtb();
				List<auv> list = dtb.ad();
				dqm dqm = new dqm(c5x.o.b);
				dqm.b(0);
				dqm.c(7);
				dqm.a(1);
				dqm.a(100.0);
				list.Add(dqm);
				dtb.ad().Add(new ben(c5x.o.b, new Point(0, 1)));
				List<auv> list2 = dtb.ad();
				dqm dqm2 = new dqm(c5x.o.b);
				dqm2.b(0);
				dqm2.c(7);
				dqm2.a(1);
				dqm2.a(100.0);
				list2.Add(dqm2);
				c5x.i.b.b(dtb, atp.a);
			}
			c5x c5x2 = this.e.ao() as c5x;
			if (c5x2 != null && c5x2.o.b != null && c5x2.i.b != null)
			{
				dtb dtb2 = new dtb();
				List<auv> list3 = dtb2.ad();
				dqm dqm3 = new dqm(c5x2.o.b);
				dqm3.b(0);
				dqm3.c(7);
				dqm3.a(1);
				dqm3.a(100.0);
				list3.Add(dqm3);
				dtb2.ad().Add(new ben(c5x2.o.b, new Point(0, 1)));
				List<auv> list4 = dtb2.ad();
				dqm dqm4 = new dqm(c5x2.o.b);
				dqm4.b(0);
				dqm4.c(7);
				dqm4.a(1);
				dqm4.a(100.0);
				list4.Add(dqm4);
				c5x2.i.b.b(dtb2, atp.a);
			}
			return true;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x0021D004 File Offset: 0x0021B204
		internal bool b(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "fo5_l3") + ".uzl");
			this.h.b.b.aqw().a(a_, 1, null);
			c5x c5x = this.e.ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.a = "Objects\\LargeMachines\\LargeArcFurnaceDoorMetalAnimH";
				c5x.o.b.b = new Point(1, 0);
			}
			return true;
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x0021D0A4 File Offset: 0x0021B2A4
		internal bool a(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "fo5_l4") + ".uzl");
			this.h.b.b.aqw().a(a_, 1, null);
			c5x c5x = this.e.ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.a = "Objects\\LargeMachines\\LargeArcFurnaceDoorMetalAnimH";
				c5x.o.b.b = new Point(2, 0);
			}
			return true;
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x0021D144 File Offset: 0x0021B344
		internal auv a()
		{
			c5x c5x = this.f.ao() as c5x;
			c5x c5x2 = this.d.ao() as c5x;
			c5x c5x3 = this.e.ao() as c5x;
			if (c5x != null && c5x.o.b != null && c5x.i.b != null && c5x2 != null && c5x2.o.b != null && c5x2.i.b != null && c5x3 != null && c5x3.o.b != null && c5x3.i.b != null)
			{
				c5x.o.b.d = new float?((float)1);
				dtb dtb = new dtb();
				List<auv> list = dtb.ad();
				dqm dqm = new dqm(c5x.o.b);
				dqm.b(7);
				dqm.c(7);
				dqm.a(-1);
				dqm.a(100.0);
				list.Add(dqm);
				dtb.ad().Add(new ben(c5x.o.b, new Point(7, 0)));
				List<auv> list2 = dtb.ad();
				dqm dqm2 = new dqm(c5x.o.b);
				dqm2.b(7);
				dqm2.c(6);
				dqm2.a(-1);
				dqm2.a(100.0);
				list2.Add(dqm2);
				dtb.ad().Add(new a4s(new bfq("LargeArcFurnaceDoorShut"), null, this.b, null));
				List<auv> list3 = dtb.ad();
				b18 b = new b18();
				b.b("bubbling");
				list3.Add(new a4s(b, null, this.g, null));
				dtb.ad().Add(new ben(c5x2.o.b, new Point(0, 0)));
				dtb.ad().Add(new ben(c5x3.o.b, new Point(0, 0)));
				return dtb;
			}
			return null;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x0021D344 File Offset: 0x0021B544
		internal bool c(e6d A_0)
		{
			c5x c5x = this.e.ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.a = "Objects\\LargeMachines\\LargeArcFurnaceDoorMetal";
				c5x.o.b.b = Point.Zero;
			}
			c5x c5x2 = this.f.ao() as c5x;
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.d = new float?(0f);
			}
			return true;
		}

		// Token: 0x04001F47 RID: 8007
		public ar7 a;

		// Token: 0x04001F48 RID: 8008
		public ar7 b;

		// Token: 0x04001F49 RID: 8009
		public ar7 c;

		// Token: 0x04001F4A RID: 8010
		public ar7 d;

		// Token: 0x04001F4B RID: 8011
		public ar7 e;

		// Token: 0x04001F4C RID: 8012
		public ar7 f;

		// Token: 0x04001F4D RID: 8013
		public ar7 g;

		// Token: 0x04001F4E RID: 8014
		public dgu.b h;
	}
}
