using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013F9 RID: 5113
public sealed class adu : bcb
{
	// Token: 0x060072FF RID: 29439 RVA: 0x0030715C File Offset: 0x0030535C
	protected override void of(qy A_0, amc A_1, amc A_2, cd1 A_3, cwt A_4, AmmoType A_5)
	{
		c5x a_ = A_1.a8();
		string a_2 = "xpbl_Naga_Shoot";
		int a_3 = 3;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		float? a_6 = dz6.b();
		c5x c5x = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
		if (c5x != null && c5x.o.b != null)
		{
			c5x.o.b.b = new Point(c5x.o.b.b.X, A_1.a8().ac);
		}
	}
}
