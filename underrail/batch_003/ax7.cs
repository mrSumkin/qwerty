using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B60 RID: 2912
[eiz("RKAWS")]
[Serializable]
public sealed class ax7 : cze, ISerializable
{
	// Token: 0x060042AA RID: 17066 RVA: 0x0019DB04 File Offset: 0x0019BD04
	private ax7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042AB RID: 17067 RVA: 0x0019DB10 File Offset: 0x0019BD10
	public ax7()
	{
	}

	// Token: 0x060042AC RID: 17068 RVA: 0x0019DB18 File Offset: 0x0019BD18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rkl_playerLeavesBeck", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_sarine_captured", new bool?(false)).Value)
			{
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_beck_dead", new bool?(false)).Value)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rathoundKingDies", new bool?(false)).Value)
					{
						bv.a(asp.ct, asp.a, h.a, null, true, false, false);
						serviceOrThrow.aqu().a(new bw0("rkl2", new egk(), 1));
						serviceOrThrow.aqu().r()["npc_ch_beck_survivedTheBattle"] = true;
					}
					else
					{
						cky cky = bv.abu(asp.cy, asp.a);
						if (cky != null && cky.a == h.a)
						{
							serviceOrThrow.aqu().r()["npc_rathoundKing_flees"] = true;
							serviceOrThrow.aqu().a(new bw0("rkl2", new clh(), 1));
						}
						else
						{
							serviceOrThrow.aqu().a(new bw0("rkl2", new cd6(), 1));
						}
					}
				}
				serviceOrThrow.aqu().r()["loc_rkl_playerLeavesBeck"] = true;
			}
			if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_rkl_playerLeavesEdgar", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_ch_edgar_wentTogetherToRathoundLair", new bool?(false)).Value)
			{
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("ch_edgar_dies", new bool?(false)).Value)
				{
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rathoundKingDies", new bool?(false)).Value)
					{
						cky cky2 = bv.abu(asp.cx, asp.a);
						if (cky2 != null && cky2.a == h.a)
						{
							bv.a(asp.ct, asp.a, h.a, null, true, false, false);
							serviceOrThrow.aqu().r()["npc_ch_edgar_survivedPlayerBetrayal"] = true;
							serviceOrThrow.aqu().a(new bw0("rkl2", new egk(), 1));
						}
					}
					else
					{
						serviceOrThrow.aqu().a(new bw0("rkl2", new clh(), 1));
						serviceOrThrow.aqu().r()["npc_rathoundKing_flees"] = true;
					}
				}
				serviceOrThrow.aqu().r()["loc_rkl_playerLeavesEdgar"] = true;
			}
		}
	}
}
