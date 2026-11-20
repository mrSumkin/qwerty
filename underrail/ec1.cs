using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AA8 RID: 2728
[eiz("CJX1")]
[Serializable]
public sealed class ec1 : cze, ISerializable
{
	// Token: 0x06003FD6 RID: 16342 RVA: 0x001837D8 File Offset: 0x001819D8
	private ec1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x001837E4 File Offset: 0x001819E4
	public ec1()
	{
	}

	// Token: 0x06003FD8 RID: 16344 RVA: 0x001837F0 File Offset: 0x001819F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqz().atb("NotSleepingWithTheFishes", true))
		{
			serviceOrThrow.aqu().r().SetPropertyValue(bp5.h("SleepWithFishes"), 1);
		}
	}
}
