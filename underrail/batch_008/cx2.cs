using System;
using System.Collections.Generic;

// Token: 0x02001156 RID: 4438
public static class cx2
{
	// Token: 0x06005F11 RID: 24337 RVA: 0x00284274 File Offset: 0x00282474
	static cx2()
	{
		cx2.a["poisonedGas"] = new c21();
		cx2.a["cryogas"] = new b8g();
		cx2.a["zombieMutagenGas"] = new a7x();
		cx2.a["psimorphicBiocide"] = new bvo();
		cx2.a["spores"] = new bdq();
		cx2.a["herbicideGas"] = new aez();
		cx2.a["hiveGas"] = new bzn();
		cx2.a["leperGas"] = new ec7();
		cx2.a["chemhazeGas"] = new c9q();
		cx2.a["whitePhosphorusGas"] = new wc();
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x00284354 File Offset: 0x00282554
	public static p7 a(string A_0)
	{
		p7 result;
		cx2.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x040025D8 RID: 9688
	private static Dictionary<string, p7> a = new Dictionary<string, p7>();
}
