using System;
using System.Runtime.Serialization;

// Token: 0x0200078C RID: 1932
[eiz("PBAnastasiaRF")]
[Serializable]
public sealed class cy2 : egv, ISerializable
{
	// Token: 0x060030C9 RID: 12489 RVA: 0x0012C6F0 File Offset: 0x0012A8F0
	private cy2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x0012C6F8 File Offset: 0x0012A8F8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x0012C6FC File Offset: 0x0012A8FC
	public cy2()
	{
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x0012C708 File Offset: 0x0012A908
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_epioneLabAssistCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_hephaestusCrewCompleted", new bool?(false)).Value;
				bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_renegadeSoldiersCompleted", new bool?(false)).Value;
				float num = 2.7f;
				if (value)
				{
					num -= 0.3f;
				}
				if (value2)
				{
					num -= 0.3f;
				}
				if (value3)
				{
					num -= 0.4f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
