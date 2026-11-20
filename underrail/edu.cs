using System;
using Microsoft.Xna.Framework;

// Token: 0x0200167A RID: 5754
public sealed class edu : uu
{
	// Token: 0x06007D83 RID: 32131 RVA: 0x0034E30C File Offset: 0x0034C50C
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
		int val = (int)(A_2.aa().Defense.q().zm() - A_2.aa().Defense.q().zo());
		bool flag = cwn.b(A_0);
		bool flag2 = false;
		if (flag)
		{
			flag2 = (cuo.a.NextDouble() < cy9.a);
		}
		c5x a_2 = A_2.a8();
		string a_3 = "Heal";
		int a_4 = flag2 ? 6 : 3;
		double maxValue = double.MaxValue;
		bool a_5 = true;
		bool a_6 = true;
		float? num = new float?(dz6.b().GetValueOrDefault(1f) * (flag2 ? 0.5f : 1f));
		a7j a_7 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, num, false, null);
		A_2.a8().Zone.ActionManager.g9(a_7, atp.a);
		int num2 = Math.Min(cwn.a(A_0) * (flag2 ? 2 : 1), val);
		nw nw = A_2.aa().Defense;
		int a_8 = num2;
		efk a_9 = (A_1 != null) ? A_1.aa() : null;
		object a_10 = A_0.b9();
		bool a_11 = true;
		bool a_12 = false;
		bool a_13 = flag2;
		num = null;
		nw.a(a_8, a_9, a_10, a_11, a_12, a_13, num);
		return true;
	}
}
