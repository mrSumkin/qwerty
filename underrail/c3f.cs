using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02001133 RID: 4403
[euj]
public sealed class c3f
{
	// Token: 0x06005E37 RID: 24119 RVA: 0x0027EE70 File Offset: 0x0027D070
	[ayh("MotionWithdrawalAggregatorExpires")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null)
		{
			eyr eyr = A_2["StatusEffect"] as eyr;
			if (eyr != null && A_1 != null && A_1.h.b != null && !A_1.h.b.aa().Dead)
			{
				byf byf = new byf();
				byf.Stacks = Math.Min(eyr.a, byf.MaxStacks);
				A_1.h.b.aa().StatusEffects.a(byf, false, false, false);
				y4 y = Enumerable.FirstOrDefault<y4>(A_1.h.b.aa().StatusEffects.Get<y4>());
				if (y != null)
				{
					A_1.h.b.aa().StatusEffects.d(y);
				}
			}
		}
	}
}
