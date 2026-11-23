using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D10 RID: 3344
[e79("Cc_TunnelerAttackDeparts")]
public sealed class erx : dgy
{
	// Token: 0x06004A19 RID: 18969 RVA: 0x001F28F0 File Offset: 0x001F0AF0
	public erx()
	{
		erx.a a = new erx.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.a.aqu().r()["quest_cc_retakeOutpostForGorsky_invaded"] = true;
				c5x c5x = new ar7(new Guid("94e5185a-506d-41ca-87c8-8595e7cd28fb"), a.b.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("4a06e8fb-c9d2-4c18-afad-6e92118ef334"), a.b.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("e19114c9-2185-47b5-812b-7e45863ac33f"), a.b.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("5b6e2069-f7a5-4ce0-92a0-3fac8085f6be"), a.b.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("933b1824-c576-465f-bd4b-6d7559a5028c"), a.b.Area).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("92aaf0cb-7cd9-4680-82c9-b199c544b64e"), a.b.Area).ao() as c5x;
				a.c = new ar7(new Guid("e61ec8a2-f947-40e1-b6e8-3225c8746bac"), a.b.Area);
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
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("global:cc_mykola"));
				kw.a(true);
				kw.IsAsync = false;
				array2[num2] = kw;
				base.a(array2);
				if (c5x != null)
				{
					btm[] array3 = new btm[1];
					int num3 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(c5x));
					a2.c(true);
					array3[num3] = a2;
					base.a(array3);
				}
				if (c5x2 != null)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					a5 a3 = new a5();
					a3.a(new ar7(c5x2));
					a3.c(true);
					array4[num4] = a3;
					base.a(array4);
				}
				if (c5x3 != null)
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					a5 a4 = new a5();
					a4.a(new ar7(c5x3));
					a4.c(true);
					array5[num5] = a4;
					base.a(array5);
				}
				if (c5x4 != null)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					a5 a5 = new a5();
					a5.a(new ar7(c5x4));
					a5.c(true);
					array6[num6] = a5;
					base.a(array6);
				}
				if (c5x5 != null)
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					a5 a6 = new a5();
					a6.a(new ar7(c5x5));
					a6.c(true);
					array7[num7] = a6;
					base.a(array7);
				}
				if (c5x6 != null)
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					a5 a7 = new a5();
					a7.a(new ar7(c5x6));
					a7.c(true);
					array8[num8] = a7;
					base.a(array8);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array9[num9] = c8s;
				base.a(array9);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(8.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.a(false);
				array10[num10] = dky2;
				base.a(array10);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc_abandoned", "cutsceneEntry"), false, new bool?(false), 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x02000D11 RID: 3345
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A1B RID: 18971 RVA: 0x001F2D78 File Offset: 0x001F0F78
		internal bool c(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = true;
			this.b.ae = new float?(0f);
			a0l.a(this.b, "player_tunneler", true);
			if (this.c.ao() != null)
			{
				ah7 ah = this.b.Zone.i("tunneller");
				if (ah != null)
				{
					ah.g().be(this.c.ao());
				}
			}
			return true;
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x001F2E10 File Offset: 0x001F1010
		internal bool b(e6d A_0)
		{
			if (this.c != null)
			{
				ka ka = (this.c.ao() as c5x).q.b;
				if (ka != null)
				{
					qy qy = new qy();
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "tr 4"), null, null, null));
					qy.ad().Add(new a4s(new bfq("TunnellerDoorOpen"), null, this.c, null));
					qy.ad().Add(new c6y(ka, 180, 0, 11, 1));
					qy.ad().Add(new bm3(500));
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "tr3"), null, null, null));
					qy.ad().Add(new c6y(ka, 180, 0, 10, 1));
					qy.ad().Add(new bm3(500));
					qy.ad().Add(new a4s(new afy(ka, true, 0, true, "st1"), null, null, null));
					List<auv> list = qy.ad();
					bfq bfq = new bfq("engine", "TunnellerEngineLoop");
					bfq.d(true);
					list.Add(new a4s(bfq, null, this.c, null));
					qy.ad().Add(new c6y(ka, 50, 0, 8, 10));
					this.b.Zone.ActionManager.g9(qy, atp.a);
				}
			}
			return true;
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x001F2F90 File Offset: 0x001F1190
		internal bool a(e6d A_0)
		{
			if (this.c.ao() != null)
			{
				(this.c.ao() as c5x).c().a("engine", false);
				this.c.ao().w();
				this.c.ao().an();
			}
			string[] array = new string[]
			{
				"6a2c5c79-18eb-42c3-8789-07a806fb90f7",
				"9ce1c9d8-82e5-4fba-86fb-0eb790e1de24",
				"ec570a6d-cb3c-4ddd-a75c-01d61e329de7",
				"f3d789e3-1c4e-4d42-9773-fb212ed78588",
				"43fdd773-b9b7-44f5-a5e2-727f412ae7b9"
			};
			for (int i = 0; i < array.Length; i++)
			{
				c5x c5x = new ar7(new Guid(array[i]), this.b.Area).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc16_l3") + ".uzl");
			this.b.Area.Zone.a(a_, 1, null);
			for (int j = 11; j <= 15; j++)
			{
				for (int k = 2; k <= 8; k++)
				{
					ak1 ak = this.b.Area.b(j, k);
					if (ak != null)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.IsFloor && c5x2.TileFormationModifiers.c(2L))
							{
								c5x c5x3 = vq.a("Floor\\Meta\\UntraversableTile", this.b.Zone, new bt4(this.b.Area.y8(), new Vector3((float)j, (float)k, 0f)), false);
								if (c5x3 != null)
								{
									c5x3.TileFormationModifiers = new bjp(128L);
									break;
								}
								break;
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001D80 RID: 7552
		public cnk a;

		// Token: 0x04001D81 RID: 7553
		public c5x b;

		// Token: 0x04001D82 RID: 7554
		public ar7 c;
	}
}
