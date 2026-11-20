using System;
using System.Runtime.Serialization;

// Token: 0x02000A1F RID: 2591
[eiz("XPBLWUMB2AWD")]
[Serializable]
public sealed class dyy : bdw, ISerializable
{
	// Token: 0x06003DA0 RID: 15776 RVA: 0x00171B5C File Offset: 0x0016FD5C
	private dyy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DA1 RID: 15777 RVA: 0x00171B64 File Offset: 0x0016FD64
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DA2 RID: 15778 RVA: 0x00171B68 File Offset: 0x0016FD68
	public dyy()
	{
	}

	// Token: 0x06003DA3 RID: 15779 RVA: 0x00171B70 File Offset: 0x0016FD70
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("xpbl_wumb2") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_Wumb2_Arrival");
		}
	}
}
