using System;
using Microsoft.Xna.Framework;

// Token: 0x02001669 RID: 5737
public sealed class dbs : uu
{
	// Token: 0x06007D61 RID: 32097 RVA: 0x0034D090 File Offset: 0x0034B290
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			d62 a_ = new d62(dfk.a * d0u.b);
			c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}
		vr a_2 = new vr(new ap9(c5x.h.b.aa()), null, "{0} не получает эффекта от препарата \"Третий глаз\"", new Color?(adi.m), null);
		bey.a(a_2, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_2);
		return false;
	}
}
