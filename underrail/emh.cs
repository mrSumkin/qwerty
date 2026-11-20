using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AC4 RID: 2756
[eiz("XPBLWAA")]
[Serializable]
public sealed class emh : cze, ISerializable
{
	// Token: 0x06004039 RID: 16441 RVA: 0x00186E54 File Offset: 0x00185054
	private emh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600403A RID: 16442 RVA: 0x00186E60 File Offset: 0x00185060
	public emh()
	{
	}

	// Token: 0x0600403B RID: 16443 RVA: 0x00186E6C File Offset: 0x0018506C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_xpbl_wumb_alarmActiveUntil"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(2.0);
			new a70().ym(A_0, A_1, null);
		}
	}
}
