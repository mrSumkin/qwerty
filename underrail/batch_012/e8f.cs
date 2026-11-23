using System;
using Microsoft.Xna.Framework;

// Token: 0x02001675 RID: 5749
public sealed class e8f : uu
{
	// Token: 0x06007D79 RID: 32121 RVA: 0x0034DB3C File Offset: 0x0034BD3C
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			c5x a_ = c5x;
			string a_2 = "AdrenalineShotSpeedUp";
			int a_3 = 3;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			if (!c5x.h.b.aa().SpecialStates.g && c5x.h.b.aa().Vehicle == null && !c5x.h.b.aa().StatusEffects.a(al0.a))
			{
				d4n d4n = dz6.b(c5x.h.b.aa());
				if (d4n != null)
				{
					d4n.d += (double)al0.c;
				}
			}
			al0 a_7 = new al0(b0z.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_7, false, false, false);
			return true;
		}
		vr a_8 = new vr(new ap9(c5x.h.b.aa()), null, "Jumping bean had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_8, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_8);
		return false;
	}
}
