using System;
using TimelapseVertigo.Rules;

// Token: 0x020007CF RID: 1999
public sealed class du4 : cm9
{
	// Token: 0x06003221 RID: 12833 RVA: 0x00134910 File Offset: 0x00132B10
	public double ot()
	{
		return 1000.0;
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x0013491C File Offset: 0x00132B1C
	public void ou(cnk A_0)
	{
		if (dk2.e() && A_0 != null && A_0.aqu() != null && A_0.aqw() != null && !string.IsNullOrEmpty(A_0.aqw().y8()) && A_0.aqw().y8().StartsWith("xphw_exo") && A_0.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_count_max", null) != null && !A_0.aqu().r().GetPrimitivePropertyValue<bool>("faction_xphw_exoBase_superSoldiers_stopDeployment", new bool?(false)).Value)
		{
			int value = A_0.aqu().r().GetPrimitivePropertyValue<int>("faction_xphw_exoBase_exosoldiers_killed", new int?(0)).Value;
			if (value > 0)
			{
				TimeSpan? primitivePropertyValue = A_0.aqu().r().GetPrimitivePropertyValue<TimeSpan>("faction_xphw_exoBase_exosoldiers_timeOfFirstCasualty", null);
				if (primitivePropertyValue == null)
				{
					primitivePropertyValue = new TimeSpan?(A_0.aqu().p());
					A_0.aqu().r()["faction_xphw_exoBase_exosoldiers_timeOfFirstCasualty"] = primitivePropertyValue;
				}
				float num = (float)value / (float)(A_0.aqu().p().TotalMinutes - primitivePropertyValue.Value.TotalMinutes);
				A_0.aqu().r()["faction_xphw_exoBase_exosoldiers_casualtiesPerMinute"] = num;
			}
			float value2 = A_0.aqu().r().GetPrimitivePropertyValue<float>("faction_xphw_exoBase_alarmLevel", new float?((float)1)).Value;
			float num2 = value2 + 0.02f;
			float num3 = value2 + 0.005f;
			bu6 service = bpo.GetService<bu6>();
			if (service != null)
			{
				if (service.aq2() >= GameDifficulty.Dominating)
				{
					num2 += 0.03f;
					num3 -= 0.002f;
				}
				else if (service.aq2() == GameDifficulty.Hard)
				{
					num2 += 0.01f;
					num3 -= 0.001f;
				}
				else if (service.aq2() == GameDifficulty.Easy)
				{
					num2 -= 0.05f;
					num3 += 0.003f;
				}
			}
			if (A_0.aqu().v() != null && A_0.aqu().v().IsInCombat && value2 <= 5f)
			{
				A_0.aqu().r()["faction_xphw_exoBase_alarmLevel"] = Math.Min(5f, num2);
				return;
			}
			if (value2 > 1f)
			{
				A_0.aqu().r()["faction_xphw_exoBase_alarmLevel"] = Math.Max(1f, num3);
			}
		}
	}
}
