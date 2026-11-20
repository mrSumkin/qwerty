using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B5B RID: 2907
[eiz("JYUSJCJ")]
[Serializable]
public sealed class dlh : cze, ISerializable
{
	// Token: 0x0600429B RID: 17051 RVA: 0x0019D66C File Offset: 0x0019B86C
	private dlh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600429C RID: 17052 RVA: 0x0019D678 File Offset: 0x0019B878
	public dlh()
	{
	}

	// Token: 0x0600429D RID: 17053 RVA: 0x0019D684 File Offset: 0x0019B884
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytjenny_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jytcliff_dead", new bool?(false)).Value)
		{
			serviceOrThrow.aqz().atd("jy_saveJenny", true);
		}
	}
}
