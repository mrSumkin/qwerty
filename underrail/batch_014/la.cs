using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200093F RID: 2367
[eiz("XPBLMUSMSIOZ")]
[Serializable]
public sealed class la : bdw, ISerializable
{
	// Token: 0x060039F2 RID: 14834 RVA: 0x00156930 File Offset: 0x00154B30
	private la(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039F3 RID: 14835 RVA: 0x00156938 File Offset: 0x00154B38
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039F4 RID: 14836 RVA: 0x0015693C File Offset: 0x00154B3C
	public la()
	{
	}

	// Token: 0x060039F5 RID: 14837 RVA: 0x00156944 File Offset: 0x00154B44
	public void av(c1a A_0, cyt A_1)
	{
		doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_b7_L2") + ".uzl");
		A_0.a(a_, 1, null);
	}
}
