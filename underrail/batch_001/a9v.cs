using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000983 RID: 2435
[eiz("TLIBT")]
[Serializable]
public sealed class a9v : bdw, ISerializable
{
	// Token: 0x06003B07 RID: 15111 RVA: 0x0015E2D0 File Offset: 0x0015C4D0
	private a9v(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B08 RID: 15112 RVA: 0x0015E2D8 File Offset: 0x0015C4D8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B09 RID: 15113 RVA: 0x0015E2DC File Offset: 0x0015C4DC
	public a9v()
	{
	}

	// Token: 0x06003B0A RID: 15114 RVA: 0x0015E2E8 File Offset: 0x0015C4E8
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-lib");
		if (aud != null)
		{
			for (int i = 22; i <= 24; i++)
			{
				ak1 ak = aud.b(2, i);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.Layer == aju.x)
						{
							c5x.w();
							c5x.an();
						}
					}
				}
			}
			for (int j = 2; j <= 6; j++)
			{
				for (int k = 22; k <= 24; k++)
				{
					ak1 ak2 = aud.b(j, k);
					if (ak2 != null)
					{
						foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.c.Values))
						{
							c5x c5x2 = (c5x)b0b2;
							if (c5x2.Layer == aju.x && c5x2.h.b != null)
							{
								c5x2.h.b.a(null, false);
							}
						}
					}
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-lib_l2") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
