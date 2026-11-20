using System;
using System.Collections.Generic;

// Token: 0x0200167B RID: 5755
public static class awu
{
	// Token: 0x06007D85 RID: 32133 RVA: 0x0034E4B8 File Offset: 0x0034C6B8
	static awu()
	{
		awu.a["technomedicHealthHypo"] = new bm2();
		awu.a["miniHealthHypo"] = new dxe();
		awu.a["healthHypo"] = new edu();
		awu.a["morphineShot"] = new d4a();
		awu.a["nervosomnifer"] = new b8l();
		awu.a["adrenalineShot"] = new eu6();
		awu.a["irongut"] = new eev();
		awu.a["trance"] = new bcv();
		awu.a["aegis"] = new boz();
		awu.a["focusStim"] = new cmo();
		awu.a["jumpingBean"] = new e8f();
		awu.a["hercules"] = new b4x();
		awu.a["bullhead"] = new cd9();
		awu.a["psiReinvigorator"] = new ayt();
		awu.a["regenerativeMixture"] = new cy0();
		awu.a["psionicAccelerator"] = new dp8();
		awu.a["supersoldierDrug"] = new b6n();
		awu.a["theJuice"] = new qc();
		awu.a["hypercerebrix"] = new ar5();
		awu.a["coagulationShot"] = new bv8();
		awu.a["twitch"] = new b8a();
		awu.a["thirdEye"] = new dbs();
		awu.a["healingSalve"] = new dlk();
		awu.a["spiritPotion"] = new d9k();
		awu.a["vitalityPowder"] = new he();
		awu.a["bioluminousSwampHoney"] = new c95();
		awu.a["antidote"] = new et3();
		awu.a["psiBooster"] = new bzu();
		awu.a["statBooster"] = new ayr();
	}

	// Token: 0x06007D86 RID: 32134 RVA: 0x0034E714 File Offset: 0x0034C914
	public static a4x a(string A_0)
	{
		a4x result;
		awu.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x04003192 RID: 12690
	private static readonly Dictionary<string, a4x> a = new Dictionary<string, a4x>();
}
