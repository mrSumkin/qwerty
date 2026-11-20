using System;
using System.Runtime.Serialization;

// Token: 0x020009F7 RID: 2551
[eiz("XPBLCCDAB")]
[Serializable]
public sealed class eze : bdw, ISerializable
{
	// Token: 0x06003CE9 RID: 15593 RVA: 0x00169CCC File Offset: 0x00167ECC
	private eze(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x00169CD4 File Offset: 0x00167ED4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x00169CD8 File Offset: 0x00167ED8
	public eze()
	{
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x00169CE4 File Offset: 0x00167EE4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_arrivedAtDock", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_cc_dock2_aegisBoatsPresent", new bool?(false)).Value)
			{
				erb.a(A_1, A_0, "xpbl_agsBoat1_dirty", A_0.g("AegisBoat1"));
				erb.a(A_1, A_0, "xpbl_agsBoat2_dirty", A_0.g("AegisBoat2"));
				erb.a(A_1, A_0, "xpbl_agsBoat3_dirty", A_0.g("AegisBoat3"));
				serviceOrThrow.aqu().r()["loc_xpbl_cc_dock2_aegisBoatsPresent"] = true;
			}
		}
	}
}
