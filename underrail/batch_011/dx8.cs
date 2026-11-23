using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AA5 RID: 2725
[eiz("RM_T1")]
[Serializable]
public sealed class dx8 : cze, ISerializable
{
	// Token: 0x06003FC3 RID: 16323 RVA: 0x001833CC File Offset: 0x001815CC
	private dx8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x001833D8 File Offset: 0x001815D8
	public dx8()
	{
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x001833E4 File Offset: 0x001815E4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqz().atb("DutyCalls", true);
		}
	}
}
