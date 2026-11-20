using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200106F RID: 4207
[eiz("FCHHBJ")]
[Serializable]
public sealed class ctl : cze
{
	// Token: 0x06005794 RID: 22420 RVA: 0x00263184 File Offset: 0x00261384
	private ctl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x00263190 File Offset: 0x00261390
	public ctl()
	{
	}

	// Token: 0x06005796 RID: 22422 RVA: 0x0026319C File Offset: 0x0026139C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.a2();
		}
	}
}
