using System;
using System.Runtime.Serialization;

// Token: 0x0200078D RID: 1933
[eiz("PBCaseRF")]
[Serializable]
public sealed class k : egv, ISerializable
{
	// Token: 0x060030CD RID: 12493 RVA: 0x0012C7EC File Offset: 0x0012A9EC
	private k(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x0012C7F4 File Offset: 0x0012A9F4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x0012C7F8 File Offset: 0x0012A9F8
	public k()
	{
	}

	// Token: 0x060030D0 RID: 12496 RVA: 0x0012C800 File Offset: 0x0012AA00
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
				float num = bhm.a;
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
