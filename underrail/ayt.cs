using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02001670 RID: 5744
public sealed class ayt : uu
{
	// Token: 0x06007D6F RID: 32111 RVA: 0x0034D614 File Offset: 0x0034B814
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			adg adg = Enumerable.FirstOrDefault<adg>(A_2.aa().StatusEffects.Get<adg>());
			if (adg != null)
			{
				A_2.aa().StatusEffects.d(adg);
			}
			return true;
		}
		vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "Psi Reinvigorator pill had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_);
		return false;
	}
}
