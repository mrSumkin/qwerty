using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B5A RID: 2906
[eiz("TNAB")]
[Serializable]
public sealed class at6 : cze, ISerializable
{
	// Token: 0x06004298 RID: 17048 RVA: 0x0019D5BC File Offset: 0x0019B7BC
	private at6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004299 RID: 17049 RVA: 0x0019D5C8 File Offset: 0x0019B7C8
	public at6()
	{
	}

	// Token: 0x0600429A RID: 17050 RVA: 0x0019D5D4 File Offset: 0x0019B7D4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && Enumerable.Any<coh>(serviceOrThrow.aqu().v().Bag.b("plot.abramsSpawn")) && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_jypetDelivery_finished", new bool?(false)).Value)
		{
			serviceOrThrow.aqu().r()["npc_abram_detectedYourJunkyardTreason"] = true;
		}
	}
}
