using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02001671 RID: 5745
public sealed class eu6 : uu
{
	// Token: 0x06007D71 RID: 32113 RVA: 0x0034D6D8 File Offset: 0x0034B8D8
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		c5x c5x = A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			c5x a_ = c5x;
			string a_2 = "AdrenalineShotSpeedUp";
			int a_3 = 3;
			double maxValue = double.MaxValue;
			bool a_4 = false;
			bool a_5 = true;
			float? a_6 = dz6.b();
			boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			float a_7 = do0.e(A_0);
			float a_8 = do0.c(A_0);
			float a_9 = do0.b(A_0);
			int a_10 = do0.a();
			int num = do0.d(A_0);
			int a_11 = do0.a(A_0);
			if (!c5x.h.b.aa().StatusEffects.a(uj.a))
			{
				d4n d4n = dz6.b(c5x.h.b.aa());
				if (d4n != null)
				{
					d4n.c += (double)num;
				}
			}
			ab2 ab = Enumerable.FirstOrDefault<ab2>(c5x.h.b.aa().StatusEffects.Get<ab2>());
			int a_12;
			if (ab != null)
			{
				a_12 = (int)ab.TimeLeft * 2;
			}
			else
			{
				a_12 = 0;
			}
			c5x.h.b.aa().StatusEffects.d(ab);
			uj uj = new uj(a_7, a_8, a_9, a_10, a_12, num, a_11);
			amd a_13 = new amd(c5x.h.b, new els[]
			{
				uj
			});
			c5x.Zone.ActionManager.g9(a_13, atp.a);
			return true;
		}
		vr a_14 = new vr(new ap9(c5x.h.b.aa()), null, "Adrenaline shot had no effect on {0}", new Color?(adi.m), null);
		bey.a(a_14, c5x.h.b.aa(), c5x.h.b);
		a7v.a(a_14);
		return false;
	}
}
