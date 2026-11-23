using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000D12 RID: 3346
[e79("Cc_TunnelerBreakIn")]
public sealed class dx1 : dgy
{
	// Token: 0x06004A1E RID: 18974 RVA: 0x001F31B8 File Offset: 0x001F13B8
	public dx1()
	{
		dx1.c c = new dx1.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			c.b = (c.a.aqu().v().b() as c5x);
			if (c.b != null)
			{
				dx1.b b = new dx1.b();
				b.h = c;
				b.h.a.aqu().r()["quest_cc_retakeOutpostForGorsky_invaded"] = true;
				b.d = (new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), b.h.b.Area).ao() as c5x);
				b.f = (new ar7(new Guid("4a06e8fb-c9d2-4c18-afad-6e92118ef334"), b.h.b.Area).ao() as c5x);
				b.g = (new ar7(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"), b.h.b.Area).ao() as c5x);
				b.e = (new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), b.h.b.Area).ao() as c5x);
				b.c = (new ar7(new Guid("e58b6236-c8f3-4c94-975e-ae2a386ea5d0"), b.h.b.Area).ao() as c5x);
				c5x a_ = new ar7(new Guid("76896296-aa6e-4714-a158-c2413ee555da"), b.h.b.Area).ao() as c5x;
				b.b = new ar7(new Guid("31658b0a-550d-4ae3-b11e-395c8158951d"), b.h.b.Area);
				b.a = new List<ar7>();
				b.a.Add(new ar7());
				b.a.Add(new ar7());
				if (b.d != null)
				{
					b.d.t.b.y6()[ddq.ay] = new bt4("global:gorsky:ub");
					b.d.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
				if (b.f != null)
				{
					b.f.t.b.y6()[ddq.ay] = new bt4("global:cc_sneaky:ub");
					b.f.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
				if (b.g != null)
				{
					b.g.t.b.y6()[ddq.ay] = new bt4("global:cc_mykola:ub");
					b.g.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
				if (b.e != null)
				{
					b.e.t.b.y6()[ddq.ay] = new bt4("global:fo_dan:ub");
					b.e.h.b.aa().Defense.a(1000, null, null, false, false, false, null);
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				array[0] = new dva(null, new Func<e6d, bool>(dx1.a.a.a), null, null, null);
				base.a(array);
				btm[] array2 = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("cutsceneObs"));
				kw.a(true);
				kw.IsAsync = false;
				array2[num] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new be6
					{
						DestinationWaypoint = "cutsceneObs"
					})
					{
						InitiatorRef = new ar7(b.h.b)
					}
				});
				btm[] array3 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(b.c));
				array3[num2] = dva;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num3 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b.b));
				array4[num3] = dva2;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num4 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(b.a));
				array5[num4] = dva3;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num5 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(b.d));
				array6[num5] = dva4;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num6 = 0;
				bzm bzm = new bzm();
				bzm.a("tunneler");
				bzm.a(true);
				array7[num6] = new ace(bzm)
				{
					TargetRef = new ar7(b.h.b)
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.1))
				});
				btm[] array8 = new btm[1];
				int num7 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(b.h.b));
				array8[num7] = dva5;
				base.a(array8);
				btm[] array9 = new btm[1];
				int num8 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(b.h.a));
				array9[num8] = dva6;
				base.a(array9);
				btm[] array10 = new btm[1];
				int num9 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(b.e));
				array10[num9] = dva7;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(17.0))
				});
				if (b.e != null)
				{
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				if (b.g != null)
				{
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				btm[] array11 = new btm[1];
				int num10 = 0;
				d92 d = new d92();
				d.a("events\\cc_gorskyAssaultCrawlers");
				d.b(new ar7(b.d));
				d.a(new ar7(a_));
				array11[num10] = d;
				base.a(array11);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D13 RID: 3347
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004A21 RID: 18977 RVA: 0x001F38D8 File Offset: 0x001F1AD8
		internal bool a(e6d A_0)
		{
			return true;
		}

		// Token: 0x04001D83 RID: 7555
		public static readonly dx1.a a = new dx1.a();

		// Token: 0x04001D84 RID: 7556
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000D14 RID: 3348
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004A23 RID: 18979 RVA: 0x001F38E4 File Offset: 0x001F1AE4
		internal bool b(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_abandoned_l2") + ".uzl");
			this.b.Zone.a(a_, 1, null);
			return true;
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x001F3924 File Offset: 0x001F1B24
		internal bool a(e6d A_0)
		{
			cno cno = this.b.Area.Divinations.a("cave1");
			if (cno != null)
			{
				cno.a(this.a.aqu().v().c());
				cno.g();
			}
			return true;
		}

		// Token: 0x04001D85 RID: 7557
		public cnk a;

		// Token: 0x04001D86 RID: 7558
		public c5x b;
	}

	// Token: 0x02000D15 RID: 3349
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A26 RID: 18982 RVA: 0x001F397C File Offset: 0x001F1B7C
		internal bool c(e6d A_0)
		{
			cno cno = this.h.b.Area.Divinations.a("base");
			if (cno != null)
			{
				cno.a(this.h.a.aqu().v().c());
				cno.g();
			}
			for (int i = 1; i <= 2; i++)
			{
				csd csd = this.h.b.Zone.g("rat" + i.ToString());
				if (csd != null)
				{
					c5x c5x = vq.a("creature\\characters\\support\\cc_zoneRat" + i.ToString(), csd, true);
					if (c5x != null)
					{
						if (c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.ay] = new bt4("zoneRat" + i.ToString());
						}
						bn5 bn = c5x.GetAspect<j7>() as bn5;
						if (bn != null)
						{
							bn.b("support\\cc_zr4");
						}
						if (c5x.h.b != null)
						{
							if (this.h.a.aqu().r().GetPrimitivePropertyValue<bool>("quest_cc_robProtWarehouse_playerBroughOwnShields", new bool?(false)).Value)
							{
								List<cgd> classPropertyValue = this.h.a.aqu().r().GetClassPropertyValue<List<cgd>>("quest_cc_robProtWarehouse_shieldItemList");
								if (Enumerable.Any<cgd>(classPropertyValue))
								{
									cgd cgd = Enumerable.FirstOrDefault<cgd>(classPropertyValue);
									if (cgd != null)
									{
										classPropertyValue.RemoveAt(0);
										cgd.Battery = (double)cgd.MaxBattery;
										c5x.h.b.aa().Gear.h().a(cgd, true);
										this.h.a.aqu().r()["quest_cc_robProtWarehouse_shieldItemList"] = classPropertyValue;
									}
								}
							}
							else
							{
								xm xm = new xm();
								xm.na(12);
								xm.nc(14);
								cgd cgd2 = Enumerable.FirstOrDefault<coh>(xm.np()) as cgd;
								if (cgd2 != null)
								{
									cgd2.Battery = (double)cgd2.MaxBattery;
									c5x.h.b.aa().Gear.h().a(cgd2, true);
								}
							}
						}
						this.a[i - 1].a(c5x);
					}
				}
			}
			return true;
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x001F3BE8 File Offset: 0x001F1DE8
		internal bool b(e6d A_0)
		{
			(this.b.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 0.5f, c9z.a, true, false);
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b.aa().FactionId == asp.d7)
					{
						aw1.b(d4n.b.a8(), this.h.b.Area.b(6, 9), false);
						List<cze> list = d4n.b.ay();
						x6 x = new x6();
						x.a("quest_cc_retakeOutpostForGorsky_crawlersKilled");
						list.Add(x);
					}
				}
			}
			return true;
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x001F3CDC File Offset: 0x001F1EDC
		internal bool a(e6d A_0)
		{
			this.c.c().a("DestructableRocksDestroyed");
			int a_ = 6;
			for (int i = 7; i <= 12; i++)
			{
				ak1 ak = this.h.b.Area.b(a_, i);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						if (b0b.Layer == aju.x)
						{
							b0b.w();
							b0b.an();
						}
					}
					for (int j = 0; j <= cuo.a.Next(3); j++)
					{
						Vector3 a_2 = ak.Location.a() + new Vector3(-0.3f + (float)cuo.a.NextDouble() * 0.6f, -0.3f + (float)cuo.a.NextDouble() * 0.6f, 0.3f + (float)cuo.a.NextDouble() * 0.4f);
						no no = new no();
						no.a(new e6z(this.h.b.Area));
						no.a("Smoke");
						no.a(a_2);
						no.a(1);
						no.a(2147483647.0);
						no.ym(null, null, null);
						no no2 = new no();
						no2.a(new e6z(this.h.b.Area));
						no2.a("DestructableRocksExplosion");
						no2.a(a_2);
						no2.a(1);
						no2.a(2147483647.0);
						no2.ym(null, null, null);
					}
				}
			}
			return true;
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x001F3EBC File Offset: 0x001F20BC
		internal bool d(e6d A_0)
		{
			(this.b.ao() as c5x).c().a("engine", "TunnellerEngineLoop", 1f, c9z.a, true, false);
			return true;
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x001F3EF8 File Offset: 0x001F20F8
		internal bool e(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.ane(1000, null, null, null, null, null);
			}
			if (this.b != null)
			{
				ka ka = (this.b.ao() as c5x).q.b;
				if (ka != null)
				{
					int a_ = 50;
					ka.b("mv 2");
					qy qy = new qy();
					qy.ad().Add(new bpr((this.b.ao() as c5x).j.b, new Vector3(7f, 8f, 0f)));
					this.h.b.Zone.ActionManager.g9(qy, atp.a);
					qy qy2 = new qy();
					qy2.ad().Add(new c6y(ka, a_, 0, 11, 5));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 6"), null, null, null));
					qy2.ad().Add(new c6y(ka, a_, 0, 12, 1));
					List<auv> list = qy2.ad();
					b18 b = new b18();
					b.b("engine");
					list.Add(new a4s(b, null, this.b, null));
					qy2.ad().Add(new bm3(700));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 1"), null, null, null));
					qy2.ad().Add(new c6y(ka, 100, 0, 8, 1));
					qy2.ad().Add(new bm3(800));
					qy2.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 2"), null, null, null));
					qy2.ad().Add(new a4s(new bfq("TunnellerDoorOpen"), null, this.b, null));
					qy2.ad().Add(new c6y(ka, 180, 0, 11, 1));
					qy2.ad().Add(new bm3(500));
					int num = 1;
					this.h.a.aqu().r()["hidePlayer"] = false;
					this.h.a.aqu().r()["quest_cc_retakeOutpostForGorsky_unboarded"] = true;
					this.h.a.aqu().r()["quest_cc_retakeOutpostForGorsky_tidyingTime"] = this.h.a.aqu().p() + TimeSpan.FromHours(2.0);
					foreach (c5x c5x in new c5x[]
					{
						this.d,
						this.e,
						this.h.b,
						this.f,
						this.g,
						this.a[0].ao() as c5x,
						this.a[1].ao() as c5x
					})
					{
						if (c5x != null)
						{
							csd csd = c5x.Zone.g("pos" + num.ToString());
							if (c5x.h.b.aa().Gear.h().Item != null)
							{
								c5x.h.b.aa().Defense.a(true);
							}
							if (csd != null)
							{
								awx awx = new awx();
								awx.a(m7.b);
								awx.ad().Add(new bxp(c5x, HorizontalDirection.South));
								awx.ad().Add(new a8v(c5x, c5x.Zone.g("tun1exit").Location));
								if (c5x == this.h.b)
								{
									List<auv> list2 = awx.ad();
									ad6 ad = new ad6(this.h.b);
									ad.b(0.99);
									ad.c(1.0);
									ad.a(1.0);
									list2.Add(ad);
								}
								awx.ad().Add(new bm3(250));
								List<auv> list3 = awx.ad();
								djk djk = new djk(c5x.GetAspect<ale>(), c5x.Area.a(csd.Location.a()));
								djk.c(10);
								list3.Add(djk);
								awx.ad().Add(new bxp(c5x, csd.Direction));
								qy2.ad().Add(new g1(c5x.GetAspect<ny>(), awx, atp.a, false));
								qy2.ad().Add(new bm3(1500));
							}
						}
						num++;
					}
					this.h.b.Zone.ActionManager.g9(qy2, atp.a);
				}
			}
			return true;
		}

		// Token: 0x04001D87 RID: 7559
		public List<ar7> a;

		// Token: 0x04001D88 RID: 7560
		public ar7 b;

		// Token: 0x04001D89 RID: 7561
		public c5x c;

		// Token: 0x04001D8A RID: 7562
		public c5x d;

		// Token: 0x04001D8B RID: 7563
		public c5x e;

		// Token: 0x04001D8C RID: 7564
		public c5x f;

		// Token: 0x04001D8D RID: 7565
		public c5x g;

		// Token: 0x04001D8E RID: 7566
		public dx1.c h;
	}
}
