using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020009F4 RID: 2548
[eiz("XPBLLEDAJPILN")]
[Serializable]
public sealed class eah : bdw, ISerializable
{
	// Token: 0x06003CDC RID: 15580 RVA: 0x001694B4 File Offset: 0x001676B4
	private eah(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CDD RID: 15581 RVA: 0x001694BC File Offset: 0x001676BC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CDE RID: 15582 RVA: 0x001694C0 File Offset: 0x001676C0
	public eah()
	{
	}

	// Token: 0x06003CDF RID: 15583 RVA: 0x001694C8 File Offset: 0x001676C8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			int value = A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value;
			bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("loc_" + A_0.y8() + "_clearedLingeringAegisJetPatrols", new bool?(false)).Value;
			bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value;
			bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value;
			if ((value < 10 || value3 || value4) && !value2)
			{
				foreach (aud aud in Enumerable.ToList<aud>(A_0.Areas))
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && c5x.h.b.aa().FactionId == asp.f7)
						{
							c5x.w();
							c5x.an();
						}
					}
				}
				A_1.r()["loc_" + A_0.y8() + "_clearedLingeringAegisJetPatrols"] = true;
			}
		}
	}
}
