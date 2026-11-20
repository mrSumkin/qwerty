using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001401 RID: 5121
public sealed class dkt : ay7
{
	// Token: 0x0600731B RID: 29467 RVA: 0x0030864C File Offset: 0x0030684C
	public void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		c5x a_ = A_0.a8();
		string a_2 = "ShockTurretAttack";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		float? a_6 = dz6.b();
		c5x c5x = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
		if (c5x != null && c5x.o.b != null)
		{
			c5x.o.b.b = new Point(c5x.o.b.b.X, A_0.a8().ac);
		}
		awq.a(A_0, A_1, A_3, A_2, null, true, null, null, null, false, false, true, null, null);
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x00308708 File Offset: 0x00306908
	public void ae(amc A_0, amc A_1, cd1 A_2, AmmoType A_3)
	{
	}
}
