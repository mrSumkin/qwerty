using System;
using System.Runtime.Serialization;

// Token: 0x02000785 RID: 1925
[eiz("RcMylesRF")]
[Serializable]
public sealed class dq2 : egv, ISerializable
{
	// Token: 0x060030AD RID: 12461 RVA: 0x0012BF50 File Offset: 0x0012A150
	private dq2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x0012BF58 File Offset: 0x0012A158
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x0012BF5C File Offset: 0x0012A15C
	public dq2()
	{
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x0012BF68 File Offset: 0x0012A168
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rc1_trainSupplies_arrived", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasAllSchematics", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasPistolSmgSchematics", new bool?(false)).Value;
				bool value5 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasRifleShotgunSchematics", new bool?(false)).Value;
				bool value6 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasMachineGunSchematics", new bool?(false)).Value;
				bool value7 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("firearmRefurbishment_hasGrenadeLauncherSchematics", new bool?(false)).Value;
				float num = 3f;
				if (value3)
				{
					num -= 0.4f;
				}
				else
				{
					if (value4)
					{
						num -= 0.1f;
					}
					if (value5)
					{
						num -= 0.1f;
					}
					if (value6)
					{
						num -= 0.1f;
					}
					if (value7)
					{
						num -= 0.1f;
					}
				}
				if (value)
				{
					num -= 0.3f;
				}
				if (value2)
				{
					num -= 0.3f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
