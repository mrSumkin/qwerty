using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000943 RID: 2371
[eiz("XPBLMCA")]
[Serializable]
public sealed class b91 : bdw, ISerializable
{
	// Token: 0x06003A02 RID: 14850 RVA: 0x00157110 File Offset: 0x00155310
	private b91(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x00157118 File Offset: 0x00155318
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x0015711C File Offset: 0x0015531C
	public b91()
	{
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x00157128 File Offset: 0x00155328
	public void av(c1a A_0, cyt A_1)
	{
		Random random = new Random();
		foreach (aud aud in A_0.Areas)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null)
				{
					if (c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.f9 || c5x.h.b.aa().FactionId == asp.a3))
					{
						c5x.w();
						c5x.an();
					}
					else
					{
						if (c5x.o.b != null && c5x.o.b.a.Contains("xpbl_srob"))
						{
							string text;
							if (random.Next(0, 101) > 60)
							{
								text = "Objects\\Obstacles\\xpbl_LemuriaArmySkeletons";
							}
							else
							{
								text = "Objects\\Obstacles\\xpbl_LemuriaCivilSkeletons";
							}
							c5x.o.b.a = text;
							c5x.o.b.b = this.a(text, random);
							c7j c7j = c5x.GetAspect<bim>() as c7j;
							if (c7j == null)
							{
								continue;
							}
							using (List<coh>.Enumerator enumerator3 = c7j.ItemContainer.z2().GetEnumerator())
							{
								while (enumerator3.MoveNext())
								{
									coh coh = enumerator3.Current;
									if (coh.Definition != null && coh.Definition.bi() != a0.c)
									{
										c7j.ItemContainer.z5(coh);
										break;
									}
								}
								continue;
							}
						}
						if (c5x.qe() == new Guid("65b8f7d7-bdcf-4cd9-83ab-c60922adf7fe"))
						{
							c5x.ae = new float?((float)1);
							c5x.TileFormationModifiers = new bjp(new byte[]
							{
								1
							});
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x001573AC File Offset: 0x001555AC
	private Point a(string A_0, Random A_1)
	{
		List<Point> list = new List<Point>
		{
			new Point(6, 0),
			new Point(7, 0),
			new Point(12, 0),
			new Point(13, 0),
			new Point(18, 0),
			new Point(19, 0),
			new Point(23, 0),
			new Point(5, 1),
			new Point(6, 1),
			new Point(10, 1),
			new Point(11, 1),
			new Point(12, 1),
			new Point(20, 1),
			new Point(21, 1),
			new Point(22, 1)
		};
		List<Point> list2 = new List<Point>
		{
			new Point(14, 0),
			new Point(15, 0),
			new Point(16, 0),
			new Point(17, 0),
			new Point(0, 1)
		};
		Point result;
		if (A_0.Contains("ArmySkeletons"))
		{
			result = list2[A_1.Next(0, list2.Count)];
		}
		else
		{
			result = list[A_1.Next(0, list.Count)];
		}
		return result;
	}
}
