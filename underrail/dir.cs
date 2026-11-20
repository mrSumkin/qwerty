using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F5 RID: 5109
public class dir : ay7
{
	// Token: 0x060072F2 RID: 29426 RVA: 0x00306C6C File Offset: 0x00304E6C
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

	// Token: 0x060072F3 RID: 29427 RVA: 0x00306CE8 File Offset: 0x00304EE8
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}
}
