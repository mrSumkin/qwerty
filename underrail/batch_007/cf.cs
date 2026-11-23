using System;
using System.Runtime.Serialization;

// Token: 0x02000A22 RID: 2594
[eiz("XPBLUPDHWI")]
[Serializable]
public sealed class cf : bdw, ISerializable
{
	// Token: 0x06003DAC RID: 15788 RVA: 0x00171E28 File Offset: 0x00170028
	private cf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DAD RID: 15789 RVA: 0x00171E30 File Offset: 0x00170030
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DAE RID: 15790 RVA: 0x00171E34 File Offset: 0x00170034
	public cf()
	{
	}

	// Token: 0x06003DAF RID: 15791 RVA: 0x00171E3C File Offset: 0x0017003C
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("xpbl_up_dh") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_DudeInUpperUnderrail");
		}
	}
}
