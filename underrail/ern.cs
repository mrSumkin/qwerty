using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000AA9 RID: 2729
[eiz("DPBMJ")]
[Serializable]
public sealed class ern : cze, ISerializable
{
	// Token: 0x06003FD9 RID: 16345 RVA: 0x00183848 File Offset: 0x00181A48
	private ern(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x00183854 File Offset: 0x00181A54
	public ern()
	{
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x00183860 File Offset: 0x00181A60
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a != null && c5x.p.b.a.Count >= 2)
		{
			c5x.p.b.a[1].d = new float?(0f);
			c5x.p.b.a[0].b = new Point(1, 0);
			if (c5x.VisualDirection >= HorizontalDirection.North)
			{
				c5x.b("visualPriority_" + c5x.VisualPriority.ToString());
				c5x.VisualPriority = -1;
			}
			c5x.w();
			c5x.TileFormationModifiers.s4(1);
			c5x.z();
			if (c5x.s.b != null)
			{
				c5x.s.b.g(false);
			}
			dm aspect = c5x.GetAspect<dm>();
			if (aspect != null)
			{
				aspect.b(false);
			}
			c5x.c();
			c5x.v.b.a("pick", "MushroomPick", 1f, c9z.a, false, false);
			c5x c5x2 = A_0 as c5x;
			if (c5x2 != null && c5x2.Zone != null && c5x2.IsPlayer)
			{
				cxc.a(eyy.bv);
			}
			d0c aspect2 = c5x.GetAspect<d0c>();
			if (aspect2 != null)
			{
				aspect2.a(new int?(1));
			}
		}
	}
}
