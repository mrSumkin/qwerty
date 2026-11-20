using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000DFE RID: 3582
[e79("Tch_ElevatorArrives")]
public sealed class du3 : dgy
{
	// Token: 0x06004C34 RID: 19508 RVA: 0x00213870 File Offset: 0x00211A70
	public du3()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			du3.b b = new du3.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				du3.a a = new du3.a();
				a.a = b.a.Area;
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(du3.c.a.a));
					array[num] = dva;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					kw kw = new kw();
					kw.a(new bt4("eideinElevator"));
					array2[num2] = kw;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.a));
					array3[num3] = dva2;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(b.a));
					array4[num4] = dva3;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(a.b));
					array5[num5] = dva4;
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(du3.c.a.b));
					array6[num6] = dva5;
					base.a(array6);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000DFF RID: 3583
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004C37 RID: 19511 RVA: 0x00213AC4 File Offset: 0x00211CC4
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00213AE8 File Offset: 0x00211CE8
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001ECE RID: 7886
		public static readonly du3.c a = new du3.c();

		// Token: 0x04001ECF RID: 7887
		public static Func<e6d, bool> b;

		// Token: 0x04001ED0 RID: 7888
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000E00 RID: 3584
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C3A RID: 19514 RVA: 0x00213B18 File Offset: 0x00211D18
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("4a06d414-a0a5-4f6e-a0c4-0de681b2d2c8"), this.a.Area).ao() as c5x;
			if (c5x != null)
			{
				etz etz = c5x.o.b as etz;
				if (etz != null)
				{
					etz.c(1);
				}
				c5x.c().a("elevator", false);
				c5x.c().a("InstituteElevatorBump");
			}
			return true;
		}

		// Token: 0x04001ED1 RID: 7889
		public c5x a;
	}

	// Token: 0x02000E01 RID: 3585
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C3C RID: 19516 RVA: 0x00213BA0 File Offset: 0x00211DA0
		internal bool a(e6d A_0)
		{
			d60 addon = this.a.Zone.GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"lift"
				}))
				{
					mj aspect = b0b.GetAspect<mj>();
					if (aspect != null)
					{
						bpr a_ = new bpr(aspect, new Vector3(b0b.Location.X, b0b.Location.Y, 0f));
						this.a.Zone.ActionManager.g9(a_, atp.a);
					}
				}
			}
			return true;
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00213C68 File Offset: 0x00211E68
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
				bim.g(true);
			}
			return true;
		}

		// Token: 0x04001ED2 RID: 7890
		public aud a;
	}
}
