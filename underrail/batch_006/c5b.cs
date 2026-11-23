using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B85 RID: 2949
[eiz("CCG6SB")]
[Serializable]
public sealed class c5b : cze, ISerializable
{
	// Token: 0x0600434A RID: 17226 RVA: 0x001A4D68 File Offset: 0x001A2F68
	private c5b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600434B RID: 17227 RVA: 0x001A4D74 File Offset: 0x001A2F74
	public c5b()
	{
	}

	// Token: 0x0600434C RID: 17228 RVA: 0x001A4D80 File Offset: 0x001A2F80
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			a3f aspect = c5x.GetAspect<a3f>();
			if (aspect != null)
			{
				int value = aspect.a().GetPrimitivePropertyValue<int>("MaxBeetles", new int?(1)).Value;
				int num = aspect.a().GetPrimitivePropertyValue<int>("BeetlesSpawned", new int?(0)).Value;
				if (num < value)
				{
					List<csd> list = new List<csd>();
					foreach (csd csd in A_1.Zone.Waypoints)
					{
						if (csd.Name != "entrance" && csd.Tile != null && !csd.Tile.Formation.b(128L) && csd.Tile.f(null) == 0L)
						{
							list.Add(csd);
						}
					}
					if (list.Count > 0)
					{
						csd a_ = list[cuo.a.Next(list.Count)];
						num++;
						aspect.a()["BeetlesSpawned"] = num;
						c5x c5x2 = vq.a("background\\bridgeColumn", a_, false);
						if (c5x2 != null)
						{
							c5x2.VisualPriority = 1;
							c5x2.TileFormationModifiers = new bjp(128L);
							c5x2.ah();
							vq.a("creatures\\psiBeetle", a_, false);
						}
					}
				}
			}
		}
	}
}
