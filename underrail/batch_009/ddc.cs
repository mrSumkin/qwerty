using System;
using System.Runtime.Serialization;

// Token: 0x02000990 RID: 2448
[eiz("LUXHCWHC")]
[Serializable]
public sealed class ddc : bdw, ISerializable
{
	// Token: 0x06003B3C RID: 15164 RVA: 0x0015F1F4 File Offset: 0x0015D3F4
	private ddc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x0015F1FC File Offset: 0x0015D3FC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x0015F200 File Offset: 0x0015D400
	public ddc()
	{
	}

	// Token: 0x06003B3F RID: 15167 RVA: 0x0015F20C File Offset: 0x0015D40C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.n("lux-b2") != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_pr_hephaestusCrewCompleted", new bool?(false)).Value && (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_lux-b2_menDied", new int?(0)).Value >= 4 || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_lux-b2_rescuedMen", new bool?(false)).Value))
			{
				serviceOrThrow.aqu().r()["loc_pb_chemicalSetup"] = true;
			}
		}
	}
}
