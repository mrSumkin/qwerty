using System;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001342 RID: 4930
[d50(car.e)]
public sealed class z : bb0
{
	// Token: 0x06006FB2 RID: 28594 RVA: 0x002ED81C File Offset: 0x002EBA1C
	public void b0(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
		if (++z.a > 999)
		{
			z.a = 0;
		}
		dzo.a(A_0.a8(), "sm_Fire", true, null);
		dzo.a(A_0.a8(), "sm_Smoke" + ((z.a % 2 == 0) ? "" : "1"), false, null);
		double num = A_0.a8().l();
		float value = Convert.ToSingle(Math.Max(0.20000000298023224, (1.0 - num) * 0.6000000238418579));
		dzo.a(A_0.a8(), "sm_Flash", true, new float?(value));
	}

	// Token: 0x04002D9D RID: 11677
	private static int a;
}
