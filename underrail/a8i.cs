using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ABA RID: 2746
[eiz("WBBAA")]
[Serializable]
public sealed class a8i : cze, ISerializable
{
	// Token: 0x0600401A RID: 16410 RVA: 0x00185638 File Offset: 0x00183838
	private a8i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x00185644 File Offset: 0x00183844
	public a8i()
	{
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x00185650 File Offset: 0x00183850
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_wbb_alarmActiveUntil"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(5.0);
			new a2q().ym(null, null, null);
		}
	}
}
