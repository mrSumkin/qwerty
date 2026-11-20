using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001668 RID: 5736
public sealed class bv8 : uu
{
	// Token: 0x06007D5F RID: 32095 RVA: 0x0034CEF4 File Offset: 0x0034B0F4
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		List<a5e> list = A_0.b8().StatusEffects.Get<a5e>();
		if (A_0.b8().c(d8o.e))
		{
			vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "Coagulation shot had no effect on {0}", new Color?(adi.m), null);
			bey.a(a_, c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			return false;
		}
		if (list.Count > 0)
		{
			boj.a(c5x, "HealBleed", 1, double.MaxValue, true, true, null, null, null, null, false);
			int num = cyy.a;
			while (num > 0 && list.Count > 0)
			{
				a5e a5e = list[cuo.a.Next(list.Count)];
				list.Remove(a5e);
				A_0.b8().StatusEffects.d(a5e);
				num--;
			}
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "{0} не имеет кровоточащих ран.", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
