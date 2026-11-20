using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009CD RID: 2509
[eiz("RKLKE")]
[Serializable]
public sealed class cd6 : bdw, ISerializable
{
	// Token: 0x06003C2F RID: 15407 RVA: 0x001638D8 File Offset: 0x00161AD8
	private cd6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x001638E0 File Offset: 0x00161AE0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x001638E4 File Offset: 0x00161AE4
	public cd6()
	{
	}

	// Token: 0x06003C32 RID: 15410 RVA: 0x001638F0 File Offset: 0x00161AF0
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
					if (c5x.h.b != null && c5x.h.b.aa().FactionId != asp.a && !c5x.h.b.aa().Passive && c5x.Location.X < 38f && c5x.h.b.aa().FactionId != asp.cy)
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
