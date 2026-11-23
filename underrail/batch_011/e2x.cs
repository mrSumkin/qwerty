using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000B18 RID: 2840
[eiz("XPBLSCSFJ")]
[Serializable]
public sealed class e2x : cze, ISerializable
{
	// Token: 0x060041A5 RID: 16805 RVA: 0x00194254 File Offset: 0x00192454
	private e2x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x00194260 File Offset: 0x00192460
	public e2x()
	{
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x0019426C File Offset: 0x0019246C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bu6 service = bpo.GetService<bu6>();
		if (serviceOrThrow.aqu() != null && service != null)
		{
			int num;
			if (service.aq2() >= GameDifficulty.Hard)
			{
				num = 30;
			}
			else if (service.aq2() == GameDifficulty.Normal)
			{
				num = 35;
			}
			else
			{
				num = 40;
			}
			serviceOrThrow.aqu().r()["faction_xpbl_expedition_jetSkiStrength"] = 4;
			serviceOrThrow.aqu().r()["faction_xpbl_expedition_weaponSupply"] = 4;
			serviceOrThrow.aqu().r()["faction_xpbl_expedition_techSupply"] = 4;
			serviceOrThrow.aqu().r()["faction_xpbl_expedition_medicineSupply"] = 4;
			serviceOrThrow.aqu().r()["global_xpbl_aegisSecTroopersAvailable"] = num;
			serviceOrThrow.aqu().r()["global_xpbl_aegisSecTroopersStartedWith"] = num;
		}
	}
}
