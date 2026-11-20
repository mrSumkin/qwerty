using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009FC RID: 2556
[eiz("XPBLCVW17SPP")]
[Serializable]
public sealed class bwr : bdw, ISerializable
{
	// Token: 0x06003CFD RID: 15613 RVA: 0x0016A320 File Offset: 0x00168520
	private bwr(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x0016A328 File Offset: 0x00168528
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x0016A32C File Offset: 0x0016852C
	public bwr()
	{
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x0016A338 File Offset: 0x00168538
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cvw17");
		if (aud != null)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"Despawn"
				}))
				{
					if (b0b != null)
					{
						b0b.w();
						b0b.an();
					}
				}
			}
			gx gx = new gx();
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
			{
				if (csd.Name.StartsWith("pirate_spawn") && aw1.a(new bt4(csd.Name), aud, l9.b))
				{
					c5x c5x = gx.a(csd, new int?(10), "Pirates_Jetski", null, asp.ft, null, "support\\xpbl\\pir_jets1", false, null, false);
					if (c5x != null)
					{
						c5x.b("pirateParty");
					}
				}
			}
		}
	}
}
