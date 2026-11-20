using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200097C RID: 2428
[eiz("TCHIEAI")]
[Serializable]
public sealed class cfl : bdw, ISerializable
{
	// Token: 0x06003AEB RID: 15083 RVA: 0x0015D930 File Offset: 0x0015BB30
	private cfl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003AEC RID: 15084 RVA: 0x0015D938 File Offset: 0x0015BB38
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003AED RID: 15085 RVA: 0x0015D93C File Offset: 0x0015BB3C
	public cfl()
	{
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x0015D948 File Offset: 0x0015BB48
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch-entry");
		if (aud != null)
		{
			foreach (d4n d4n in Enumerable.ToList<d4n>(bpo.GetServiceOrThrow<d02>().ahl()))
			{
				if ((d4n.b != null && d4n.b.aa().FactionId == asp.es) || d4n.b.aa().FactionId == asp.ez)
				{
					e3l aspect = d4n.b.a8().GetAspect<e3l>();
					if (aspect == null || !aspect.a.Contains("dontDespawnOnInvasion"))
					{
						if (d4n.b.a8().Location.Y <= 17f)
						{
							d4n.b.aa().a(null, null, false);
						}
						else
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
			}
			for (int i = aud.Entities.Count - 1; i >= 0; i--)
			{
				c5x c5x = aud.Entities[i] as c5x;
				if (c5x.Layer == aju.x && c5x.o.b != null && c5x.o.b.a == "Objects\\Obstacles\\BarbedWire")
				{
					c5x.w();
					c5x.an();
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch-entry_l2") + ".uzl");
			A_0.a(a_, 1, null);
		}
	}
}
