using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000982 RID: 2434
[eiz("TWW1TS")]
[Serializable]
public sealed class dy3 : bdw, ISerializable
{
	// Token: 0x06003B03 RID: 15107 RVA: 0x0015E148 File Offset: 0x0015C348
	private dy3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x0015E150 File Offset: 0x0015C350
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x0015E154 File Offset: 0x0015C354
	public dy3()
	{
	}

	// Token: 0x06003B06 RID: 15110 RVA: 0x0015E160 File Offset: 0x0015C360
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-ww1");
		if (aud != null)
		{
			for (int i = 10; i <= 20; i++)
			{
				for (int j = 3; j <= 13; j++)
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
									if (c5x.h.b.aa().FactionId != asp.cc && c5x.h.b.aa().FactionId != asp.cd)
									{
										c5x.h.b.a(null, false);
									}
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
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-ww1_l2") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
