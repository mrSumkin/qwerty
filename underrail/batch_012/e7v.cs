using System;
using System.Runtime.Serialization;

// Token: 0x020009AD RID: 2477
[eiz("FOTIU")]
[Serializable]
public sealed class e7v : bdw, ISerializable
{
	// Token: 0x06003BB0 RID: 15280 RVA: 0x0016170C File Offset: 0x0015F90C
	private e7v(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BB1 RID: 15281 RVA: 0x00161714 File Offset: 0x0015F914
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BB2 RID: 15282 RVA: 0x00161718 File Offset: 0x0015F918
	public e7v()
	{
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x00161724 File Offset: 0x0015F924
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("fo2") != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				serviceOrThrow.aqu().r()["npc_fo_chief_completeTodorInvestigation"] = true;
			}
		}
	}
}
