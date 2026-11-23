using System;
using Microsoft.Xna.Framework;

// Token: 0x02001666 RID: 5734
public sealed class dlk : uu
{
	// Token: 0x06007D5B RID: 32091 RVA: 0x0034CC88 File Offset: 0x0034AE88
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		if (A_2.aa().b(d8o.e))
		{
			vr a_ = new vr(new ap9(A_2.aa()), null, "Лечебная мазь не повлияла на {0}", new Color?(adi.m), null);
			bey.a(a_, A_2.aa(), A_2);
			a7v.a(a_);
			return false;
		}
		c5x a_2 = A_2.a8();
		string a_3 = "Heal";
		int a_4 = 3;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? a_7 = dz6.b();
		a7j a_8 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
		A_2.a8().Zone.ActionManager.g9(a_8, atp.a);
		int val = (int)(A_2.aa().Defense.q().zm() - A_2.aa().Defense.q().zo());
		int a_9 = Math.Min(ezp.b(A_0), val);
		A_2.aa().Defense.a(a_9, (A_1 != null) ? A_1.aa() : null, A_0.b9(), true, false, false, null);
		ze a_10 = new ze(ezp.a(A_0), ezp.c * d0u.b, false);
		A_2.aa().StatusEffects.a(a_10, false, false, false);
		if (A_2.aa() is e3q)
		{
			d2o a_11 = new d2o();
			A_2.aa().StatusEffects.a(a_11, false, false, false);
		}
		return true;
	}
}
