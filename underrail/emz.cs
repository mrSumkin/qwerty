using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000DC5 RID: 3525
[e79("Cv_ElevatorAscends")]
public sealed class emz : dgy
{
	// Token: 0x06004BBB RID: 19387 RVA: 0x0020E07C File Offset: 0x0020C27C
	public emz()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			emz.c c = new emz.c();
			c.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (c.a != null)
			{
				emz.b b = new emz.b();
				b.a = c.a.Area;
				b.b = new List<b0b>();
				if (b.a != null)
				{
					emz.d d = new emz.d();
					d.b = b;
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(emz.a.a.b));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(c.a));
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
					dva3.a(new Func<e6d, bool>(d.b.a));
					array4[num4] = dva3;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(10.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(c.b));
					array5[num5] = dva4;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					d.a = new EntityAspectReference<b0e, bim>(d.b.a, new Guid("40e5f4e1-9429-4702-95a4-c69757eb67a5")).ao();
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(d.a));
					array6[num6] = dva5;
					base.a(array6);
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(emz.a.a.a));
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

	// Token: 0x02000DC6 RID: 3526
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004BBE RID: 19390 RVA: 0x0020E33C File Offset: 0x0020C53C
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x0020E360 File Offset: 0x0020C560
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E7F RID: 7807
		public static readonly emz.a a = new emz.a();

		// Token: 0x04001E80 RID: 7808
		public static Func<e6d, bool> b;

		// Token: 0x04001E81 RID: 7809
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DC7 RID: 3527
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004BC1 RID: 19393 RVA: 0x0020E390 File Offset: 0x0020C590
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(3);
					etz.a(2);
					etz.b(-1);
				}
				c5x.c().a("elevator", false);
				c5x.c().a("elevator", "InstituteElevatorLoop", 1f, c9z.a, true, false);
			}
			return true;
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x0020E428 File Offset: 0x0020C628
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("32bde564-a3aa-40cb-8a5f-0a5f2af3c013"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				c5x.c().a("InstituteElevatorBump");
				c5x.c().a("elevator", false);
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(0);
				}
			}
			return true;
		}

		// Token: 0x04001E82 RID: 7810
		public c5x a;
	}

	// Token: 0x02000DC8 RID: 3528
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004BC4 RID: 19396 RVA: 0x0020E4B0 File Offset: 0x0020C6B0
		internal bool a(e6d A_0)
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
						bpr a_ = new bpr(mj, new Vector3(c5x2.Location.X, c5x2.Location.Y, c5x2.Location.Z + 10f), new float?(1f), null);
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x04001E83 RID: 7811
		public aud a;

		// Token: 0x04001E84 RID: 7812
		public List<b0b> b;
	}

	// Token: 0x02000DC9 RID: 3529
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x06004BC6 RID: 19398 RVA: 0x0020E6D4 File Offset: 0x0020C8D4
		internal bool a(e6d A_0)
		{
			if (this.a != null && !this.a.q())
			{
				this.a.g(true);
				this.a.a(null, null, false, false);
				this.a.g(false);
				this.a.a8().c().a("InstituteElevatorGate");
			}
			bim bim = new EntityAspectReference<bim, bim>(this.b.a, new Guid("22035ad9-0812-408d-af09-02e6a7f58dd3")).ao();
			if (bim != null)
			{
				bim.g(true);
			}
			return true;
		}

		// Token: 0x04001E85 RID: 7813
		public b0e a;

		// Token: 0x04001E86 RID: 7814
		public emz.b b;
	}
}
