using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F4 RID: 5108
public class ajv : ay7
{
	// Token: 0x060072EF RID: 29423 RVA: 0x00306BE4 File Offset: 0x00304DE4
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

	// Token: 0x060072F0 RID: 29424 RVA: 0x00306C60 File Offset: 0x00304E60
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}
}
