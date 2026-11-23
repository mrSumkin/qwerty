using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009C8 RID: 2504
[eiz("FOFNFP")]
[Serializable]
public sealed class cyx : bdw, ISerializable
{
	// Token: 0x06003C1B RID: 15387 RVA: 0x001632C4 File Offset: 0x001614C4
	private cyx(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x001632CC File Offset: 0x001614CC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x001632D0 File Offset: 0x001614D0
	public cyx()
	{
	}

	// Token: 0x06003C1E RID: 15390 RVA: 0x001632DC File Offset: 0x001614DC
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && A_0 != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu_foundryfacelesscave_departed", new bool?(false)).Value)
		{
			aud aud = A_0.n("lu-b22x");
			if (aud != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
				bool flag = false;
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.StartsWith("faceless", StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
					}
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fo_facelessRecon_finished", new bool?(false)).Value || !flag || value)
				{
					c5x c5x2 = aud.a(new Guid("135c1cd3-00fa-410e-96b0-d95cdc7bbfb5")) as c5x;
					if (c5x2 != null && c5x2.j == cgy.b)
					{
						c5x2.w();
						c5x2.an();
					}
					doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b22x_l2") + ".uzl");
					A_0.a(a_, 1, null);
					d02 service = bpo.GetService<d02>();
					if (service != null)
					{
						foreach (d4n d4n in Enumerable.ToList<d4n>(service.ahl()))
						{
							if (d4n.b != null && (d4n.b.aa().FactionId == asp.c9 || d4n.b.aa().FactionId == asp.db))
							{
								d4n.b.a8().w();
								d4n.b.a8().an();
							}
						}
					}
					serviceOrThrow.aqu().r()["loc_lu_foundryfacelesscave_departed"] = true;
				}
			}
		}
	}
}
