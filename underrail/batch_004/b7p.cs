using System;
using System.Runtime.Serialization;

// Token: 0x02000788 RID: 1928
[eiz("TCHOctaviaRF")]
[Serializable]
public sealed class b7p : egv, ISerializable
{
	// Token: 0x060030B9 RID: 12473 RVA: 0x0012C34C File Offset: 0x0012A54C
	private b7p(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x0012C354 File Offset: 0x0012A554
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x0012C358 File Offset: 0x0012A558
	public b7p()
	{
	}

	// Token: 0x060030BC RID: 12476 RVA: 0x0012C360 File Offset: 0x0012A560
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_georgis_findResearchDataCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_georgis_testChemicalWeaponCompleted", new bool?(false)).Value;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_georgis_tasteAlcoholCompleted", new bool?(false)).Value)
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
