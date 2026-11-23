using System;
using Microsoft.Xna.Framework;

// Token: 0x02001674 RID: 5748
public sealed class cmo : uu
{
	// Token: 0x06007D77 RID: 32119 RVA: 0x0034DA74 File Offset: 0x0034BC74
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			j3 a_ = new j3(drq.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Focus stim had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
