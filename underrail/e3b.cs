using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B8C RID: 2956
[eiz("CCJCYJ")]
[Serializable]
public sealed class e3b : cze, ISerializable
{
	// Token: 0x0600435F RID: 17247 RVA: 0x001A5CF0 File Offset: 0x001A3EF0
	private e3b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004360 RID: 17248 RVA: 0x001A5CFC File Offset: 0x001A3EFC
	public e3b()
	{
	}

	// Token: 0x06004361 RID: 17249 RVA: 0x001A5D08 File Offset: 0x001A3F08
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_cc_ps_sewerPower_genPowered", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_sewer_facedJookhela", new bool?(false)).Value;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_jookhela_dead", new bool?(false)).Value && value && !value2)
				{
					serviceOrThrow.aqu().r()["loc_cc_sewer_facedJookhela"] = true;
					bpo.GetServiceOrThrow<ps>().am3("Cc_JookhelaConfrontsYou");
				}
			}
		}
	}
}
