using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010C2 RID: 4290
[eiz("FCM")]
[Serializable]
public sealed class c89 : cze
{
	// Token: 0x06005A35 RID: 23093 RVA: 0x0026E710 File Offset: 0x0026C910
	private c89(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A36 RID: 23094 RVA: 0x0026E71C File Offset: 0x0026C91C
	public c89()
	{
	}

	// Token: 0x06005A37 RID: 23095 RVA: 0x0026E728 File Offset: 0x0026C928
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			c5x.t.b.y6()["CatForceStand"] = true;
			c5x.t.b.y6()["InheritNextIdleMoveTime"] = true;
			c5x.t.b.y6()["NextIdleMoveTime"] = TimeSpan.Zero;
		}
	}
}
