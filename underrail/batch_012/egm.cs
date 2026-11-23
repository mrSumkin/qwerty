using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020008E4 RID: 2276
[eiz("CCS1REL")]
[Serializable]
public sealed class egm : bdw, ISerializable
{
	// Token: 0x0600387C RID: 14460 RVA: 0x0014EE3C File Offset: 0x0014D03C
	private egm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600387D RID: 14461 RVA: 0x0014EE44 File Offset: 0x0014D044
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x0014EE48 File Offset: 0x0014D048
	public egm()
	{
	}

	// Token: 0x0600387F RID: 14463 RVA: 0x0014EE54 File Offset: 0x0014D054
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "cc_s1_l3") + ".uzl");
			A_0.a(a_, 1, null);
		}
	}
}
