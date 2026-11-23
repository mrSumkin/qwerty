using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B9F RID: 2975
[eiz("XPBLE3AJ")]
[Serializable]
public sealed class c7v : cze, ISerializable
{
	// Token: 0x060043A4 RID: 17316 RVA: 0x001A9054 File Offset: 0x001A7254
	private c7v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043A5 RID: 17317 RVA: 0x001A9060 File Offset: 0x001A7260
	public c7v()
	{
	}

	// Token: 0x060043A6 RID: 17318 RVA: 0x001A906C File Offset: 0x001A726C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			ps serviceOrThrow2 = bpo.GetServiceOrThrow<ps>();
			if (serviceOrThrow.aqu() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_e3_turnsRemaining", new int?(0)).Value;
				if (c5x != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_playerThrownInJail", new bool?(false)).Value)
				{
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_setRescueSpawnDelay", new bool?(false)).Value)
					{
						num = 90;
						serviceOrThrow.aqu().r()["loc_xpbl_e3_setRescueSpawnDelay"] = true;
					}
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_setRescueSpawnDelay", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_spawnedRescue", new bool?(false)).Value)
					{
						d2b aspect = new ar7(new Guid("a5d50f06-2c28-4228-a7e4-13df0ff0dae0"), aud).ao().GetAspect<d2b>();
						if (num > 0)
						{
							serviceOrThrow.aqu().r()["loc_xpbl_e3_turnsRemaining"] = num - 1;
							return;
						}
						if (aspect != null && aspect.n())
						{
							if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value)
							{
								new bzs().ym(null, null, null);
							}
							if (serviceOrThrow2 != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("global_xpbl_expeditionDestroyed", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("global_xpbl_aegisSecTroopersAvailable", new int?(0)).Value > 3 && c5x.h.b != null && !c5x.h.b.aa().IsInCombat)
							{
								serviceOrThrow2.am3("Xpbl_Pir_RescueArrivesToPrison");
								serviceOrThrow.aqu().r()["loc_xpbl_e3_spawnedRescue"] = true;
							}
						}
					}
				}
			}
		}
	}
}
