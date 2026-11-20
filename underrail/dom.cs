using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x020010A6 RID: 4262
[eiz("SESJ")]
[Serializable]
public sealed class dom : cze
{
	// Token: 0x0600596C RID: 22892 RVA: 0x0026A37C File Offset: 0x0026857C
	private dom(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600596D RID: 22893 RVA: 0x0026A388 File Offset: 0x00268588
	public dom()
	{
	}

	// Token: 0x0600596E RID: 22894 RVA: 0x0026A390 File Offset: 0x00268590
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.GoToEndStory, new object[0]));
	}
}
