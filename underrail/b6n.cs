using System;
using Microsoft.Xna.Framework;

// Token: 0x0200166E RID: 5742
public sealed class b6n : uu
{
	// Token: 0x06007D6B RID: 32107 RVA: 0x0034D488 File Offset: 0x0034B688
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			A_2.aa().StatusEffects.a(new kd(en4.a * d0u.b), false, false, false);
			return true;
		}
		vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "Supersoldier Drug had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_);
		return false;
	}
}
