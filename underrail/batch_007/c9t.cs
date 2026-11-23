using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009D9 RID: 2521
[eiz("SGSCR0")]
[Serializable]
public sealed class c9t : bdw, ISerializable
{
	// Token: 0x06003C5F RID: 15455 RVA: 0x00165DE4 File Offset: 0x00163FE4
	private c9t(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x00165DEC File Offset: 0x00163FEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x00165DF0 File Offset: 0x00163FF0
	public c9t()
	{
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x00165DFC File Offset: 0x00163FFC
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("LU-SouthGateStation-N");
			if (aud != null)
			{
				for (int i = 0; i <= 9; i++)
				{
					for (int j = 0; j <= 4; j++)
					{
						ak1 ak = aud.b(i, j);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
							{
								c5x c5x = (c5x)b0b;
								if (c5x.Layer == aju.x && c5x.y8() != "Security Camera")
								{
									c5x.w();
									c5x.an();
								}
							}
						}
					}
				}
				for (int k = 2; k <= 9; k++)
				{
					ak1 ak2 = aud.b(k, 19);
					if (ak2 != null)
					{
						foreach (b0b b0b2 in Enumerable.ToList<b0b>(ak2.Entities))
						{
							c5x c5x2 = (c5x)b0b2;
							if (c5x2.Layer == aju.x)
							{
								etz etz = c5x2.o.b as etz;
								if (etz != null)
								{
									etz.a(0);
									etz.b = Point.Zero;
								}
							}
						}
					}
				}
			}
		}
	}
}
