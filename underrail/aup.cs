using System;
using System.Runtime.Serialization;

// Token: 0x02000914 RID: 2324
[eiz("CCVSR1")]
[Serializable]
public sealed class aup : bdw, ISerializable
{
	// Token: 0x0600393F RID: 14655 RVA: 0x00152FC8 File Offset: 0x001511C8
	private aup(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003940 RID: 14656 RVA: 0x00152FD0 File Offset: 0x001511D0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003941 RID: 14657 RVA: 0x00152FD4 File Offset: 0x001511D4
	public aup()
	{
	}

	// Token: 0x06003942 RID: 14658 RVA: 0x00152FDC File Offset: 0x001511DC
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("cc_bcf0") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Cc_StartRepairsWithVivian");
		}
	}
}
