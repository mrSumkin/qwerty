using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F2 RID: 5106
public sealed class dox : ay7
{
	// Token: 0x060072E8 RID: 29416 RVA: 0x003066C4 File Offset: 0x003048C4
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		A_3.x = AmmoType.SonicWave;
		A_0.a8().c().a("Xpbl_Sonocaster_st_attack");
		List<string> list = dxr.d();
		aig[] a_ = new aig[]
		{
			new cgw(A_0, A_1, A_0.aa().Offense.u(), false, 0.25, "xpbl_SoundGunWaveHitSmall", list.ToArray())
		};
		awq.a(A_0, A_1, A_3, A_2, new duk(list, A_5), true, null, "xpbl_SoundGunWave", a_, false, false, true, "xpbl_SoundGunWaveHit", null);
	}

	// Token: 0x060072E9 RID: 29417 RVA: 0x0030675C File Offset: 0x0030495C
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}
}
