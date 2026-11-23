using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CCF RID: 3279
[e79("Xpbl_ExpeditionReturns")]
public sealed class det : dgy
{
	// Token: 0x0600499D RID: 18845 RVA: 0x001EB70C File Offset: 0x001E990C
	public det()
	{
		det.a a = new det.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			det.b b = new det.b();
			b.c = a;
			b.b = b.c.a.aqu().r().GetPrimitivePropertyValue<bool>("expeditionReturnsWithPlayer", new bool?(false)).Value;
			bool value = b.c.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value;
			bool value2 = b.c.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value;
			b.a = (b.c.a.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.a.i.b.a(true, false);
				if (b.a.Area != null)
				{
					btm[] array = new btm[1];
					int num = 0;
					e2l e2l = new e2l();
					e2l.a("xpbl_cc-dock2");
					e2l.a(new byv());
					array[num] = new ace(e2l);
					base.a(array);
					base.a(new btm[]
					{
						new ace(new e2x())
					});
					base.a(new btm[]
					{
						new ace(new a1b())
					});
					if (!b.b)
					{
						btm[] array2 = new btm[1];
						int num2 = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array2[num2] = dky;
						base.a(array2);
					}
					if (!value && !value2)
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						e2l e2l2 = new e2l();
						e2l2.a("xpbl_cc-dock2");
						e2l2.a(new b10());
						array3[num3] = new ace(e2l2);
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						kw kw = new kw();
						kw.a(new bt4("xpbl_c3", new Vector3(15f, 25f, 0f)));
						kw.a(true);
						kw.IsAsync = false;
						array4[num4] = kw;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(b.a));
						array5[num5] = dva;
						base.a(array5);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.c.b), null, null, null)
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						array6[num6] = c8s;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						kw kw2 = new kw();
						kw2.a(new bt4("xpbl_c3", new Vector3(10f, 7f, 0f)));
						kw2.a(new float?(3.5f));
						kw2.IsAsync = true;
						array7[num7] = kw2;
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						dky dky2 = new dky();
						dky2.a(0.2f);
						dky2.a(false);
						array8[num8] = dky2;
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(b.c.a));
						array9[num9] = dva2;
						base.a(array9);
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					if (b.b)
					{
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_d5", "player_startExpedition"), false, new bool?(false), 0, null, true, false, false)
						});
						return;
					}
					base.a(new btm[]
					{
						new ace(new qj())
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					d6r d6r = new d6r();
					d6r.a(new c88());
					array10[num10] = new ace(d6r);
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.c.c));
					array11[num11] = dva3;
					base.a(array11);
					b.c.a.aqu().r()["npc_xpbl_briggs_arrivedAtDock"] = true;
					if (b.a.h.b.aa().Vehicle != null)
					{
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_c4", "AfterCutscene"), false, null, 0, null, true, false, false)
						});
						return;
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					kw kw3 = new kw();
					kw3.a(new bt4("xpbl_c3", new Vector3(23f, 15f, 0f)));
					kw3.a(true);
					kw3.IsAsync = false;
					array12[num12] = kw3;
					base.a(array12);
					btm[] array13 = new btm[1];
					int num13 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(b.c));
					array13[num13] = dva4;
					base.a(array13);
					btm[] array14 = new btm[1];
					int num14 = 0;
					c8s c8s2 = new c8s();
					c8s2.a(0.2f);
					c8s2.a(false);
					array14[num14] = c8s2;
					base.a(array14);
				}
			}
		}
	}

	// Token: 0x02000CD0 RID: 3280
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600499F RID: 18847 RVA: 0x001EBD08 File Offset: 0x001E9F08
		internal bool b(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_c3_l2") + ".uzl");
			this.a.aqw().a(a_, 1, null);
			return true;
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x001EBD48 File Offset: 0x001E9F48
		internal bool a(e6d A_0)
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

		// Token: 0x060049A1 RID: 18849 RVA: 0x001EBDDC File Offset: 0x001E9FDC
		internal bool c(e6d A_0)
		{
			this.a.aqz().atd("xpbl_heardDockExpedition", true);
			this.a.aqz().atd("xpbl_knowDockExpedition", true);
			this.a.aqz().atd("xpbl_talkWithBriggs", true);
			this.a.aqz().atd("xpbl_proveYourWorthToBriggs", true);
			this.a.aqz().atd("xpbl_joinExpedition", true);
			return true;
		}

		// Token: 0x04001D2A RID: 7466
		public cnk a;
	}

	// Token: 0x02000CD1 RID: 3281
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049A3 RID: 18851 RVA: 0x001EBE6C File Offset: 0x001EA06C
		internal bool a(e6d A_0)
		{
			foreach (string a_ in Enumerable.ToList<string>(this.a.c().e().Keys))
			{
				this.a.c().a(a_, false);
			}
			this.a.ae = new float?(0f);
			this.a.Location = new Vector3(3f, 25f, 0f);
			this.a.ah();
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x001EBF38 File Offset: 0x001EA138
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in this.c.a.aqw().a().ab4(new string[]
			{
				"cutsceneShipPart"
			}))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.a("cutscenePlayer"))
				{
					if (!this.b)
					{
						c5x.w();
						c5x.an();
						continue;
					}
					if (c5x.o.b != null)
					{
						c5x.o.b.a = string.Format("Creatures\\{0}", this.a.h.b.g.a[CharacterState.Idle].b);
					}
				}
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

		// Token: 0x060049A5 RID: 18853 RVA: 0x001EC0C8 File Offset: 0x001EA2C8
		internal bool c(e6d A_0)
		{
			this.c.a.aqu().r()["playerEnteredBlackSea"] = true;
			this.c.a.aqu().b(new dss());
			this.a.ae = null;
			this.a.Location = new Vector3(23f, 15f, 0f);
			this.a.ah();
			return true;
		}

		// Token: 0x04001D2B RID: 7467
		public c5x a;

		// Token: 0x04001D2C RID: 7468
		public bool b;

		// Token: 0x04001D2D RID: 7469
		public det.a c;
	}
}
