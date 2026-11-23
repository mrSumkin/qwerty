using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001405 RID: 5125
public sealed class c1d : ay7
{
	// Token: 0x06007326 RID: 29478 RVA: 0x0030898C File Offset: 0x00306B8C
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		this.ae(A_0, A_1, A_2, A_4);
		awq.a(A_0, A_1, A_3, A_2, A_5, true, null, null, null, false, false, true, null, null);
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x003089C4 File Offset: 0x00306BC4
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
		int num = A_2.CustomProperties.GetPrimitivePropertyValue<int>("Shots", new int?(0)).Value + 1;
		A_2.CustomProperties["Shots"] = num;
		if (num > 10 && A_0 != null && A_0.a8() != null && A_0.a8().Area != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["quests_tch_georgis_testChemicalWeapon_malfunction"] = true;
			}
			cmn a_ = awq.a(A_0, A_0, null, null);
			cwt a_2 = euf.a(A_0.aa(), A_0.aa(), 0.0, a_, 0.0, A_0.a8().l(), false, A_3, false, 1.0, true, null, null, true, null);
			awq.a(A_0, A_0, a_2, A_2, null, true, null, null, null, false, false, true, null, null);
		}
	}
}
