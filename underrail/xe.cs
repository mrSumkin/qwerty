using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009C0 RID: 2496
[eiz("LUTHFDHP")]
[Serializable]
public sealed class xe : bdw, ISerializable
{
	// Token: 0x06003BFC RID: 15356 RVA: 0x00162AA8 File Offset: 0x00160CA8
	private xe(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x00162AB0 File Offset: 0x00160CB0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BFE RID: 15358 RVA: 0x00162AB4 File Offset: 0x00160CB4
	public xe()
	{
	}

	// Token: 0x06003BFF RID: 15359 RVA: 0x00162AC0 File Offset: 0x00160CC0
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_freeDronesHideout_collapsed", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_lu-b29_bombPlanted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_lu-b29_defuseSuccess", new bool?(false)).Value)
		{
			aud aud = A_0.n("lu-b29");
			if (aud != null)
			{
				c5x c5x = aud.a(new Guid("646766CB-7675-4567-B122-F58903C2DB81")) as c5x;
				if (c5x != null && c5x.j == cgy.b)
				{
					c5x.w();
					c5x.an();
				}
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b29_l2") + ".uzl");
				A_0.a(a_, 1, null);
				d02 service = bpo.GetService<d02>();
				if (service != null)
				{
					foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
					{
						if (d4n.b != null && d4n.b.aa().FactionId != asp.a)
						{
							d4n.b.a8().w();
							d4n.b.a8().an();
						}
					}
				}
				serviceOrThrow.aqu().r()["loc_lu_freeDronesHideout_collapsed"] = true;
				serviceOrThrow.aqu().r()["lo_lu-b29_trainBlewUp"] = true;
			}
		}
	}
}
