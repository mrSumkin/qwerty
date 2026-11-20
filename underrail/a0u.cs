using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F0D RID: 3853
[e79("Xphw_ExoBase_Trg2_VoidReveal")]
public sealed class a0u : dgy
{
	// Token: 0x06004EB6 RID: 20150 RVA: 0x00234FA0 File Offset: 0x002331A0
	public a0u()
	{
		a0u.b b = new a0u.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			b.b = (b.a.aqu().v().b() as c5x);
			b.c = b.a.aqw().a();
			b.d = new aow();
			b.d.c();
			if (b.b != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("cmd2"));
				kw.a(false);
				array[num] = kw;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(b.c));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				c6w c6w = new c6w();
				c6w.a = new Func<auv>(a0u.a.a.a);
				c6w.IsAsync = false;
				c6w.a(new ar7(b.b));
				array3[num3] = c6w;
				base.a(array3);
				btm[] array4 = new btm[1];
				int num4 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(b.b));
				array4[num4] = dva2;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(b.a));
				array5[num5] = dva3;
				base.a(array5);
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(b.g));
				array6[num6] = dva4;
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(b.f));
				array7[num7] = dva5;
				base.a(array7);
				btm[] array8 = new btm[1];
				int num8 = 0;
				egx egx = new egx();
				egx.a("::Вы чувствуете, как ваше сознание отделяется от тела, пока оно не становится полностью отделённым.::");
				array8[num8] = new ace(egx)
				{
					TargetRef = new ar7(b.b)
				};
				base.a(array8);
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(b.e));
				array9[num9] = dva6;
				base.a(array9);
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(b.d));
				array10[num10] = dva7;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F0E RID: 3854
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004EB9 RID: 20153 RVA: 0x002352C8 File Offset: 0x002334C8
		internal auv a()
		{
			return new aqr();
		}

		// Token: 0x04002034 RID: 8244
		public static readonly a0u.a a = new a0u.a();

		// Token: 0x04002035 RID: 8245
		public static Func<auv> b;
	}

	// Token: 0x02000F0F RID: 3855
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004EBB RID: 20155 RVA: 0x002352D8 File Offset: 0x002334D8
		internal bool c(e6d A_0)
		{
			this.b.Area.CustomProperties["Music"] = "xphw_OuterVoid";
			am7 service = bpo.GetService<am7>();
			if (service != null)
			{
				service.ai6();
			}
			return true;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00235318 File Offset: 0x00233518
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in this.c.ab4(new string[]
			{
				"fadeSection_4"
			}))
			{
				c5x c5x = (c5x)b0b;
				ad6 ad = new ad6(c5x);
				ad.b(1.0);
				ad.c(0.0);
				ad.a(0.0005);
				ad6 item = ad;
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				qy.ad().Add(item);
				qy.ad().Add(new c7(c5x, false, false, true, false));
				c5x.Zone.ActionManager.g9(qy, atp.a);
			}
			return true;
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00235404 File Offset: 0x00233604
		internal bool a(e6d A_0)
		{
			int num = 0;
			int[] array = new int[]
			{
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				12,
				13,
				14,
				15,
				17,
				18,
				16,
				2,
				3,
				19,
				1,
				20
			};
			List<b0b> list = this.c.ab4(new string[]
			{
				"sol"
			});
			list.AddRange(this.c.ab4(new string[]
			{
				"solx"
			}));
			list.AddRange(this.c.ab4(new string[]
			{
				"med"
			}));
			list.AddRange(this.c.ab4(new string[]
			{
				"medx"
			}));
			list.AddRange(this.c.ab4(new string[]
			{
				"int"
			}));
			list.AddRange(this.c.ab4(new string[]
			{
				"intx"
			}));
			foreach (b0b b0b in list)
			{
				c5x c5x = (c5x)b0b;
				string a_ = "init_" + array[num++].ToString();
				new be6
				{
					OverrideTargetArea = "xphw_exobase_trg2",
					DestinationWaypoint = a_
				}.ym(c5x, c5x, null);
				if (c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.ay] = new bt4(a_);
				}
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.0001 * (double)cuo.a.Next(2, 6));
				ad6 a_2 = ad;
				c5x.Zone.ActionManager.g9(a_2, atp.a);
			}
			return true;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x002355F0 File Offset: 0x002337F0
		internal bool g(e6d A_0)
		{
			foreach (b0b b0b in this.c.ab4(new string[]
			{
				"fadeSection_5"
			}))
			{
				c5x c5x = (c5x)b0b;
				ad6 ad = new ad6(c5x);
				ad.b(0.0);
				ad.c(1.0);
				ad.a(0.0005);
				ad6 a_ = ad;
				c5x.Zone.ActionManager.g9(a_, atp.a);
			}
			return true;
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x002356A0 File Offset: 0x002338A0
		internal bool f(e6d A_0)
		{
			string str = "";
			for (int i = 0; i < 4; i++)
			{
				switch (i)
				{
				case 0:
					str = "north";
					break;
				case 1:
					str = "east";
					break;
				case 2:
					str = "south";
					break;
				case 3:
					str = "west";
					break;
				}
				c5x a_ = Enumerable.FirstOrDefault<b0b>(this.c.ab4(new string[]
				{
					str + "Eye_1"
				})) as c5x;
				this.d.c(a_, false);
				c5x c5x = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), this.b.Area).ao() as c5x;
				if (c5x != null)
				{
					amc aspect = this.b.GetAspect<amc>();
					if (aspect != null)
					{
						aspect.aa().b("monolithTorch", 1, false);
						List<d5o> list = aspect.aa().b("monolithTorch", 1, true);
						if (list.Count > 0)
						{
							c5x.b("shard");
						}
						list.Clear();
						if (aspect.aa().b("theJuice", 1, false).Count > 0)
						{
							cwy cwy = Enumerable.FirstOrDefault<cwy>(this.b.h.b.aa().StatusEffects.Get<cwy>());
							if (cwy == null)
							{
								this.b.h.b.aa().StatusEffects.a(new cwy(0), false, false, false);
							}
							else
							{
								cwy.Duration = 0;
							}
						}
						else
						{
							cwy cwy2 = Enumerable.FirstOrDefault<cwy>(this.b.h.b.aa().StatusEffects.Get<cwy>());
							if (cwy2 != null)
							{
								cwy2.Duration = 0;
							}
						}
					}
				}
				if (Enumerable.FirstOrDefault<bdm>(this.b.h.b.aa().StatusEffects.Get<bdm>()) == null)
				{
					this.b.h.b.aa().StatusEffects.a(new bdm(), false, false, false);
				}
			}
			return true;
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x002358D0 File Offset: 0x00233AD0
		internal bool e(e6d A_0)
		{
			List<b0b> list = this.a.aqw().a().ab4(new string[]
			{
				"amalgam"
			});
			if (list != null && list.Count > 0)
			{
				foreach (b0b b0b in list)
				{
					((c5x)b0b).c().a("whispers", "xphw_VoidWhispering", 1f, c9z.a, true, false);
				}
			}
			c5x c5x = Enumerable.FirstOrDefault<b0b>(this.a.aqw().a().ab4(new string[]
			{
				"data"
			})) as c5x;
			if (c5x != null && c5x.a("shard"))
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(this.a.aqw().a().ab4(new string[]
				{
					"torchEntity"
				})) as c5x;
				if (c5x2 != null)
				{
					c5x2.c().a("hum", "xphw_VoidTorchHum", 1f, c9z.b, true, false);
					ad6 ad = new ad6(c5x2);
					ad.b(0.0);
					ad.c(1.0);
					ad.a(0.00075);
					ad6 a_ = ad;
					c5x2.Zone.ActionManager.g9(a_, atp.a);
					b6j a_2 = new b6j(new ar7(c5x2), "torch", new float?(0f), 1f, 0.001f, false);
					c5x2.Zone.ActionManager.g9(a_2, atp.a);
					this.d.a("", false);
				}
			}
			else
			{
				c5x c5x3 = Enumerable.FirstOrDefault<b0b>(this.a.aqw().a().ab4(new string[]
				{
					"torchEntity"
				})) as c5x;
				if (c5x3 != null)
				{
					c7 a_3 = new c7(c5x3, false, false, true, false);
					c5x3.Zone.ActionManager.g9(a_3, atp.a);
				}
			}
			return true;
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00235AFC File Offset: 0x00233CFC
		internal bool d(e6d A_0)
		{
			this.b.h.b.aa().a(true);
			List<coh> value = new List<coh>(this.b.h.b.aa().Bag.z2());
			this.b.h.b.aa().Bag.z2().Clear();
			this.b.h.b.aa().CustomProperties.SetPropertyValue("VoidBag", value);
			return true;
		}

		// Token: 0x04002036 RID: 8246
		public cnk a;

		// Token: 0x04002037 RID: 8247
		public c5x b;

		// Token: 0x04002038 RID: 8248
		public d60 c;

		// Token: 0x04002039 RID: 8249
		public aow d;
	}
}
