using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F6 RID: 5110
public class dab : ay7
{
	// Token: 0x060072F5 RID: 29429 RVA: 0x00306CF4 File Offset: 0x00304EF4
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_0 != null && A_1 != null)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			qy.ad().Add(new bm3(dz6.b(300)));
			qy.ad().Add(new cdp(A_0, A_1, A_3, A_2));
			A_0.a8().Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
	}

	// Token: 0x060072F6 RID: 29430 RVA: 0x00306D70 File Offset: 0x00304F70
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}
}
