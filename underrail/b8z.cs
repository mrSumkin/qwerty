using System;
using System.Runtime.Serialization;

// Token: 0x020007A2 RID: 1954
[eiz("XPBLCCRayRF")]
[Serializable]
public sealed class b8z : egv, ISerializable
{
	// Token: 0x06003121 RID: 12577 RVA: 0x0012DD54 File Offset: 0x0012BF54
	private b8z(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003122 RID: 12578 RVA: 0x0012DD5C File Offset: 0x0012BF5C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003123 RID: 12579 RVA: 0x0012DD60 File Offset: 0x0012BF60
	public b8z()
	{
	}

	// Token: 0x06003124 RID: 12580 RVA: 0x0012DD6C File Offset: 0x0012BF6C
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_cc-dock2_brokenInto", new bool?(false)).Value;
				int value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("SpecialMerchandiseLevel_ray", new int?(-1)).Value;
				float num = 2.7f;
				if (value)
				{
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_ray_describedSuspiciousPerson", new bool?(false)).Value;
					bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_ray_moneyStolen", new bool?(false)).Value;
					int value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_ray_jetsStolen_number", new int?(0)).Value;
					int value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("npc_cc_ray_itemsStolen", new int?(0)).Value;
					if (value3)
					{
						num = 2.2f;
					}
					else if (value4 || value5 > 0 || value6 > 0)
					{
						return bhm.b;
					}
				}
				if (value2 >= 0)
				{
					num -= 0.5f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
