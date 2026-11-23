using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A93 RID: 2707
[eiz("LUFDGRTJ")]
[Serializable]
public sealed class d4y : cze, ISerializable
{
	// Token: 0x06003F7F RID: 16255 RVA: 0x00181638 File Offset: 0x0017F838
	private d4y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x00181644 File Offset: 0x0017F844
	public d4y()
	{
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x00181650 File Offset: 0x0017F850
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lup_freeDroneBase_gasStarted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lup_freeDroneBase_gasStopped", new bool?(false)).Value)
			{
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in service.ahl())
					{
						if (d4n.b != null && !d4n.b.aa().Dead && !d4n.b.aa().Passive && d4n.b.aa().FactionId == asp.dc && d4n.b.a8() != null && d4n.b.a8().t.b != null)
						{
							d4n.b.a8().t.b.y6().RemoveProperty(ddq.ay);
							d4n.b.a8().t.b.y6().RemoveProperty(ddq.k);
							d4n.b.a8().t.b.y6()[ddq.bm] = true;
							d4n.b.a8().t.b.y6()[ddq.bn] = 5;
							d4n.b.a8().t.b.y6()[ddq.bo] = 3;
						}
					}
				}
				int num = Math.Min(serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lup_freeDroneBase_gasReleaseCounter", new int?(0)).Value + 1, 18);
				serviceOrThrow.aqu().r()["loc_lup_freeDroneBase_gasReleaseCounter"] = num;
				for (int i = 0; i <= num; i++)
				{
					csd csd = A_1.Zone.g("gas" + i.ToString());
					if (csd != null && csd.Tile != null)
					{
						c5x c5x = null;
						foreach (b0b b0b in csd.Tile.c.Values)
						{
							c5x c5x2 = (c5x)b0b;
							if (c5x2.IsFloor && c5x2.Layer == aju.x)
							{
								c5x = c5x2;
								break;
							}
						}
						if (c5x != null)
						{
							dxv dxv = c5x.GetAspect<dxv>();
							if (dxv == null)
							{
								dxv = new dxv(c5x);
								c5x.SetAspect<dxv>(dxv);
							}
							dxv.a("zombieMutagenGas");
							dxv.a(25.0);
							dxv.a(true);
						}
					}
				}
			}
		}
	}
}
