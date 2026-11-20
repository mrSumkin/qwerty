using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Common;
using Ouroboros.Playfield.References;

// Token: 0x02000DC0 RID: 3520
[e79("Cv_ElevatorDescends")]
public sealed class cbe : dgy
{
	// Token: 0x06004BAE RID: 19374 RVA: 0x0020D6E0 File Offset: 0x0020B8E0
	public cbe()
	{
		cbe.c c = new cbe.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			c.b = (c.a.aqu().v().b() as c5x);
			if (c.b != null)
			{
				cbe.d d = new cbe.d();
				d.c = c;
				d.a = d.c.b.Area;
				d.b = new List<b0b>();
				if (d.a != null)
				{
					cbe.a a = new cbe.a();
					a.b = d;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(cbe.b.a.b));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("elevatorCamera"));
					array2[num2] = kw;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					a.a = new EntityAspectReference<b0e, bim>(a.b.a, new Guid("40e5f4e1-9429-4702-95a4-c69757eb67a5")).ao();
					if (a.a != null && a.a.q())
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						c6w c6w = new c6w();
						c6w.a = new Func<auv>(a.b.a);
						c6w.a(new ar7(a.b.c.b));
						array3[num3] = c6w;
						base.a(array3);
					}
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.a));
					array4[num4] = dva2;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(a.b.c.a));
					array5[num5] = dva3;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(a.b.b));
					array6[num6] = dva4;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(10.0))
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
					dva5.a(new Func<e6d, bool>(a.b.a));
					array8[num8] = dva5;
					base.a(array8);
					btm[] array9 = new btm[1];
					int num9 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(cbe.b.a.a));
					array9[num9] = dva6;
					base.a(array9);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					base.a(new btm[]
					{
						new di4(new c2w("dc-cve", "FromElevator"), false, null, 0, null, true, false, false)
					});
				}
			}
		}
	}

	// Token: 0x02000DC1 RID: 3521
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004BB1 RID: 19377 RVA: 0x0020DAB4 File Offset: 0x0020BCB4
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x0020DAD8 File Offset: 0x0020BCD8
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E75 RID: 7797
		public static readonly cbe.b a = new cbe.b();

		// Token: 0x04001E76 RID: 7798
		public static Func<e6d, bool> b;

		// Token: 0x04001E77 RID: 7799
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DC2 RID: 3522
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004BB4 RID: 19380 RVA: 0x0020DB08 File Offset: 0x0020BD08
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), this.b.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(3);
					etz.a(0);
					etz.b(1);
				}
				c5x.c().a("InstituteElevatorBump");
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x04001E78 RID: 7800
		public cnk a;

		// Token: 0x04001E79 RID: 7801
		public c5x b;
	}

	// Token: 0x02000DC3 RID: 3523
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004BB6 RID: 19382 RVA: 0x0020DBBC File Offset: 0x0020BDBC
		internal auv a()
		{
			clw clw = new clw();
			clw.a(new e6z(this.a));
			clw.a(false);
			clw.a(Axis.Y);
			clw.a().Add(new Point(17, 15));
			clw.a().Add(new Point(18, 15));
			return clw;
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0020DC18 File Offset: 0x0020BE18
		internal bool b(e6d A_0)
		{
			for (int i = 16; i <= 19; i++)
			{
				for (int j = 12; j <= 15; j++)
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
						bpr a_ = new bpr(mj, new Vector3(c5x2.Location.X, c5x2.Location.Y, c5x2.Location.Z - 10f), new float?(1f), null);
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0020DE34 File Offset: 0x0020C034
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), this.c.b.Area).ao() as c5x;
			c5x a_ = new ar7(new Guid("de6dc46a-e4d6-4756-8750-85e25fe8f562"), this.c.b.Area).ao() as c5x;
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
			this.c.a.aqu().r()["loc_dc_elevator_position"] = 0;
			this.c.a.aqu().r()["loc_dc_elevator_target"] = 0;
			this.c.a.aqu().r()["loc_dc_elevatorStage"] = 0;
			afi.a(a_, afi.a);
			return true;
		}

		// Token: 0x04001E7A RID: 7802
		public aud a;

		// Token: 0x04001E7B RID: 7803
		public List<b0b> b;

		// Token: 0x04001E7C RID: 7804
		public cbe.c c;
	}

	// Token: 0x02000DC4 RID: 3524
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BBA RID: 19386 RVA: 0x0020DFE0 File Offset: 0x0020C1E0
		internal bool a(e6d A_0)
		{
			if (this.a != null && this.a.q())
			{
				this.a.g(true);
				this.a.a(null, null, false, false);
				this.a.g(false);
				this.a.a8().c().a("InstituteElevatorGate");
			}
			bim bim = new EntityAspectReference<bim, bim>(this.b.a, new Guid("22035ad9-0812-408d-af09-02e6a7f58dd3")).ao();
			if (bim != null)
			{
				bim.g(false);
			}
			return true;
		}

		// Token: 0x04001E7D RID: 7805
		public b0e a;

		// Token: 0x04001E7E RID: 7806
		public cbe.d b;
	}
}
