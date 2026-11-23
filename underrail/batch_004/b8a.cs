using System;
using Microsoft.Xna.Framework;

// Token: 0x0200166A RID: 5738
public sealed class b8a : uu
{
	// Token: 0x06007D63 RID: 32099 RVA: 0x0034D158 File Offset: 0x0034B358
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			doe a_ = new doe(rg.a * d0u.b, rg.b);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Twitch had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
