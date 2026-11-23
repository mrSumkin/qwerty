using System;
using System.Runtime.Serialization;

// Token: 0x020007A7 RID: 1959
[eiz("XPBLPIRDonnieRF")]
[Serializable]
public sealed class ana : egv, ISerializable
{
	// Token: 0x06003135 RID: 12597 RVA: 0x0012E4D0 File Offset: 0x0012C6D0
	private ana(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x0012E4D8 File Offset: 0x0012C6D8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x0012E4DC File Offset: 0x0012C6DC
	public ana()
	{
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x0012E4E8 File Offset: 0x0012C6E8
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_firstRaid_completed", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_completed", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_theRig_completed", new bool?(false)).Value;
				int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("SpecialMerchandiseLevel_donnie", new int?(-1)).Value;
				float num = 3f;
				if (value3)
				{
					num = 1.5f;
				}
				else if (value2)
				{
					num = 2f;
				}
				else if (value)
				{
					num = bhm.a;
				}
				if (value4 >= 0)
				{
					num -= 0.2f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
