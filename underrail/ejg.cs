using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000BA0 RID: 2976
[eiz("XPBLG2ISAJ")]
[Serializable]
public sealed class ejg : cze, ISerializable
{
	// Token: 0x060043A7 RID: 17319 RVA: 0x001A92F4 File Offset: 0x001A74F4
	private ejg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043A8 RID: 17320 RVA: 0x001A9300 File Offset: 0x001A7500
	public ejg()
	{
	}

	// Token: 0x060043A9 RID: 17321 RVA: 0x001A930C File Offset: 0x001A750C
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
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g2_innerShip_spawnedReinforcements", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g2_piratesCleared", new bool?(false)).Value)
			{
				cky cky = (serviceOrThrow.aqu().ac() as bv9).abu(asp.a, asp.fr);
				int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_g2_innerShip_turnsRemaining", new int?(0)).Value;
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g2_innerShip_setReinforcementSpawnDelay", new bool?(false)).Value && cky.a == h.a)
				{
					bu6 service = bpo.GetService<bu6>();
					num = 2;
					if (service != null)
					{
						if (service.aq2() >= GameDifficulty.Dominating)
						{
							num = 0;
						}
						else if (service.aq2() >= GameDifficulty.Normal)
						{
							num = 1;
						}
					}
					serviceOrThrow.aqu().r()["loc_xpbl_g2_innerShip_setReinforcementSpawnDelay"] = true;
					serviceOrThrow.aqu().r()["loc_xpbl_g2_innerShip_turnsRemaining"] = num;
				}
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g2_innerShip_setReinforcementSpawnDelay", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g2_innerShip_spawnedReinforcements", new bool?(false)).Value)
				{
					if (num > 0)
					{
						serviceOrThrow.aqu().r()["loc_xpbl_g2_innerShip_turnsRemaining"] = num - 1;
						return;
					}
					csd csd = serviceOrThrow.aqw().g("pirate1");
					csd csd2 = serviceOrThrow.aqw().g("pirate2");
					gx gx = new gx();
					if (gx != null)
					{
						if (csd != null && !aw1.a(null, csd.Tile, false, null))
						{
							gx.a(csd, new int?(16), "Pirates", null, null, null, null, false, null, false);
						}
						if (csd2 != null && !aw1.a(null, csd2.Tile, false, null))
						{
							gx.a(csd2, new int?(16), "Pirates", null, null, null, null, false, null, false);
						}
						bfq bfq = new bfq("door", "HollowEarthPointBunkerOpen");
						bfq.a(true);
						bfq.a(c9z.b);
						bfq.d(false);
					}
					serviceOrThrow.aqu().r()["loc_xpbl_g2_innerShip_spawnedReinforcements"] = true;
				}
			}
		}
	}
}
