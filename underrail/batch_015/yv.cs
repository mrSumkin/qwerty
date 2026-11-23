using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009FB RID: 2555
[eiz("XPBLPIRRP")]
[Serializable]
public sealed class yv : bdw, ISerializable
{
	// Token: 0x06003CF9 RID: 15609 RVA: 0x0016A1F8 File Offset: 0x001683F8
	private yv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x0016A200 File Offset: 0x00168400
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x0016A204 File Offset: 0x00168404
	public yv()
	{
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x0016A210 File Offset: 0x00168410
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			bpo.GetServiceOrThrow<cnk>();
			foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.Contains("pirate"))
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}
