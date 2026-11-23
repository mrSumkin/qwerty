using System;
using System.Runtime.Serialization;

// Token: 0x02000A1E RID: 2590
[eiz("XPBLKL2PEA")]
[Serializable]
public sealed class b8 : bdw, ISerializable
{
	// Token: 0x06003D9C RID: 15772 RVA: 0x00171B18 File Offset: 0x0016FD18
	private b8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D9D RID: 15773 RVA: 0x00171B20 File Offset: 0x0016FD20
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D9E RID: 15774 RVA: 0x00171B24 File Offset: 0x0016FD24
	public b8()
	{
	}

	// Token: 0x06003D9F RID: 15775 RVA: 0x00171B2C File Offset: 0x0016FD2C
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("xpbl_kirillLab2") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_KirillLab2_PlayerExitsAcid");
		}
	}
}
