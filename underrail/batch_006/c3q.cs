using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001136 RID: 4406
[euj]
public sealed class c3q
{
	// Token: 0x06005E3F RID: 24127 RVA: 0x0027F3B8 File Offset: 0x0027D5B8
	[ayh("Vfx_LimeGreenExpiration")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.j == cgy.b && A_1.Zone != null)
		{
			string a_ = "LimeGreenSparkExpiration";
			int a_2 = 2;
			double maxValue = double.MaxValue;
			bool a_3 = false;
			bool a_4 = true;
			Vector3? a_5 = new Vector3?(new Vector3(0f, 0f, A_1.Size.Z));
			float? a_6 = dz6.b();
			a7j a_7 = new a7j(A_1, a_, a_2, maxValue, a_3, a_4, a_5, null, null, a_6, false, null);
			A_1.Zone.ActionManager.g9(a_7, atp.a);
		}
	}
}
