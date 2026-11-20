using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001056 RID: 4182
[eiz("FBFMJ")]
[Serializable]
public sealed class ewj : cze
{
	// Token: 0x060056D5 RID: 22229 RVA: 0x0026092C File Offset: 0x0025EB2C
	private ewj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060056D6 RID: 22230 RVA: 0x00260938 File Offset: 0x0025EB38
	public ewj()
	{
	}

	// Token: 0x060056D7 RID: 22231 RVA: 0x00260944 File Offset: 0x0025EB44
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			c5x.t.b.y6()[ddq.a] = TimeSpan.Zero;
			c5x.t.b.y6()["NextIdleMoveTime"] = TimeSpan.Zero;
		}
	}
}
