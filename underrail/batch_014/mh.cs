using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A3E RID: 2622
[eiz("XPBLE5L")]
[Serializable]
public sealed class mh : bdw, ISerializable
{
	// Token: 0x06003E2B RID: 15915 RVA: 0x001767B0 File Offset: 0x001749B0
	private mh(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E2C RID: 15916 RVA: 0x001767B8 File Offset: 0x001749B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E2D RID: 15917 RVA: 0x001767BC File Offset: 0x001749BC
	public mh()
	{
	}

	// Token: 0x06003E2E RID: 15918 RVA: 0x001767C8 File Offset: 0x001749C8
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value <= 0 && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value)
				{
					new bzs().ym(null, null, null);
				}
				else
				{
					c88 a_ = new c88(true);
					A_1.b(a_);
				}
			}
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_nagaActivated", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_e5_naga_died", new bool?(false)).Value)
			{
				d60 d = A_0.a();
				if (d != null)
				{
					c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
					{
						"xpbl_e5_damagedNaga"
					})) as c5x;
					if (c5x != null)
					{
						if (A_1.r().GetClassPropertyValue<string>("loc_xpbl_e5_nagaAttitude") != "ally")
						{
							if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
							{
								c5x.h.b.aa().a(null, null, false);
								return;
							}
							if (A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value || A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value)
							{
								A_1.a(new bw0("xpbl_d6", new b0v(), 1));
							}
							else if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_e5_leftNorth", new bool?(false)).Value)
							{
								A_1.a(new bw0("xpbl_d5", new b0v(), 1));
								serviceOrThrow.aqu().r()["loc_xpbl_nagaOnTheLoose"] = "d5";
							}
							else
							{
								A_1.a(new bw0("xpbl_e6", new b0v(), 1));
								serviceOrThrow.aqu().r()["loc_xpbl_nagaOnTheLoose"] = "e6";
							}
							c5x.an();
							c5x.w();
							return;
						}
						else if (c5x.h.b != null)
						{
							serviceOrThrow.aqu().r()["npc_xpbl_e5_naga_health"] = (double)c5x.h.b.aa().Defense.q().zo();
						}
					}
				}
			}
		}
	}
}
