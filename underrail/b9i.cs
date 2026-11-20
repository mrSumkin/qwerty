using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200090D RID: 2317
[eiz("CCSWA")]
[Serializable]
public sealed class b9i : bdw, ISerializable
{
	// Token: 0x06003923 RID: 14627 RVA: 0x00152740 File Offset: 0x00150940
	private b9i(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003924 RID: 14628 RVA: 0x00152748 File Offset: 0x00150948
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003925 RID: 14629 RVA: 0x0015274C File Offset: 0x0015094C
	public b9i()
	{
	}

	// Token: 0x06003926 RID: 14630 RVA: 0x00152758 File Offset: 0x00150958
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_warehouse");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_warehouse_l3") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
