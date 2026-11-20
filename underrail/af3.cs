using System;
using System.Collections.Generic;

// Token: 0x0200113C RID: 4412
[euj]
public sealed class af3
{
	// Token: 0x06005E64 RID: 24164 RVA: 0x0028077C File Offset: 0x0027E97C
	[ayh("VolFusOn")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			alv b = A_1.p.b;
			if (b != null && b.a.Count >= 2)
			{
				b.a[1].d = null;
			}
		}
	}

	// Token: 0x06005E65 RID: 24165 RVA: 0x002807CC File Offset: 0x0027E9CC
	[ayh("VolFusOff")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			alv b = A_1.p.b;
			if (b != null && b.a.Count >= 2)
			{
				b.a[1].d = new float?(0f);
			}
		}
	}
}
