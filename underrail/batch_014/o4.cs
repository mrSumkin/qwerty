using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200093A RID: 2362
[eiz("TWW4CWTS")]
[Serializable]
public sealed class o4 : bdw, ISerializable
{
	// Token: 0x060039DE RID: 14814 RVA: 0x0015632C File Offset: 0x0015452C
	private o4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039DF RID: 14815 RVA: 0x00156334 File Offset: 0x00154534
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x00156338 File Offset: 0x00154538
	public o4()
	{
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x00156344 File Offset: 0x00154544
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-ww4");
		if (aud != null)
		{
			for (int i = 4; i <= 7; i++)
			{
				for (int j = 30; j <= 33; j++)
				{
					ak1 ak = aud.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x = (c5x)b0b;
							if (c5x.Layer == aju.x)
							{
								if (c5x.h.b != null)
								{
									c5x.h.b.a(null, false);
								}
								else
								{
									c5x.w();
									c5x.an();
								}
							}
						}
					}
				}
			}
			c5x c5x2 = new ar7(new Guid("5618d63f-a838-4e95-9652-c56b24b6ef53"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("82f1e875-70bd-43a2-bc41-c7e55ef67cdb"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("56902fb0-c5d7-45ea-87fe-59bc416bd12e"), aud).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("17433d74-085f-41fb-9f6f-e5a4452bd95c"), aud).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.an();
			}
			if (c5x3 != null)
			{
				c5x3.an();
			}
			if (c5x4 != null)
			{
				c5x4.an();
			}
			if (c5x5 != null)
			{
				c5x5.an();
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-ww4_l3") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
