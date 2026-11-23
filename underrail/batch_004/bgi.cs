using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x020020C8 RID: 8392
[bmq("1.1.5.0_SteelTrapDoors", "1.1.5.0", "cc_s1,cc_s4,cc_s5,cc_s6,xpbl_kirillLab2, dun_cc_sBombers", true)]
public sealed class bgi : fg
{
	// Token: 0x0600C7FB RID: 51195 RVA: 0x00467B88 File Offset: 0x00465D88
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (aud aud in A_1.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.o != null && c5x.o.b != null && c5x.o.b.a == "Doors\\MetalTrapDoor" && c5x.s != null && !(c5x.GetAspect<cd0>() is dif) && !(c5x.GetAspect<bim>() is c2r) && c5x.GetAspect<cd0>() != null)
					{
						e4x e4x = new e4x(c5x);
						e4x.a = "Objects\\Utilities\\Steeltrapdoor";
						c2r c2r = new c2r(c5x);
						e68 e = Enumerable.FirstOrDefault<e68>(Enumerable.OfType<e68>(c5x.s.b.s()));
						be6 be = Enumerable.FirstOrDefault<be6>(Enumerable.OfType<be6>(c5x.s.b.s()));
						if (c2r != null)
						{
							c2r.j(true);
							if (e != null)
							{
								c2w c2w = e.Destination.a();
								cnk service = bpo.GetService<cnk>();
								if (service != null && service.aqu() != null)
								{
									c2w.a(service.aqu());
								}
								c2r.b(c2w.b());
								c2r.a(c2w.c());
							}
							else if (be != null)
							{
								c2r.a(be.DestinationWaypoint);
							}
							if (e != null || be != null)
							{
								c5x.VisualDirection = HorizontalDirection.North;
								c2r.a(new List<HorizontalDirection>
								{
									HorizontalDirection.East,
									HorizontalDirection.West,
									HorizontalDirection.North,
									HorizontalDirection.South
								});
								c5x.RemoveAspect<cd0>();
								c5x.RemoveAspect<bim>();
								c5x.Size = new Vector3(0.5f, 0.5f, 0f);
								if (c5x.qe() == new Guid("991348a9-ded0-42c2-92d8-eabbd8a31771") || c5x.qe() == new Guid("c01cf3c4-fc85-4cd4-adb3-5f632cef73c7"))
								{
									c5x.VisualDirection = HorizontalDirection.North;
								}
								c5x.SetAspect<cd0>(e4x);
								c5x.SetAspect<bim>(c2r);
								c5x.Location = new Vector3(c5x.Location.X + 0.25f, c5x.Location.Y + 0.25f, 0f);
								c5x.ah();
								c5x.Layer = aju.x;
							}
						}
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
