using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200111A RID: 4378
[eiz("B05")]
[Serializable]
public sealed class d0l : cze, ISerializable
{
	// Token: 0x06005D55 RID: 23893 RVA: 0x0027B40C File Offset: 0x0027960C
	private d0l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005D56 RID: 23894 RVA: 0x0027B418 File Offset: 0x00279618
	public d0l()
	{
	}

	// Token: 0x06005D57 RID: 23895 RVA: 0x0027B420 File Offset: 0x00279620
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		dd5.c(A_1 as c5x);
	}
}
