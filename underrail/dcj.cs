using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B01 RID: 2817
[eiz("XPBLCVWPRQRDVJ")]
[Serializable]
public sealed class dcj : cze, ISerializable
{
	// Token: 0x06004144 RID: 16708 RVA: 0x0018F0E0 File Offset: 0x0018D2E0
	private dcj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004145 RID: 16709 RVA: 0x0018F0EC File Offset: 0x0018D2EC
	public dcj()
	{
	}

	// Token: 0x06004146 RID: 16710 RVA: 0x0018F0F8 File Offset: 0x0018D2F8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_cvw_prc1_dispatchedReinforcements", new bool?(false)).Value)
		{
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_goAlone", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().b(new anr());
			}
			serviceOrThrow.aqu().r()["loc_xpbl_cvw_prc1_dispatchedReinforcements"] = true;
		}
	}
}
