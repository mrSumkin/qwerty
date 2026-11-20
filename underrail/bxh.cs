using System;
using System.Collections.Generic;

// Token: 0x02000BB2 RID: 2994
[euj]
public class bxh
{
	// Token: 0x06004411 RID: 17425 RVA: 0x001ADF8C File Offset: 0x001AC18C
	[ayh("GCGJRCS")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			float num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<float>("gp_crps", new float?(0f)).Value;
			int a_ = c2h.a(aiy.af, 15, (double)aiy.ag);
			double num2 = 1.05 - euf.d(a_, serviceOrThrow.aqu().v());
			num = d05.b(0.1f, Convert.ToSingle((double)num * num2), 1f);
			serviceOrThrow.aqu().r()["gp_crps"] = num;
		}
	}
}
