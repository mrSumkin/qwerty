using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000A3B RID: 2619
[eiz("XPBLTSBA")]
[Serializable]
public sealed class n5 : bdw, ISerializable
{
	// Token: 0x06003E1F RID: 15903 RVA: 0x00176478 File Offset: 0x00174678
	private n5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E20 RID: 15904 RVA: 0x00176480 File Offset: 0x00174680
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E21 RID: 15905 RVA: 0x00176484 File Offset: 0x00174684
	public n5()
	{
	}

	// Token: 0x06003E22 RID: 15906 RVA: 0x00176490 File Offset: 0x00174690
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushTriggered", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushStarted", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>(bp5.b("g_boneChieftain"), new bool?(false)).Value)
		{
			A_1.r()["quest_xpbl_boneyard_ambushStarted"] = true;
			A_1.r()["quest_xpbl_boneyard_ambushing"] = true;
			doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_g12_l2") + ".uzl");
			A_0.a(a_, 1, null);
		}
	}
}
