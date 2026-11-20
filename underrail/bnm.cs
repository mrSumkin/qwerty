using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000DE1 RID: 3553
[e79("Dc_PushArkeCrate")]
public sealed class bnm : dgy
{
	// Token: 0x06004BF8 RID: 19448 RVA: 0x00210E74 File Offset: 0x0020F074
	public bnm()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bnm.b b = new bnm.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null && b.a.Area != null)
			{
				bnm.a a = new bnm.a();
				a.c = b;
				a.a = (new ar7(new Guid("91fd936a-f056-49fa-9d98-a356d3c1544b"), a.c.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("7c348830-e1e2-4f9b-8237-a456b0fa33db"), a.c.a.Area).ao() as c5x);
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
				if (a.a != null)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_dc-pp_ama_pushFromStorage", new bool?(false)).Value)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
					}
					else
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
					}
				}
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000DE2 RID: 3554
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004BFA RID: 19450 RVA: 0x002110C0 File Offset: 0x0020F2C0
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("interfacing\\dc-pp_ama_pushableCrate");
			a.d("interface");
			a.c("Металлический ящик");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001EAA RID: 7850
		public c5x a;
	}

	// Token: 0x02000DE3 RID: 3555
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BFC RID: 19452 RVA: 0x00211110 File Offset: 0x0020F310
		internal bool c(e6d A_0)
		{
			this.a.Location = new Vector3(24f, 23f, 0f);
			this.a.ah();
			a0l.a(this.c.a, "playerPush", true);
			this.c.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00211170 File Offset: 0x0020F370
		internal bool b(e6d A_0)
		{
			this.a.Location = new Vector3(24f, 17f, 0f);
			this.a.ah();
			a0l.a(this.c.a, "playerPush", true);
			this.c.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x002111D0 File Offset: 0x0020F3D0
		internal bool a(e6d A_0)
		{
			this.b.TileFormationModifiers.c();
			this.b.z();
			this.b.o.b.b = new Point(5, 0);
			return true;
		}

		// Token: 0x04001EAB RID: 7851
		public c5x a;

		// Token: 0x04001EAC RID: 7852
		public c5x b;

		// Token: 0x04001EAD RID: 7853
		public bnm.b c;
	}
}
