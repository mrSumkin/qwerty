using System;
using System.Runtime.Serialization;

// Token: 0x02000A16 RID: 2582
[eiz("XPBLMCMSG")]
[Serializable]
public sealed class bft : bdw, ISerializable
{
	// Token: 0x06003D7A RID: 15738 RVA: 0x0017006C File Offset: 0x0016E26C
	private bft(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D7B RID: 15739 RVA: 0x00170074 File Offset: 0x0016E274
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D7C RID: 15740 RVA: 0x00170078 File Offset: 0x0016E278
	public bft()
	{
	}

	// Token: 0x06003D7D RID: 15741 RVA: 0x00170084 File Offset: 0x0016E284
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			A_0.n("xpbl_mc3");
			if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc3_setGlow", new bool?(false)).Value)
			{
				int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_mc_visionCounter", new int?(0)).Value;
				bzm bzm = new bzm();
				if (bzm != null && value > 2)
				{
					bzm.a(true);
					bzm.a("ServantGreen");
					bzm.ym(null, null, null);
					bzm.a(false);
					bzm.a("ServantNormal");
					bzm.ym(null, null, null);
				}
				serviceOrThrow.aqu().r()["loc_xpbl_mc3_setGlow"] = true;
			}
		}
	}
}
