using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009F9 RID: 2553
[eiz("XPBLPIRSPOM")]
[Serializable]
public sealed class dv : bdw, ISerializable
{
	// Token: 0x06003CF1 RID: 15601 RVA: 0x0016A010 File Offset: 0x00168210
	private dv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x0016A018 File Offset: 0x00168218
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x0016A01C File Offset: 0x0016821C
	public dv()
	{
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x0016A028 File Offset: 0x00168228
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			gx gx = new gx();
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
			{
				if (csd != null && csd.Name.StartsWith("spawnPirate") && aw1.a(new bt4(csd.Name), A_0.n("xpbl_i1"), l9.a))
				{
					gx.a(csd, new int?(15), "Pirates", null, asp.fu, null, "support\\xpbl\\pir_main1", false, null, false);
				}
			}
		}
	}
}
