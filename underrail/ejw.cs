using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A63 RID: 2659
[eiz("DGSJ")]
[Serializable]
public sealed class ejw : cze, ISerializable
{
	// Token: 0x06003ECF RID: 16079 RVA: 0x0017B67C File Offset: 0x0017987C
	private ejw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003ED0 RID: 16080 RVA: 0x0017B688 File Offset: 0x00179888
	public ejw()
	{
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x0017B694 File Offset: 0x00179894
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a != null && c5x.p.b.a.Count >= 3)
		{
			c5x.p.b.a[0].b = new Point(c5x.p.b.a[0].b.X, 2);
			c5x.p.b.a[1].d = new float?(0f);
			c5x.p.b.a[2].d = new float?(0f);
			if (c5x.s.b != null)
			{
				c5x.s.b.g(false);
			}
			c5x.c().a("pick", "MushroomPick", 1f, c9z.a, false, false);
			c5x c5x2 = A_0 as c5x;
			if (c5x2 != null && c5x2.Zone != null && c5x2.IsPlayer)
			{
				cxc.a(eyy.bv);
			}
			d0c aspect = c5x.GetAspect<d0c>();
			if (aspect != null)
			{
				aspect.a(new int?(1));
			}
			foreach (ak1 ak in aw1.a(c5x, true))
			{
				foreach (b0b b0b in ak.c.Values)
				{
					c5x c5x3 = (c5x)b0b;
					if (c5x3.Layer == aju.x && c5x3.IsFloor && c5x3.RaysEmitters.Count > 0)
					{
						bsf bsf = c5x3.RaysEmitters[0] as bsf;
						if (bsf != null && bsf.Definition != null && bsf.Definition.Name == "Glittershroom")
						{
							bsf.ig();
							return;
						}
					}
				}
			}
		}
	}
}
