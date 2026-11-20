using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200097B RID: 2427
[eiz("TCHIE")]
[Serializable]
public sealed class p6 : bdw, ISerializable
{
	// Token: 0x06003AE7 RID: 15079 RVA: 0x0015D80C File Offset: 0x0015BA0C
	private p6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AE8 RID: 15080 RVA: 0x0015D814 File Offset: 0x0015BA14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AE9 RID: 15081 RVA: 0x0015D818 File Offset: 0x0015BA18
	public p6()
	{
	}

	// Token: 0x06003AEA RID: 15082 RVA: 0x0015D824 File Offset: 0x0015BA24
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-entry");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("63bd9c04-2b65-4217-9efb-908a62413b49"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("026e0861-7347-45ff-9729-d9dbd1fef40c"), aud).ao() as c5x;
			foreach (c5x c5x3 in new c5x[]
			{
				c5x,
				c5x2
			})
			{
				if (c5x3 != null)
				{
					if (c5x3.o.b != null)
					{
						c5x3.o.b.b = Point.Zero;
					}
					if (c5x3.i.b != null)
					{
						c5x3.i.b.a(true, true);
					}
					c5x3.TileFormationModifiers = new bjp(new byte[]
					{
						0,
						2,
						1
					});
					c5x3.z();
					c5x3.c().a("open_close", false);
				}
			}
		}
	}
}
