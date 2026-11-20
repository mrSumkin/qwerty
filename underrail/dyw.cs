using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000912 RID: 2322
[eiz("CCSWCU")]
[Serializable]
public sealed class dyw : bdw, ISerializable
{
	// Token: 0x06003937 RID: 14647 RVA: 0x00152EEC File Offset: 0x001510EC
	private dyw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x00152EF4 File Offset: 0x001510F4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003939 RID: 14649 RVA: 0x00152EF8 File Offset: 0x001510F8
	public dyw()
	{
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x00152F04 File Offset: 0x00151104
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_warehouse");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc_warehouse_l4") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
