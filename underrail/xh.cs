using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000980 RID: 2432
[eiz("TCHWWFS")]
[Serializable]
public sealed class xh : bdw, ISerializable
{
	// Token: 0x06003AFB RID: 15099 RVA: 0x0015DD00 File Offset: 0x0015BF00
	private xh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x0015DD08 File Offset: 0x0015BF08
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x0015DD0C File Offset: 0x0015BF0C
	public xh()
	{
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x0015DD18 File Offset: 0x0015BF18
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-ww5");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("cf4e39f8-bc56-4cf5-8836-cf49e0a510db"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("e1216d75-7323-4d45-bb71-638e5edeb5ef"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("d2779d93-5376-4b24-b1ad-f3f9cebf6f91"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("5eea7624-6f68-4b91-8f54-e6680149e011"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
			}
			if (c5x2 != null)
			{
				c5x2.an();
				c5x2.w();
			}
			if (c5x3 != null)
			{
				c5x3.an();
				c5x3.w();
			}
			if (c5x4 != null)
			{
				c5x4.an();
				c5x4.w();
			}
			for (int i = 8; i <= 17; i++)
			{
				for (int j = 32; j <= 35; j++)
				{
					ak1 ak = aud.b(i, j);
					if (ak != null)
					{
						foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
						{
							c5x c5x5 = (c5x)b0b;
							if (c5x5.Layer == aju.x)
							{
								if (c5x5.h.b != null)
								{
									if (c5x5.h.b.aa().FactionId != asp.cg)
									{
										c5x5.h.b.a(null, false);
									}
								}
								else
								{
									c5x5.w();
									c5x5.an();
								}
							}
						}
					}
				}
			}
			for (int k = 8; k <= 10; k++)
			{
				for (int l = 29; l <= 31; l++)
				{
					ak1 ak2 = aud.b(k, l);
					if (ak2 != null)
					{
						foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.c.Values))
						{
							c5x c5x6 = (c5x)b0b2;
							if (c5x6.Layer == aju.x)
							{
								if (c5x6.h.b != null)
								{
									if (c5x6.h.b.aa().FactionId != asp.cg)
									{
										c5x6.h.b.a(null, false);
									}
								}
								else
								{
									c5x6.w();
									c5x6.an();
								}
							}
						}
					}
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-ww5_l2") + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
