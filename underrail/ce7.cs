using System;
using System.Collections.Generic;

// Token: 0x02001135 RID: 4405
[euj]
public sealed class ce7
{
	// Token: 0x06005E3D RID: 24125 RVA: 0x0027F2BC File Offset: 0x0027D4BC
	[ayh("OnStasisRemoved")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null || A_1.Area == null || A_1.j != cgy.b)
		{
			return;
		}
		object obj;
		if (A_2 != null && A_2.TryGetValue("StatusEffect", out obj))
		{
			amy amy = obj as amy;
			if (amy != null && amy.TimeLeft > 0.0)
			{
				string a_ = "xpbl_TempStasisBreakBack";
				int a_2 = 1;
				double maxValue = double.MaxValue;
				bool a_3 = false;
				bool a_4 = true;
				float? a_5 = dz6.b();
				boj.a(A_1, a_, a_2, maxValue, a_3, a_4, null, null, null, a_5, false);
				string a_6 = "xpbl_TempStasisBreakFront";
				int a_7 = 1;
				double maxValue2 = double.MaxValue;
				bool a_8 = false;
				bool a_9 = true;
				a_5 = dz6.b();
				boj.a(A_1, a_6, a_7, maxValue2, a_8, a_9, null, null, null, a_5, false);
				A_1.c().a("xpbl_EntropicRecurrence");
			}
		}
	}
}
