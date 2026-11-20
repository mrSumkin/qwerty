using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using TimelapseVertigo.Rules;

// Token: 0x02000C80 RID: 3200
[eiz("PRRDE")]
[Serializable]
public sealed class anr : cd2
{
	// Token: 0x0600484B RID: 18507 RVA: 0x001D9D40 File Offset: 0x001D7F40
	private anr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x001D9D4C File Offset: 0x001D7F4C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x001D9D58 File Offset: 0x001D7F58
	public override TimeSpan ge()
	{
		return TimeSpan.FromSeconds(20.0);
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x001D9D68 File Offset: 0x001D7F68
	public override TimeSpan gf()
	{
		return TimeSpan.FromSeconds(0.0);
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x001D9D78 File Offset: 0x001D7F78
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x001D9D88 File Offset: 0x001D7F88
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x001D9D98 File Offset: 0x001D7F98
	public anr() : base(anr.a)
	{
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x001D9DA8 File Offset: 0x001D7FA8
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0) && (!A_0.r().GetPrimitivePropertyValue<bool>("quests_xpbl_pirates_secondRaid_shipCleared", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value);
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x001D9E0C File Offset: 0x001D800C
	protected override void gg(cyt A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		gx gx = new gx();
		if (serviceOrThrow.aqu() != null)
		{
			int num = 3;
			int num2 = 0;
			if (A_0.ae() >= GameDifficulty.Dominating)
			{
				num = 5;
			}
			else if (A_0.ae() == GameDifficulty.Hard)
			{
				num = 4;
			}
			else if (A_0.ae() == GameDifficulty.Easy)
			{
				num = 2;
			}
			List<cze> list = new List<cze>();
			x6 x = new x6();
			x.a(true);
			x.a(1);
			x.a("faction_protectorate_coreCity_jetSkiersKilled");
			list.Add(x);
			List<cze> a_ = list;
			foreach (csd csd in Enumerable.ToList<csd>(serviceOrThrow.aqw().Waypoints))
			{
				if (num <= 0)
				{
					break;
				}
				if (csd.Name.StartsWith("cruiserSpawn") && aw1.a(new bt4(csd.Name), A_0.v().b().Area, l9.b))
				{
					c5x c5x = gx.a(csd, new int?(15), "Protectorate_Jetski", null, asp.bg, null, "support\\xpbl\\pr_jetPatrols1", false, a_, false);
					if (c5x != null)
					{
						c5x.b("Despawn");
						num--;
						if (c5x.t.b != null)
						{
							PropertyCollection propertyCollection = c5x.t.b.y6();
							string ay = ddq.ay;
							string str = "cruiserGuard";
							int num3;
							num2 = (num3 = num2 + 1);
							propertyCollection[ay] = new bt4(str + num3.ToString());
						}
						if (c5x.h.b != null)
						{
							c5x.h.b.aa().FactionId = asp.bt;
						}
					}
				}
			}
			A_0.r()["loc_cvw_21_spawnedProtectorateReinforcements"] = true;
		}
	}

	// Token: 0x04001CB2 RID: 7346
	public new static readonly string a = "protectorateRaidReinforcements";
}
