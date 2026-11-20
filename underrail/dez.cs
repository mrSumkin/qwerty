using System;
using System.Collections.Generic;

// Token: 0x02001809 RID: 6153
[euj]
public sealed class dez
{
	// Token: 0x060082C9 RID: 33481 RVA: 0x0036D3A8 File Offset: 0x0036B5A8
	[ayh("COEXAT")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.IsPlayer)
		{
			amc aspect = A_1.GetAspect<amc>();
			if (aspect != null && aspect.aa().Gear.l().Item != null)
			{
				aspect.aa().Gear.l().Item.a((double)bem.f, true);
			}
		}
	}

	// Token: 0x060082CA RID: 33482 RVA: 0x0036D410 File Offset: 0x0036B610
	[ayh("COEXAM")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.IsPlayer)
		{
			amc aspect = A_1.GetAspect<amc>();
			if (aspect != null && aspect.aa().Gear.l().Item != null && aspect.aa().Gear.l().Item.Battery > 0.0)
			{
				float num = 0f;
				object obj;
				if (A_2 != null && A_2.TryGetValue("distance", out obj) && obj is float)
				{
					float num2 = (float)obj;
					num = num2;
				}
				double num3 = (double)(bem.g * num);
				if (num3 > 0.0)
				{
					aspect.aa().Gear.l().Item.a(num3, true);
				}
			}
		}
	}
}
