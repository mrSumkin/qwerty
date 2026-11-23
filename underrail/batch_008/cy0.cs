using System;
using Microsoft.Xna.Framework;

// Token: 0x0200166F RID: 5743
public sealed class cy0 : uu
{
	// Token: 0x06007D6D RID: 32109 RVA: 0x0034D544 File Offset: 0x0034B744
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			ze a_ = new ze(a2s.a(A_0), a2s.a * d0u.b, true);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Регенеративная смесь не повлияла на {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
