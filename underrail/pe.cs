using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001057 RID: 4183
[eiz("FSMMJ")]
[Serializable]
public sealed class pe : cze
{
	// Token: 0x060056D8 RID: 22232 RVA: 0x002609B8 File Offset: 0x0025EBB8
	private pe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x002609C4 File Offset: 0x0025EBC4
	public pe()
	{
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x002609CC File Offset: 0x0025EBCC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("click", "xpbl_SmallCrabClick", 1f, c9z.a, false, false);
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()["DogForceStand"] = true;
				c5x.t.b.y6()["InheritNextIdleMoveTime"] = true;
				c5x.t.b.y6()["NextIdleMoveTime"] = TimeSpan.Zero;
			}
		}
	}
}
