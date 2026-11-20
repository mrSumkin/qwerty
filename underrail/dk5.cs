using System;
using System.Runtime.Serialization;

// Token: 0x0200078A RID: 1930
[eiz("TCHKiroRF")]
[Serializable]
public sealed class dk5 : egv, ISerializable
{
	// Token: 0x060030C1 RID: 12481 RVA: 0x0012C508 File Offset: 0x0012A708
	private dk5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x0012C510 File Offset: 0x0012A710
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x0012C514 File Offset: 0x0012A714
	public dk5()
	{
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x0012C520 File Offset: 0x0012A720
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_FindPavelCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantFirstTRayEmmiterCompleted", new bool?(false)).Value;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_schteff_plantSecondTRayEmmiterCompleted", new bool?(false)).Value)
				{
					return 1.8f;
				}
				if (value2)
				{
					return 2.1f;
				}
				if (value)
				{
					return 2.3f;
				}
				return 2.6f;
			}
		}
		return bhm.a;
	}
}
