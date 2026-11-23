using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009F0 RID: 2544
[eiz("XPBLPIRSPIA")]
[Serializable]
public sealed class arq : bdw, ISerializable
{
	// Token: 0x06003CC9 RID: 15561 RVA: 0x00168EE0 File Offset: 0x001670E0
	private arq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CCA RID: 15562 RVA: 0x00168EE8 File Offset: 0x001670E8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CCB RID: 15563 RVA: 0x00168EEC File Offset: 0x001670EC
	public arq()
	{
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x00168EF8 File Offset: 0x001670F8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			gx gx = new gx();
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
			{
				if (csd != null && csd.Name.StartsWith("spawnPirate") && aw1.a(new bt4(csd.Name), A_0.n(csd.Area.y8()), l9.a))
				{
					gx.a(csd, new int?(15), "Pirates", null, asp.fu, null, "support\\xpbl\\pir_main1", false, null, false);
				}
			}
			if (A_0.y8() == "xpbl_i5u_ps")
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(A_0.n("xpbl_i5u_ps").Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x.y8() != null && c5x.y8().Contains("Патроны") && c5x.Layer == aju.x && c5x.s.b != null)
					{
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}
