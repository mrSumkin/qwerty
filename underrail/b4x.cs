using System;
using Microsoft.Xna.Framework;

// Token: 0x02001673 RID: 5747
public sealed class b4x : uu
{
	// Token: 0x06007D75 RID: 32117 RVA: 0x0034D998 File Offset: 0x0034BB98
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e) && !A_0.b8().StatusEffects.a(duj.a))
		{
			cqr a_ = new cqr(avr.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Hercules had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
