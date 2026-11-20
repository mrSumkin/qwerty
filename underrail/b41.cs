using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AA0 RID: 2720
[eiz("LUTR")]
[Serializable]
public sealed class b41 : cze, ISerializable
{
	// Token: 0x06003FAE RID: 16302 RVA: 0x00182D1C File Offset: 0x00180F1C
	private b41(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x00182D28 File Offset: 0x00180F28
	public b41()
	{
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x00182D34 File Offset: 0x00180F34
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().IsInCombat && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lu-b29_trainRigged", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("lo_lu-b29_defuseSuccess", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lu-b29_killFreeDrones", new int?(0)).Value >= 5 && serviceOrThrow.aqu().v().b().Location.Y < 14f)
		{
			serviceOrThrow.aqu().r()["loc_lu-b29_trainRigged"] = true;
			bpo.GetServiceOrThrow<ps>().am3("Lu_FreeDroneRigsTrain");
		}
	}
}
