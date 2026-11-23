using System;
using System.Runtime.Serialization;

// Token: 0x02000789 RID: 1929
[eiz("TCHVukRF")]
[Serializable]
public sealed class qd : egv, ISerializable
{
	// Token: 0x060030BD RID: 12477 RVA: 0x0012C428 File Offset: 0x0012A628
	private qd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030BE RID: 12478 RVA: 0x0012C430 File Offset: 0x0012A630
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x0012C434 File Offset: 0x0012A634
	public qd()
	{
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x0012C440 File Offset: 0x0012A640
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_rista_PacifyPsiBeetleCompleted", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_rista_InvestigateBehemothCompleted", new bool?(false)).Value;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_tch_rista_findHealthCompleted", new bool?(false)).Value)
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
