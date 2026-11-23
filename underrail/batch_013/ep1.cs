using System;
using System.Runtime.Serialization;

// Token: 0x02000A37 RID: 2615
[eiz("XPBLLECIPWOC")]
[Serializable]
public sealed class ep1 : bdw, ISerializable
{
	// Token: 0x06003E0F RID: 15887 RVA: 0x00175A74 File Offset: 0x00173C74
	private ep1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E10 RID: 15888 RVA: 0x00175A7C File Offset: 0x00173C7C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E11 RID: 15889 RVA: 0x00175A80 File Offset: 0x00173C80
	public ep1()
	{
	}

	// Token: 0x06003E12 RID: 15890 RVA: 0x00175A8C File Offset: 0x00173C8C
	public void av(c1a A_0, cyt A_1)
	{
		if (!A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionUndeployed", new bool?(false)).Value && dh7.a != null && dh7.a.c != null)
		{
			if (A_1.r().GetPrimitivePropertyValue<bool>("loc_xpbl_le_camp_wipedOut", new bool?(false)).Value || (A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_doc_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_marcus_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ladelman_dead", new bool?(false)).Value && A_1.r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value <= 0))
			{
				if (dh7.a.c.Equals("xpbl_d5") || dh7.a.c.Equals("xpbl_d6") || dh7.a.c.Equals("xpbl_e6"))
				{
					return;
				}
				A_1.r()["global_xpbl_expeditionDestroyed"] = true;
				return;
			}
			else if (A_1.r().GetPrimitivePropertyValue<bool>("global_beginExpedition", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_completed", new bool?(false)).Value && !A_1.r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_betrayed", new bool?(false)).Value)
			{
				if (dh7.a.c.Equals("xpbl_d5") || dh7.a.c.Equals("xpbl_d6") || dh7.a.c.Equals("xpbl_e6") || dh7.a.c.Equals("xpbl_e5"))
				{
					return;
				}
				if (!A_1.r().GetPrimitivePropertyValue<bool>("quest_xpbl_savageInvasion_started", new bool?(false)).Value)
				{
					new qj().ym(A_1.v().b(), null, null);
					c88 a_ = new c88(false);
					A_1.b(a_);
				}
				bv9 bv = A_1.ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.f5, asp.a, h.a, null, true, false, false);
					bv.a(asp.f7, asp.a, h.a, null, true, false, false);
					bv.a(asp.f6, asp.a, h.a, null, true, false, false);
					A_1.r()["faction_xpbl_aegis_betrayed"] = true;
					A_1.r()["loc_xpbl_camp_allowed"] = false;
				}
			}
		}
	}
}
