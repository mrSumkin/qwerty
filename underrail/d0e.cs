using System;
using System.Runtime.Serialization;

// Token: 0x02000A3C RID: 2620
[eiz("XPBLTEBA")]
[Serializable]
public sealed class d0e : bdw, ISerializable
{
	// Token: 0x06003E23 RID: 15907 RVA: 0x00176570 File Offset: 0x00174770
	private d0e(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E24 RID: 15908 RVA: 0x00176578 File Offset: 0x00174778
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E25 RID: 15909 RVA: 0x0017657C File Offset: 0x0017477C
	public d0e()
	{
	}

	// Token: 0x06003E26 RID: 15910 RVA: 0x00176584 File Offset: 0x00174784
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (dh7.a != null && dh7.a.c != null && !dh7.a.c.Equals("xpbl_gy_enter", StringComparison.OrdinalIgnoreCase) && serviceOrThrow.aqu() != null && A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushStarted", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_boneyard_ambushEnded", new bool?(false)).Value)
		{
			A_1.r()["quest_xpbl_boneyard_ambushEnded"] = true;
			serviceOrThrow.aqu().b(new ehh());
			foreach (b0b b0b in A_0.a().ab4(new string[]
			{
				"ambush"
			}))
			{
				c5x c5x = (c5x)b0b;
				c5x.w();
				c5x.an();
			}
		}
	}
}
