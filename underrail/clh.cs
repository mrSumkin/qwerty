using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009CE RID: 2510
[eiz("RKLKEAR")]
[Serializable]
public sealed class clh : bdw, ISerializable
{
	// Token: 0x06003C33 RID: 15411 RVA: 0x00163AC0 File Offset: 0x00161CC0
	private clh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C34 RID: 15412 RVA: 0x00163AC8 File Offset: 0x00161CC8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x00163ACC File Offset: 0x00161CCC
	public clh()
	{
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x00163AD8 File Offset: 0x00161CD8
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().FactionId != asp.a && !c5x.h.b.aa().Passive && c5x.Location.X < 38f)
					{
						c5x.h.b.aa().a(null, null, false);
						if (!c5x.h.b.aa().b(d8o.e))
						{
							Vector3 a_ = c5x.h.b.a8().aj().a().a();
							if (c5x.h.b.aa().b(d8o.i))
							{
								vq.a("floor\\SlimePuddle", aud.Zone, new bt4(aud.y8(), a_), false);
							}
							else
							{
								vq.a("floor\\bloodPuddle", aud.Zone, new bt4(aud.y8(), a_), false);
							}
						}
					}
				}
			}
		}
	}
}
