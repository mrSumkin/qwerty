using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000DCF RID: 3535
[e79("Dc_ElevatorAscends")]
public sealed class duz : dgy
{
	// Token: 0x06004BD3 RID: 19411 RVA: 0x0020EE10 File Offset: 0x0020D010
	public duz()
	{
		duz.d d = new duz.d();
		d.a = bpo.GetServiceOrThrow<cnk>();
		if (d.a != null && d.a.aqu() != null)
		{
			d.b = (d.a.aqu().v().b() as c5x);
			if (d.b != null)
			{
				duz.c c = new duz.c();
				c.c = d;
				bool value = c.c.a.aqu().r().GetPrimitivePropertyValue<bool>("global_TchortDefeated", new bool?(false)).Value;
				bool value2 = c.c.a.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc_rahmUmbraElevatorEncounter", new bool?(false)).Value;
				bool flag = value && !value2;
				if (flag)
				{
					c.c.a.aqu().r()["loc_dc_rahmUmbraElevatorEncounter"] = true;
				}
				c.a = c.c.b.Area;
				c.b = new List<b0b>();
				if (c.a != null)
				{
					duz.b b = new duz.b();
					b.b = c;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(duz.e.a.a));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("elevatorCamera"));
					array2[num2] = kw;
					base.a(array2);
					if (flag)
					{
						duz.a a = new duz.a();
						foreach (bfc bfc in b.b.c.a.aq0().a())
						{
							if (bfc.Id != null && bfc.Id.StartsWith("dc-", StringComparison.OrdinalIgnoreCase) && !bfc.Id.Equals("dc-lift", StringComparison.OrdinalIgnoreCase))
							{
								b.b.c.a.aqu().a(new bw0(bfc.Id, new cqe(), 1));
							}
						}
						a.d = b.b.a.Zone.g("rahm0");
						a.b = b.b.a.Zone.g("rahm1");
						a.c = b.b.a.Zone.g("rahm2");
						a.a = vq.a("creature\\characters\\RahmUmbra", a.d, true);
						a.a.ae = new float?(0f);
						if (a.a != null)
						{
							a.a.h.b.aa().Offense.a(WeaponKey.Primary);
							btm[] array3 = new btm[1];
							int num3 = 0;
							c6w c6w = new c6w();
							c6w.a(new ar7(a.a));
							c6w.IsAsync = true;
							c6w.a = new Func<auv>(a.a);
							array3[num3] = c6w;
							base.a(array3);
						}
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					b.a = new EntityAspectReference<b0e, bim>(b.b.a, new Guid("1d126757-20f1-4fbc-89d6-b51fb843b45b")).ao();
					if (b.a != null && b.a.q())
					{
						btm[] array4 = new btm[1];
						int num4 = 0;
						c6w c6w2 = new c6w();
						c6w2.a = new Func<auv>(b.b.a);
						c6w2.a(new ar7(b.b.c.b));
						array4[num4] = c6w2;
						base.a(array4);
					}
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(b.a));
					array5[num5] = dva2;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.b.c.a));
					array6[num6] = dva3;
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(b.b.b));
					array7[num7] = dva4;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(7.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array8[num8] = dky;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(b.b.a));
					array9[num9] = dva5;
					base.a(array9);
					btm[] array10 = new btm[1];
					int num10 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(duz.e.a.b));
					array10[num10] = dva6;
					base.a(array10);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					if (flag)
					{
						btm[] array11 = new btm[1];
						int num11 = 0;
						e2l e2l = new e2l();
						e2l.a("dc-lift");
						e2l.a(new ct3());
						array11[num11] = new ace(e2l);
						base.a(array11);
						base.a(new btm[]
						{
							new di4(new c2w("dc-lift", "FromLift"), false, null, 0, null, true, false, false)
						});
						return;
					}
					base.a(new btm[]
					{
						new di4(new c2w("cv-dc", "FromElevator"), false, null, 0, null, true, false, false)
					});
				}
			}
		}
	}

	// Token: 0x02000DD0 RID: 3536
	[CompilerGenerated]
	[Serializable]
	private new sealed class e
	{
		// Token: 0x06004BD6 RID: 19414 RVA: 0x0020F4C8 File Offset: 0x0020D6C8
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x0020F4EC File Offset: 0x0020D6EC
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E8F RID: 7823
		public static readonly duz.e a = new duz.e();

		// Token: 0x04001E90 RID: 7824
		public static Func<e6d, bool> b;

		// Token: 0x04001E91 RID: 7825
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DD1 RID: 3537
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004BD9 RID: 19417 RVA: 0x0020F51C File Offset: 0x0020D71C
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("InstituteElevatorBump");
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x04001E92 RID: 7826
		public cnk a;

		// Token: 0x04001E93 RID: 7827
		public c5x b;
	}

	// Token: 0x02000DD2 RID: 3538
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004BDB RID: 19419 RVA: 0x0020F5A4 File Offset: 0x0020D7A4
		internal auv a()
		{
			clw clw = new clw();
			clw.a(new e6z(this.a));
			clw.a(false);
			clw.a(Axis.Y);
			clw.a().Add(new Point(8, 7));
			clw.a().Add(new Point(9, 7));
			return clw;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x0020F5FC File Offset: 0x0020D7FC
		internal bool b(e6d A_0)
		{
			for (int i = 7; i <= 10; i++)
			{
				for (int j = 4; j <= 7; j++)
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
					c5x c5x2 = (c5x)b0b2;
					mj mj = c5x2.GetAspect<mj>();
					if (mj == null)
					{
						bpu bpu = new bpu(c5x2);
						bpu.a(1f);
						bpu.b(1f);
						c5x2.SetAspect<bpu>(bpu);
						mj = new mj(c5x2, bpu);
						c5x2.SetAspect<mj>(mj);
					}
					if (mj != null)
					{
						bpr a_ = new bpr(mj, new Vector3(c5x2.Location.X, c5x2.Location.Y, c5x2.Location.Z + 5f), new float?(1f), null);
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x0020F814 File Offset: 0x0020DA14
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), this.c.b.Area).ao() as c5x;
			c5x a_ = new ar7(new Guid("19d52f60-c056-4216-9e76-8abd9da6ec79"), this.c.b.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("elevator", false);
			}
			foreach (b0b b0b in this.b)
			{
				c5x c5x2 = (c5x)b0b;
				if (c5x2.h.b != null)
				{
					if (!c5x2.IsPlayer)
					{
						c5x2.h.b.a(null, false);
					}
				}
				else
				{
					c5x2.w();
					c5x2.an();
				}
			}
			this.c.a.aqu().r()["loc_dc_travelling"] = true;
			this.c.a.aqu().r()["loc_dc_elevator_position"] = 1;
			this.c.a.aqu().r()["loc_dc_elevator_target"] = 1;
			this.c.a.aqu().r()["loc_dc_elevatorStage"] = afi.a;
			afi.a(a_, afi.a);
			return true;
		}

		// Token: 0x04001E94 RID: 7828
		public aud a;

		// Token: 0x04001E95 RID: 7829
		public List<b0b> b;

		// Token: 0x04001E96 RID: 7830
		public duz.d c;
	}

	// Token: 0x02000DD3 RID: 3539
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004BDF RID: 19423 RVA: 0x0020F9C4 File Offset: 0x0020DBC4
		internal bool a(e6d A_0)
		{
			if (this.a != null && this.a.q())
			{
				this.a.g(true);
				this.a.a(null, null, false, false);
				this.a.g(false);
				this.a.a8().c().a("InstituteElevatorGate");
			}
			bim bim = new EntityAspectReference<bim, bim>(this.b.a, new Guid("41282c44-b4c4-4c87-9f2c-8d2a60e847b1")).ao();
			if (bim != null)
			{
				bim.g(false);
			}
			return true;
		}

		// Token: 0x04001E97 RID: 7831
		public b0e a;

		// Token: 0x04001E98 RID: 7832
		public duz.c b;
	}

	// Token: 0x02000DD4 RID: 3540
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BE1 RID: 19425 RVA: 0x0020FA6C File Offset: 0x0020DC6C
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			awx.ad().Add(new bm3(6000));
			awx.ad().Add(new a8v(this.a, this.b.Location));
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportExit"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new bm3(150));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.a);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(100));
			awx.ad().Add(new djk(this.a.k.b, this.c.Tile));
			List<auv> list3 = awx.ad();
			a4s a4s2 = new a4s(new bfq("TeleportEnter"), null, null, null);
			a4s2.b(new ar7(this.a));
			list3.Add(a4s2);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new e4t(this.a.h.b, CharacterState.Custom3, cux.j, 0, null, 1));
			List<auv> list4 = awx.ad();
			ad6 ad2 = new ad6(this.a);
			ad2.b(1.0);
			ad2.c(0.0);
			ad2.a(0.005);
			list4.Add(ad2);
			awx.ad().Add(new bm3(250));
			awx.ad().Add(new a8v(this.a, this.d.Location));
			awx.ad().Add(new c7(this.a, true, true, true, false));
			return awx;
		}

		// Token: 0x04001E99 RID: 7833
		public c5x a;

		// Token: 0x04001E9A RID: 7834
		public csd b;

		// Token: 0x04001E9B RID: 7835
		public csd c;

		// Token: 0x04001E9C RID: 7836
		public csd d;
	}
}
