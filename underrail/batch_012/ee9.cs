using System;
using System.Runtime.Serialization;

// Token: 0x0200092D RID: 2349
[eiz("CCSS")]
[Serializable]
public sealed class ee9 : bdw, ISerializable
{
	// Token: 0x060039A8 RID: 14760 RVA: 0x00154F78 File Offset: 0x00153178
	private ee9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039A9 RID: 14761 RVA: 0x00154F80 File Offset: 0x00153180
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039AA RID: 14762 RVA: 0x00154F84 File Offset: 0x00153184
	public ee9()
	{
	}

	// Token: 0x060039AB RID: 14763 RVA: 0x00154F90 File Offset: 0x00153190
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		aud aud = A_0.n("up-cc");
		if (aud != null && serviceOrThrow != null)
		{
			c5x c5x = new ar7(new Guid("355c51e2-4e2e-4ff8-8e08-21454558e877"), aud).ao() as c5x;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_facelessRetreated", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_cc_sammy_killedHimself", new bool?(false)).Value && c5x != null)
			{
				c5x.w();
				c5x.an();
				serviceOrThrow.aqu().r()["npc_cc_sammy_killedHimself"] = true;
			}
		}
	}
}
