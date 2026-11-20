using System;
using Microsoft.Xna.Framework;

// Token: 0x02001665 RID: 5733
public sealed class d9k : uu
{
	// Token: 0x06007D59 RID: 32089 RVA: 0x0034CA3C File Offset: 0x0034AC3C
	public override bool gu(cnm A_0, amc A_1, amc A_2)
	{
		if (!base.gu(A_0, A_1, A_2))
		{
			return false;
		}
		if (A_2.aa().b(d8o.e))
		{
			vr a_ = new vr(new ap9(A_2.aa()), null, "Зелье духа не повлияло на {0}", new Color?(adi.m), null);
			bey.a(a_, A_2.aa(), A_2);
			a7v.a(a_);
			return false;
		}
		a7j a_2 = new a7j(A_2.a8(), "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, A_2.a8().Size.Z)), new float?(0.7f), new int?(30), dz6.b(), false, null);
		A_2.a8().Zone.ActionManager.g9(a_2, atp.a);
		a7j a_3 = new a7j(A_2.a8(), "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, A_2.a8().Size.Z)), new float?(0.5f), new int?(45), dz6.b(), false, null);
		A_2.a8().Zone.ActionManager.g9(a_3, atp.a);
		a7j a_4 = new a7j(A_2.a8(), "BluePsiBuff", 2, double.MaxValue, false, true, new Vector3?(new Vector3(0f, 0f, A_2.a8().Size.Z)), new float?(0.3f), new int?(60), dz6.b(), false, null);
		A_2.a8().Zone.ActionManager.g9(a_4, atp.a);
		A_2.aa().Offense.d(bai.a, true);
		jm a_5 = new jm(bai.b, bai.c * d0u.b, false);
		A_2.aa().StatusEffects.a(a_5, false, false, false);
		if (A_2.aa() is e3q)
		{
			a87 a_6 = new a87();
			A_2.aa().StatusEffects.a(a_6, false, false, false);
		}
		return true;
	}
}
