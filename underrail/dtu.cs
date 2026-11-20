using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000DCA RID: 3530
[e79("Dc_ElevatorDescends")]
public sealed class dtu : dgy
{
	// Token: 0x06004BC7 RID: 19399 RVA: 0x0020E770 File Offset: 0x0020C970
	public dtu()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dtu.d d = new dtu.d();
			d.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (d.a != null)
			{
				dtu.c c = new dtu.c();
				c.a = d.a.Area;
				c.b = new List<b0b>();
				if (c.a != null)
				{
					dtu.b b = new dtu.b();
					b.b = c;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(dtu.a.a.b));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(d.a));
					array2[num2] = dva2;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					kw kw = new kw();
					kw.a(new bt4("elevatorCamera"));
					array3[num3] = kw;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.b.a));
					array4[num4] = dva3;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(d.b));
					array5[num5] = dva4;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					b.a = new EntityAspectReference<b0e, bim>(b.b.a, new Guid("1d126757-20f1-4fbc-89d6-b51fb843b45b")).ao();
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(b.a));
					array6[num6] = dva5;
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(dtu.a.a.a));
					array7[num7] = dva6;
					base.a(array7);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DCB RID: 3531
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004BCA RID: 19402 RVA: 0x0020EA30 File Offset: 0x0020CC30
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0020EA54 File Offset: 0x0020CC54
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E87 RID: 7815
		public static readonly dtu.a a = new dtu.a();

		// Token: 0x04001E88 RID: 7816
		public static Func<e6d, bool> b;

		// Token: 0x04001E89 RID: 7817
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DCC RID: 3532
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004BCD RID: 19405 RVA: 0x0020EA84 File Offset: 0x0020CC84
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x0020EAF0 File Offset: 0x0020CCF0
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("657c4c17-fd3a-4d75-b6db-425ebc8a4e65"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("InstituteElevatorBump");
				c5x.c().a("elevator", false);
			}
			return true;
		}

		// Token: 0x04001E8A RID: 7818
		public c5x a;
	}

	// Token: 0x02000DCD RID: 3533
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004BD0 RID: 19408 RVA: 0x0020EB54 File Offset: 0x0020CD54
		internal bool a(e6d A_0)
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
						bpr a_ = new bpr(mj, new Vector3(c5x2.Location.X, c5x2.Location.Y, c5x2.Location.Z - 5f), new float?(1f), null);
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x04001E8B RID: 7819
		public aud a;

		// Token: 0x04001E8C RID: 7820
		public List<b0b> b;
	}

	// Token: 0x02000DCE RID: 3534
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004BD2 RID: 19410 RVA: 0x0020ED74 File Offset: 0x0020CF74
		internal bool a(e6d A_0)
		{
			if (this.a != null && !this.a.q())
			{
				this.a.g(true);
				this.a.a(null, null, false, false);
				this.a.g(false);
				this.a.a8().c().a("InstituteElevatorGate");
			}
			bim bim = new EntityAspectReference<bim, bim>(this.b.a, new Guid("41282c44-b4c4-4c87-9f2c-8d2a60e847b1")).ao();
			if (bim != null)
			{
				bim.g(true);
			}
			return true;
		}

		// Token: 0x04001E8D RID: 7821
		public b0e a;

		// Token: 0x04001E8E RID: 7822
		public dtu.c b;
	}
}
