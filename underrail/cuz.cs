using System;
using System.Runtime.Serialization;

// Token: 0x0200078F RID: 1935
[eiz("PBFraserRF")]
[Serializable]
public sealed class cuz : egv, ISerializable
{
	// Token: 0x060030D5 RID: 12501 RVA: 0x0012CA48 File Offset: 0x0012AC48
	private cuz(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030D6 RID: 12502 RVA: 0x0012CA50 File Offset: 0x0012AC50
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x0012CA54 File Offset: 0x0012AC54
	public cuz()
	{
	}

	// Token: 0x060030D8 RID: 12504 RVA: 0x0012CA60 File Offset: 0x0012AC60
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
				float num = 3.25f;
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
