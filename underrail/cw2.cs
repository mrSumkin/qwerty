using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x0200099C RID: 2460
[eiz("SGSPMIAC")]
[Serializable]
public sealed class cw2 : bdw, ISerializable
{
	// Token: 0x06003B6C RID: 15212 RVA: 0x0015FDD0 File Offset: 0x0015DFD0
	private cw2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B6D RID: 15213 RVA: 0x0015FDD8 File Offset: 0x0015DFD8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x0015FDDC File Offset: 0x0015DFDC
	public cw2()
	{
	}

	// Token: 0x06003B6F RID: 15215 RVA: 0x0015FDE8 File Offset: 0x0015DFE8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("StationAlpha-Level8");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_watch_SGSMurder_accuseBret", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_sgs_station8_investigation", new bool?(false)).Value && (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_sgs_bret_dead", new bool?(false)).Value || serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_sgs_lenox_dead", new bool?(false)).Value))
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "StationAlpha-Level8_l2") + ".uzl");
					aud.Zone.a(a_, 1, null);
					c5x c5x = new ar7(new Guid("364dff75-b81b-42b6-9fcd-6faec86ffe3a"), aud).ao() as c5x;
					if (c5x != null)
					{
						amc aspect = c5x.GetAspect<amc>();
						if (aspect != null)
						{
							aspect.aa().FactionId = "southGateStation";
						}
					}
					serviceOrThrow.aqu().r()["loc_sgs_station8_investigation"] = true;
				}
			}
		}
	}
}
