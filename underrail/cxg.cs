using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000CB6 RID: 3254
[e79("Xpbl_PlayerMutantSailsForBlackSea")]
public sealed class cxg : dgy
{
	// Token: 0x0600494F RID: 18767 RVA: 0x001E5DB0 File Offset: 0x001E3FB0
	public cxg()
	{
		cxg.a a = new cxg.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			cxg.b b = new cxg.b();
			b.b = a;
			bool value = b.b.a.aqu().r().GetPrimitivePropertyValue<bool>("//TODO", new bool?(false)).Value;
			b.a = (b.b.a.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.a.i.b.a(true, false);
				if (b.a.Area != null)
				{
					b.b.a.aqu().r()["PlayerMutantWentToMutieRefuge"] = true;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(cxg.c.a.a));
					array[num] = dva;
					base.a(array);
					base.a(new btm[]
					{
						new di4(new c2w("cvw37", "mutantShipLeavesCutscene"), true, new bool?(false), 0, null, false, false, true)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("cvw37", new Vector3(51f, 14f, 0f)));
					kw.a(true);
					kw.IsAsync = false;
					array2[num2] = kw;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(b.b.a));
					array3[num3] = dva2;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array4[num4] = c8s;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.b.h));
					array5[num5] = dva3;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.75))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(b.b.f));
					array6[num6] = dva4;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(b.b.d));
					array7[num7] = dva5;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(b.b.b));
					array8[num8] = dva6;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_c3", "mutantShipLeavesCutscene"), true, new bool?(false), 0, null, false, false, true)
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4("xpbl_c3", new Vector3(15f, 32f, 0f)));
					kw2.a(true);
					kw2.IsAsync = false;
					array9[num9] = kw2;
					base.a(array9);
					btm[] array10 = new btm[1];
					int num10 = 0;
					dva dva7 = new dva(null, null, null, null, null);
					dva7.a(new Func<e6d, bool>(b.a));
					array10[num10] = dva7;
					base.a(array10);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					c8s c8s2 = new c8s();
					c8s2.a(0.2f);
					array11[num11] = c8s2;
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					kw kw3 = new kw();
					kw3.a(new bt4("xpbl_c3", new Vector3(10f, 7f, 0f)));
					kw3.a(new float?(3.5f));
					kw3.IsAsync = true;
					array12[num12] = kw3;
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.5))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array13[num13] = dky;
					base.a(array13);
					btm[] array14 = new btm[1];
					int num14 = 0;
					dva dva8 = new dva(null, null, null, null, null);
					dva8.a(new Func<e6d, bool>(b.b.g));
					array14[num14] = dva8;
					base.a(array14);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					e2l e2l = new e2l();
					e2l.a("xpbl_b6");
					e2l.a(new cbu());
					array15[num15] = new ace(e2l);
					base.a(array15);
					if (!b.b.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirill_dead", new bool?(false)).Value)
					{
						btm[] array16 = new btm[1];
						int num16 = 0;
						e2l e2l2 = new e2l();
						e2l2.a("xpbl_b7");
						e2l2.a(new a8d());
						array16[num16] = new ace(e2l2);
						base.a(array16);
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_b6", "playerMutantDock"), false, null, 0, null, true, false, true)
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						return;
					}
					base.a(new btm[]
					{
						new di4(new c2w("xpbl_b6", "playerMutantDock"), true, new bool?(false), 0, null, true, false, true)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.g), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.f), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new ace(new dom())
					});
				}
			}
		}
	}

	// Token: 0x02000CB7 RID: 3255
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004952 RID: 18770 RVA: 0x001E6684 File Offset: 0x001E4884
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001D04 RID: 7428
		public static readonly cxg.c a = new cxg.c();

		// Token: 0x04001D05 RID: 7429
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000CB8 RID: 3256
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004954 RID: 18772 RVA: 0x001E66B4 File Offset: 0x001E48B4
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(aju.a, new Guid("c05184d5-4118-4547-abad-f3ff3d8a9180"), new Guid("d79316a6-a29c-4823-abec-e9ce2df7a62f"), bl1.a).ao() as c5x;
			c5x.ae = new float?(0f);
			c5x.Location = new Vector3(51f, 14f, 0f);
			c5x.ah();
			c5x c5x2 = new ar7(new Guid("2f152fc3-32f8-465d-bde1-14c68707b0c9"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.an();
			}
			return true;
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x001E6768 File Offset: 0x001E4968
		internal bool h(e6d A_0)
		{
			foreach (b0b b0b in this.a.aqw().a().ab4(new string[]
			{
				"cutsceneSplash"
			}))
			{
				t6 aspect = ((c5x)b0b).GetAspect<t6>();
				if (aspect != null)
				{
					aspect.a(true);
				}
			}
			return true;
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x001E67F0 File Offset: 0x001E49F0
		internal bool f(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("9a16193b-81ef-4b98-bcd7-73e1a293dc4a"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("0f9894de-95ed-44ce-b752-dfa05c11cc3d"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("10841f90-1157-4944-beee-5564f653e2fe"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			dtb dtb = new dtb();
			dtb dtb2 = new dtb();
			dtb dtb3 = new dtb();
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				c5x2.c().a(Guid.NewGuid().ToString(), "ManholeOpen", 1f, c9z.a, false, false);
				c5x2.c().a(Guid.NewGuid().ToString(), "WaterfallLoop", 0.8f, c9z.a, true, false);
				for (int i = 0; i <= 30; i++)
				{
					dtb.ad().Add(new a8v(c5x, new Vector3(c5x.Location.X, c5x.Location.Y, c5x.Location.Z - (float)i / 20f)));
					dtb2.ad().Add(new a8v(c5x2, new Vector3(c5x2.Location.X, c5x2.Location.Y, c5x2.Location.Z - (float)i / 20f)));
					dtb3.ad().Add(new a8v(c5x3, new Vector3(c5x3.Location.X, c5x3.Location.Y, c5x3.Location.Z - (float)i / 20f)));
					dtb.ad().Add(new bm3(100));
					dtb2.ad().Add(new bm3(100));
					dtb3.ad().Add(new bm3(100));
				}
				c5x.i.b.b(dtb, atp.a);
				c5x2.i.b.b(dtb2, atp.a);
				c5x3.i.b.b(dtb3, atp.a);
			}
			c5x c5x4 = new ar7(new Guid("5c3e12eb-d684-4f3b-85ca-0cd6b740aff7"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("0f9e2052-3e6b-456f-99c6-ecd7737d2137"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x6 = new ar7(new Guid("43d0161b-1075-4656-8b87-ef02bae2decf"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x7 = new ar7(new Guid("fca20649-4187-4cca-9a38-43cb43831824"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x8 = new ar7(new Guid("94c69ef9-9382-4f66-ab0e-6eecc661dccf"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x9 = new ar7(new Guid("c0de2dde-642e-43a3-a6ec-c6ee5a8936ec"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			if (c5x4 != null)
			{
				c5x4.an();
			}
			if (c5x5 != null)
			{
				c5x5.an();
			}
			if (c5x6 != null)
			{
				c5x6.an();
			}
			if (c5x7 != null)
			{
				c5x7.an();
			}
			if (c5x8 != null)
			{
				c5x8.an();
			}
			if (c5x9 != null)
			{
				c5x9.an();
			}
			return true;
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x001E6C34 File Offset: 0x001E4E34
		internal bool d(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("0f9894de-95ed-44ce-b752-dfa05c11cc3d"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a(Guid.NewGuid().ToString(), "WaterfallLoop", 0.8f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x001E6CB0 File Offset: 0x001E4EB0
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in this.a.aqw().a().ab4(new string[]
			{
				"cutsceneSplash"
			}))
			{
				t6 aspect = ((c5x)b0b).GetAspect<t6>();
				if (aspect != null)
				{
					aspect.a(false);
				}
			}
			c5x c5x = new ar7(new Guid("9a16193b-81ef-4b98-bcd7-73e1a293dc4a"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("0f9894de-95ed-44ce-b752-dfa05c11cc3d"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("10841f90-1157-4944-beee-5564f653e2fe"), this.a.aqw().n(this.a.aqw().y8())).ao() as c5x;
			if (c5x != null && c5x2 != null && c5x3 != null)
			{
				c5x.ae = new float?(0f);
				c5x2.ae = new float?(0f);
				c5x3.ae = new float?(0f);
			}
			return true;
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x001E6E2C File Offset: 0x001E502C
		internal bool c(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_c3_l4") + ".uzl");
			this.a.aqw().a(a_, 1, null);
			return true;
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001E6E6C File Offset: 0x001E506C
		internal bool e(e6d A_0)
		{
			foreach (b0b b0b in this.a.aqw().a().ab4(new string[]
			{
				"cutsceneShipPart"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.j.b != null && c5x.i.b != null)
				{
					dtb dtb = new dtb();
					List<auv> list = dtb.ad();
					bpr bpr = new bpr(c5x.j.b, c5x.Location + new Vector3(0f, -15f, 0f), new float?(1.6f), null);
					bpr.b(false);
					list.Add(bpr);
					c5x.i.b.b(dtb, atp.a);
				}
			}
			return true;
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x001E6F68 File Offset: 0x001E5168
		internal bool g(e6d A_0)
		{
			foreach (b0b b0b in this.a.aqw().a().ab4(new string[]
			{
				"cutsceneShipPart"
			}))
			{
				c5x c5x = (c5x)b0b;
				c5x.w();
				c5x.an();
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001D06 RID: 7430
		public cnk a;
	}

	// Token: 0x02000CB9 RID: 3257
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600495D RID: 18781 RVA: 0x001E7004 File Offset: 0x001E5204
		internal bool a(e6d A_0)
		{
			this.a = (this.b.a.aqu().v().b() as c5x);
			foreach (string a_ in Enumerable.ToList<string>(this.a.c().e().Keys))
			{
				this.a.c().a(a_, false);
			}
			this.a.ae = new float?(0f);
			this.a.Location = new Vector3(3f, 25f, 0f);
			this.a.ah();
			return true;
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x001E70E4 File Offset: 0x001E52E4
		internal bool c(e6d A_0)
		{
			this.a = (this.b.a.aqu().v().b() as c5x);
			this.a.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x001E7124 File Offset: 0x001E5324
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x001E7134 File Offset: 0x001E5334
		internal bool g(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x001E7144 File Offset: 0x001E5344
		internal bool f(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x001E7154 File Offset: 0x001E5354
		internal bool e(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x001E7164 File Offset: 0x001E5364
		internal bool d(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x04001D07 RID: 7431
		public c5x a;

		// Token: 0x04001D08 RID: 7432
		public cxg.a b;
	}
}
