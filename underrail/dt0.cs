using System;
using System.Runtime.Serialization;

// Token: 0x0200078E RID: 1934
[eiz("PBLukaRF")]
[Serializable]
public sealed class dt0 : egv, ISerializable
{
	// Token: 0x060030D1 RID: 12497 RVA: 0x0012C918 File Offset: 0x0012AB18
	private dt0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x0012C920 File Offset: 0x0012AB20
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x0012C924 File Offset: 0x0012AB24
	public dt0()
	{
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x0012C930 File Offset: 0x0012AB30
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_epioneLabAssistCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_hephaestusCrewCompleted", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_gasFreeDronesComplete", new bool?(false)).Value;
				bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_renegadeSoldiersCompleted", new bool?(false)).Value;
				float num = 2.7f;
				if (value)
				{
					num -= 0.2f;
				}
				if (value2)
				{
					num -= 0.2f;
				}
				if (value3)
				{
					num -= 0.4f;
				}
				if (value4)
				{
					num -= 0.4f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
