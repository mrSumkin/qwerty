using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Playfield.References;

// Token: 0x02000DF9 RID: 3577
[e79("Tch_ElevatorDescends")]
public sealed class cwe : dgy
{
	// Token: 0x06004C26 RID: 19494 RVA: 0x00212CAC File Offset: 0x00210EAC
	public cwe()
	{
		cwe.b b = new cwe.b();
		b.a = bpo.GetServiceOrThrow<cnk>();
		if (b.a != null && b.a.aqu() != null)
		{
			cwe.c c = new cwe.c();
			c.b = b;
			c.a = (c.b.a.aqu().v().b() as c5x);
			if (c.a != null)
			{
				cwe.a a = new cwe.a();
				a.c = c;
				a.a = a.c.a.Area;
				a.b = new List<b0b>();
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(cwe.d.a.b));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("eideinElevator"));
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c6w c6w = new c6w();
					c6w.a = new Func<auv>(a.a);
					c6w.a(new ar7(a.c.a));
					array3[num3] = c6w;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.b));
					array4[num4] = dva2;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(a.c.a));
					array5[num5] = dva3;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(a.a));
					array6[num6] = dva4;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array7[num7] = dky;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(a.c));
					array8[num8] = dva5;
					base.a(array8);
					btm[] array9 = new btm[1];
					int num9 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(cwe.d.a.a));
					array9[num9] = dva6;
					base.a(array9);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					e2l e2l = new e2l();
					e2l.a("tch-dclift");
					e2l.a(new bpm());
					array10[num10] = new ace(e2l);
					base.a(array10);
					btm[] array11 = new btm[1];
					int num11 = 0;
					dva dva7 = new dva(null, null, null, null, null);
					dva7.a(new Func<e6d, bool>(a.c.b.a));
					array11[num11] = dva7;
					base.a(array11);
					base.a(new btm[]
					{
						new di4(new c2w("tch-dclift", "FromLift"), false, null, 0, null, true, false, false)
					});
				}
			}
		}
	}

	// Token: 0x02000DFA RID: 3578
	[CompilerGenerated]
	[Serializable]
	private new sealed class d
	{
		// Token: 0x06004C29 RID: 19497 RVA: 0x00213090 File Offset: 0x00211290
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x002130B4 File Offset: 0x002112B4
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001EC5 RID: 7877
		public static readonly cwe.d a = new cwe.d();

		// Token: 0x04001EC6 RID: 7878
		public static Func<e6d, bool> b;

		// Token: 0x04001EC7 RID: 7879
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DFB RID: 3579
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C2C RID: 19500 RVA: 0x002130E4 File Offset: 0x002112E4
		internal bool a(e6d A_0)
		{
			this.a.aqz().atc("tch_escapeTheInstitute", true);
			this.a.aqz().atd("tch_pr_clearLunatics", true);
			this.a.aqz().atd("tch_pr_findMissingEfreitor", true);
			this.a.aqz().atd("tch_pr_killMateo", true);
			this.a.aqz().atd("tch_pr_killMateoAndBringHead", true);
			this.a.aqz().atd("tch_pr_trackDownNevil", true);
			this.a.aqz().atd("tch_ch_testChemWeapon", true);
			this.a.aqz().atd("tch_ch_findResearchData", true);
			this.a.aqz().atd("tch_ch_alcoholTesting", true);
			this.a.aqz().atd("tch_gen_captureBeetle", true);
			this.a.aqz().atd("tch_gen_investigateForsakenIsland", true);
			this.a.aqz().atd("tch_gen_findHealth", true);
			this.a.aqz().atd("tch_phy_locatePavel", true);
			this.a.aqz().atd("tch_phy_plantTRayFirst", true);
			this.a.aqz().atd("tch_phy_plantTRaySecond", true);
			this.a.aqz().atd("tch_talkToLydia", true);
			this.a.aqz().atd("tch_meetEidein", true);
			this.a.aqz().atd("tch_joinInvestigation", true);
			this.a.aqz().atd("tch_joinPreservation", true);
			this.a.aqz().atc("infiltrateChurchOfTchort", true);
			return true;
		}

		// Token: 0x04001EC8 RID: 7880
		public cnk a;
	}

	// Token: 0x02000DFC RID: 3580
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004C2E RID: 19502 RVA: 0x002132CC File Offset: 0x002114CC
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("4a06d414-a0a5-4f6e-a0c4-0de681b2d2c8"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(3);
					etz.a(2);
					etz.b(-1);
				}
				c5x.c().a("InstituteElevatorBump");
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x04001EC9 RID: 7881
		public c5x a;

		// Token: 0x04001ECA RID: 7882
		public cwe.b b;
	}

	// Token: 0x02000DFD RID: 3581
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C30 RID: 19504 RVA: 0x00213380 File Offset: 0x00211580
		internal auv a()
		{
			clw clw = new clw();
			clw.a(new e6z(this.a));
			clw.a(false);
			clw.a(Axis.Y);
			clw.a().Add(new Point(20, 21));
			clw.a().Add(new Point(21, 21));
			return clw;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x002133DC File Offset: 0x002115DC
		internal bool b(e6d A_0)
		{
			b0e b0e = new EntityAspectReference<b0e, bim>(this.a, new Guid("0829362c-c688-4644-9534-4e2e2b838dec")).ao();
			if (b0e != null)
			{
				b0e.g(true);
				b0e.a(null, null, false, false);
				b0e.g(false);
				b0e.a8().c().a("InstituteElevatorGate");
			}
			bim bim = new EntityAspectReference<bim, bim>(this.a, new Guid("055f7a24-b67e-45fd-a41e-a1532c2d59c0")).ao();
			if (bim != null)
			{
				bim.g(false);
			}
			return true;
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00213464 File Offset: 0x00211664
		internal bool a(e6d A_0)
		{
			for (int i = 19; i <= 22; i++)
			{
				for (int j = 18; j <= 21; j++)
				{
					ak1 ak = this.a.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in ak.c.Values)
						{
							c5x c5x = (c5x)b0b;
							if (c5x.Layer == aju.x)
							{
								e3l aspect = c5x.GetAspect<e3l>();
								if (aspect == null || (!aspect.a.Contains("liftStatic") && !aspect.a.Contains("lift")))
								{
									if (c5x.GetAspect<mj>() == null)
									{
										bpu bpu = new bpu(c5x);
										bpu.a(1f);
										bpu.b(1f);
										c5x.SetAspect<bpu>(bpu);
										mj aspect2 = new mj(c5x, bpu);
										c5x.SetAspect<mj>(aspect2);
									}
									if (c5x.s.b is c7j)
									{
										c5x.s.b.g(false);
									}
									this.b.Add(c5x);
								}
							}
						}
					}
				}
			}
			d60 addon = this.a.Zone.GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b2 in Enumerable.Union<b0b>(addon.ab4(new string[]
				{
					"lift"
				}), this.b))
				{
					mj aspect3 = b0b2.GetAspect<mj>();
					if (aspect3 != null)
					{
						bpr a_ = new bpr(aspect3, new Vector3(b0b2.Location.X, b0b2.Location.Y, -5f), new float?(1f), null);
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x002136A0 File Offset: 0x002118A0
		internal bool c(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("4a06d414-a0a5-4f6e-a0c4-0de681b2d2c8"), this.c.a.Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("f9d7c7b8-9afd-45c3-b488-e41002788ec9"), this.c.a.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(1);
				}
				c5x.c().a("elevator", false);
			}
			if (c5x2 != null && c5x2.p.b != null)
			{
				foreach (cd0 cd in c5x2.p.b.a)
				{
					cd.b = new Point(0, cd.b.Y);
				}
			}
			foreach (b0b b0b in this.b)
			{
				c5x c5x3 = (c5x)b0b;
				if (c5x3.h.b != null)
				{
					if (!c5x3.IsPlayer)
					{
						c5x3.h.b.a(null, false);
					}
				}
				else
				{
					c5x3.w();
					c5x3.an();
				}
			}
			this.c.b.a.aqu().r()["loc_tch_descended"] = true;
			return true;
		}

		// Token: 0x04001ECB RID: 7883
		public aud a;

		// Token: 0x04001ECC RID: 7884
		public List<b0b> b;

		// Token: 0x04001ECD RID: 7885
		public cwe.c c;
	}
}
