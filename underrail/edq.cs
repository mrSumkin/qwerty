using System;
using System.Runtime.Serialization;

// Token: 0x02000963 RID: 2403
[eiz("SGSFETR")]
[Serializable]
public sealed class edq : bdw, ISerializable
{
	// Token: 0x06003A86 RID: 14982 RVA: 0x0015A874 File Offset: 0x00158A74
	private edq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x0015A87C File Offset: 0x00158A7C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x0015A880 File Offset: 0x00158A80
	public edq()
	{
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x0015A888 File Offset: 0x00158A88
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("StationAlpha-Level5") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Sgs_EzraUnlocksTheDoors");
		}
	}
}
