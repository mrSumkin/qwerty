using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F2 RID: 4338
[eiz("FDM")]
[Serializable]
public sealed class epz : cze
{
	// Token: 0x06005BDC RID: 23516 RVA: 0x00276720 File Offset: 0x00274920
	private epz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x0027672C File Offset: 0x0027492C
	public epz()
	{
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x00276738 File Offset: 0x00274938
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("bark", "DogBark", 1f, c9z.a, false, false);
			if (c5x.t.b != null)
			{
				c5x.t.b.y6()["DogForceStand"] = true;
				c5x.t.b.y6()["InheritNextIdleMoveTime"] = true;
				c5x.t.b.y6()["NextIdleMoveTime"] = TimeSpan.Zero;
			}
		}
	}
}
