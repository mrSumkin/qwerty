using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A81 RID: 2689
[eiz("TCHTSEJ")]
[Serializable]
public sealed class ep : cze, ISerializable
{
	// Token: 0x06003F45 RID: 16197 RVA: 0x0017F1BC File Offset: 0x0017D3BC
	private ep(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x0017F1C8 File Offset: 0x0017D3C8
	public ep()
	{
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x0017F1D4 File Offset: 0x0017D3D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.o.b != null && c5x.s.b != null)
		{
			d60 d = c5x.a();
			if (d != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"holeWall"
				})) as c5x;
				if (c5x2 != null && (double)Math.Abs(c5x2.Location.Z) <= 0.1)
				{
					foreach (e36 e in Enumerable.ToList<e36>(c5x2.Zone.ActionManager.g8()))
					{
						dtb dtb = e.a as dtb;
						if (dtb != null && dtb.w() == "lift")
						{
							dtb.j();
						}
					}
					c5x c5x3 = new ar7(new Guid("0cbacbc3-9d09-4f84-937c-66ab74d5ad8c"), A_0.Area).ao() as c5x;
					if (c5x3 != null)
					{
						c5x3.c().a("elevator", false);
						etz etz = c5x3.o.b as etz;
						if (etz != null)
						{
							etz.c(1);
						}
					}
					ps service = bpo.GetService<ps>();
					if (service != null)
					{
						service.ane(2000, null, null, null, null, null);
					}
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
					{
						c5x c5x4 = serviceOrThrow.aqu().v().b() as c5x;
						if (c5x4 != null)
						{
							c5x4.c().a("EarthquakeShort");
							c5x4.c().a("InstituteElevatorCrashes");
						}
					}
					c5x.o.b.d = null;
					c5x.Location = new Vector3(c5x.Location.X, c5x.Location.Y, c5x2.Location.Z);
					c5x.ah();
					c5x.s.b.g(true);
					c5x.RemoveAspect<t6>();
					c5x c5x5 = new ar7(new Guid("eb67cc27-26f0-4b49-9a0d-f56cdebafc25"), c5x.Area).ao() as c5x;
					if (c5x5 != null && c5x5.s.b != null)
					{
						c5x5.s.b.g(true);
					}
				}
			}
		}
	}
}
