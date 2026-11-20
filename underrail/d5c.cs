using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000A62 RID: 2658
[eiz("RGGSJ")]
[Serializable]
public sealed class d5c : cze, ISerializable
{
	// Token: 0x06003ECC RID: 16076 RVA: 0x0017B408 File Offset: 0x00179608
	private d5c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003ECD RID: 16077 RVA: 0x0017B414 File Offset: 0x00179614
	public d5c()
	{
	}

	// Token: 0x06003ECE RID: 16078 RVA: 0x0017B420 File Offset: 0x00179620
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a != null && c5x.p.b.a.Count >= 3)
		{
			c5x.p.b.a[0].b = new Point(c5x.p.b.a[0].b.X, 0);
			c5x.p.b.a[1].d = null;
			c5x.p.b.a[2].d = null;
			if (c5x.s.b != null)
			{
				c5x.s.b.g(true);
			}
			ah7 ah = c5x.Zone.i("Glittershroom");
			if (ah != null && ah.Layer == c5x.Layer)
			{
				Point point = c5x.aj().a();
				if (c5x.VisualDirection == HorizontalDirection.South)
				{
					point = new Point(point.X, point.Y + 1);
				}
				else if (c5x.VisualDirection == HorizontalDirection.North)
				{
					point = new Point(point.X, point.Y - 1);
				}
				else if (c5x.VisualDirection == HorizontalDirection.East)
				{
					point = new Point(point.X - 1, point.Y);
				}
				else if (c5x.VisualDirection == HorizontalDirection.West)
				{
					point = new Point(point.X + 1, point.Y);
				}
				ak1 ak = c5x.Area.a(point);
				if (ak != null)
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x2 = (c5x)b0b;
						if (c5x2.Layer == ah.Layer && c5x2.IsFloor)
						{
							ah.g().be(c5x2);
							break;
						}
					}
				}
			}
		}
	}
}
