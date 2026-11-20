using System;
using System.Collections.Generic;

// Token: 0x02001404 RID: 5124
public static class ckf
{
	// Token: 0x06007324 RID: 29476 RVA: 0x003087B0 File Offset: 0x003069B0
	static ckf()
	{
		ckf.a["iceProjectile"] = new dem();
		ckf.a["incendiaryBlob"] = new e5p();
		ckf.a["xal-001"] = new c1d();
		ckf.a["shockTurret"] = new dkt();
		ckf.a["sporeProjectile"] = new bfs();
		ckf.a["shotgun"] = new ec6();
		ckf.a["nagaProtectorFusionCannon"] = new adu();
		ckf.a["humanFusionCannon"] = new ewy();
		ckf.a["seaWyrm"] = new dab();
		ckf.a["heartbreakerSerpent"] = new dir();
		ckf.a["strider"] = new ajv();
		ckf.a["soundGun"] = new dox();
		ckf.a["chopChop"] = new d27();
		ckf.a["blackArrow"] = new dly(false);
		ckf.a["blackArrow_rf"] = new dly(true);
		ckf.a["grenadeLauncher"] = new du8();
		ckf.a["rocketLauncher"] = new ckp();
		ckf.a["machineGun"] = new bo5();
		ckf.a["minigun"] = new a7u();
		ckf.a["bostonBotCold"] = new cva();
	}

	// Token: 0x06007325 RID: 29477 RVA: 0x0030895C File Offset: 0x00306B5C
	public static ay7 a(string A_0)
	{
		ay7 result;
		if (!string.IsNullOrEmpty(A_0) && ckf.a.TryGetValue(A_0, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x04002F0D RID: 12045
	private static Dictionary<string, ay7> a = new Dictionary<string, ay7>();
}
