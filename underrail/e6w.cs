using System;
using System.Runtime.Serialization;

// Token: 0x02000A23 RID: 2595
[eiz("XPBLCCDHWI")]
[Serializable]
public sealed class e6w : bdw, ISerializable
{
	// Token: 0x06003DB0 RID: 15792 RVA: 0x00171E6C File Offset: 0x0017006C
	private e6w(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DB1 RID: 15793 RVA: 0x00171E74 File Offset: 0x00170074
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DB2 RID: 15794 RVA: 0x00171E78 File Offset: 0x00170078
	public e6w()
	{
	}

	// Token: 0x06003DB3 RID: 15795 RVA: 0x00171E80 File Offset: 0x00170080
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && A_0.n("xpbl_cc_dh") != null)
		{
			bpo.GetServiceOrThrow<ps>().am3("Xpbl_DudeAndZonerMa");
		}
	}
}
