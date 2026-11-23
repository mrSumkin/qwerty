using System;
using Microsoft.Xna.Framework;

// Token: 0x0200165C RID: 5724
public sealed class c95 : uu
{
	// Token: 0x06007D48 RID: 32072 RVA: 0x0034BC50 File Offset: 0x00349E50
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			cw0 a_ = new cw0(cu7.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Биолюминесцентны болтный мёд не повлиял на {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
