using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B11 RID: 2833
[eiz("XPBLSLTWD")]
[Serializable]
public sealed class a6x : cze, ISerializable
{
	// Token: 0x06004184 RID: 16772 RVA: 0x00191A5C File Offset: 0x0018FC5C
	private a6x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004185 RID: 16773 RVA: 0x00191A68 File Offset: 0x0018FC68
	public a6x()
	{
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x00191A74 File Offset: 0x0018FC74
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			Point point = c5x.aj().a();
			HashSet<c5x> hashSet = new HashSet<c5x>();
			bool flag = false;
			for (int i = point.X - 1; i <= point.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point.Y + 1; j++)
				{
					ak1 ak = c5x.Area.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x2 = (c5x)b0b;
							if (!hashSet.Contains(c5x2))
							{
								hashSet.Add(c5x2);
								if (c5x2.Layer == aju.x && c5x2.o.b is a9g && c5x2.a("LemurianThinWallDestructionEdge"))
								{
									c5x2.RemoveAspect<e3l>();
									flag = true;
									c5x2.o.b.a = "Walls\\xpbl_LemuriaLowerRubble";
									if (c5x2.Location.Y < c5x.Location.Y)
									{
										c5x2.o.b.b = new Point(10 + cuo.a.Next(2), 0);
									}
									else if (c5x2.Location.Y > c5x.Location.Y)
									{
										c5x2.o.b.b = new Point(8 + cuo.a.Next(2), 0);
									}
									else if (c5x2.Location.X < c5x.Location.X)
									{
										c5x2.o.b.b = new Point(1 + cuo.a.Next(2), 0);
									}
									else if (c5x2.Location.X > c5x.Location.X)
									{
										c5x2.o.b.b = new Point((cuo.a.NextDouble() < 0.5) ? 0 : 3, 0);
									}
									this.a(c5x2.Area, c5x2.Location.a());
								}
							}
						}
					}
				}
			}
			if (flag)
			{
				this.a(c5x.Area, point);
			}
		}
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x00191D3C File Offset: 0x0018FF3C
	private void a(aud A_0, Point A_1)
	{
		c5x c5x = new c5x();
		c5x.Location = A_1.a();
		c5x.Size = new Vector3(0.1f, 0.1f, 0.1f);
		c5x.Layer = 1;
		c5x.IsGround = true;
		c5x.SetAspect<cd0>(new cd0(c5x)
		{
			a = "Walls\\xpbl_LemuriaLowerGroundRubble",
			b = new Point(cuo.a.Next(8), 0)
		});
		A_0.a(c5x);
	}
}
