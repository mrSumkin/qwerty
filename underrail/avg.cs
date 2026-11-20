using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A04 RID: 2564
[eiz("XPBLPIRCPAAG")]
[Serializable]
public sealed class avg : bdw, ISerializable
{
	// Token: 0x06003D25 RID: 15653 RVA: 0x0016BB8C File Offset: 0x00169D8C
	private avg(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D26 RID: 15654 RVA: 0x0016BB94 File Offset: 0x00169D94
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x0016BB98 File Offset: 0x00169D98
	public avg()
	{
	}

	// Token: 0x06003D28 RID: 15656 RVA: 0x0016BBA4 File Offset: 0x00169DA4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				Random random = new Random();
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("event_pir_meeting_techOfferLevel", new int?(0)).Value;
				foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x != null && c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.fr || c5x.h.b.aa().FactionId == asp.fs) && (c5x.h.b.am().Contains("xpbl_pr6") || c5x.h.b.am().Contains("xpbl_prf4") || c5x.h.b.am().Contains("xpbl_prdv")) && random.Next(0, 5) < value)
						{
							bry.a(c5x);
						}
					}
				}
			}
		}
	}
}
