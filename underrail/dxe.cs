using System;
using Microsoft.Xna.Framework;

// Token: 0x02001679 RID: 5753
public sealed class dxe : uu
{
	// Token: 0x06007D81 RID: 32129 RVA: 0x0034E1B8 File Offset: 0x0034C3B8
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		if (A_2.aa().b(d8o.e))
		{
			vr a_ = new vr(new ap9(A_2.aa()), null, "{0} не получает эффекта от стимулятора", new Color?(adi.m), null);
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
		int num = (int)(A_2.aa().Defense.q().zm() - A_2.aa().Defense.q().zo());
		int a_9 = (int)Math.Min((double)cwn.a(A_0) * 0.5, (double)num);
		A_2.aa().Defense.a(a_9, (A_1 != null) ? A_1.aa() : null, A_0.b9(), true, false, false, null);
		return true;
	}
}
