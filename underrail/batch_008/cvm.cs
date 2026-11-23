using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001349 RID: 4937
[d50(car.i)]
public sealed class cvm : bb0
{
	// Token: 0x06006FC2 RID: 28610 RVA: 0x002EDBBC File Offset: 0x002EBDBC
	public void b0(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
		bool flag = false;
		if (A_2 != null)
		{
			flag = (A_2.CustomProperties.GetPrimitivePropertyValue<int>("FirePhase", new int?(1)).Value == 1);
		}
		if (flag)
		{
			dzo.a(A_0.a8(), "plsen_ll", true, null);
			return;
		}
		dzo.a(A_0.a8(), "plsen_lr", true, null);
	}
}
