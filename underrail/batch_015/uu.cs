using System;
using System.Linq;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200165D RID: 5725
public abstract class uu : a4x
{
	// Token: 0x06007D4A RID: 32074 RVA: 0x0034BD18 File Offset: 0x00349F18
	public virtual bool gu(cnm A_0, amc A_1, amc A_2)
	{
		A_2.a8();
		if (!A_0.b8().c(d8o.e))
		{
			bek bek = Enumerable.FirstOrDefault<bek>(A_2.aa().StatusEffects.Get<bek>());
			if (bek != null)
			{
				c5x a_ = A_2.a8();
				string a_2 = "ToxicSmoke";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
				cwt cwt = new cwt();
				cwt.i = null;
				cwt.j = new ap9(A_2.aa());
				cwt.p = true;
				cwt.l = true;
				cwt.f.Add(new csk(DamageType.Bio, bek.Power));
				cwt.b = true;
				cwt.v = "аллергическая реакция";
				cwt.w = true;
				if (A_2.aa().Defense.a(cwt).c)
				{
					return false;
				}
				eok a_7 = new eok(bek.b * d0u.b);
				A_2.aa().StatusEffects.a(a_7, false, false, false);
			}
		}
		return true;
	}
}
