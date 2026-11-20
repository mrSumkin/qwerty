using System;
using Microsoft.Xna.Framework;

// Token: 0x02001672 RID: 5746
public sealed class boz : uu
{
	// Token: 0x06007D73 RID: 32115 RVA: 0x0034D8C8 File Offset: 0x0034BAC8
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			awz a_ = new awz(d4t.a * d0u.b, 0.15);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "Aegis concoction had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
