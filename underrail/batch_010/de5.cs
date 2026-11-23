using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001119 RID: 4377
[eiz("B04")]
[Serializable]
public sealed class de5 : cze, ISerializable
{
	// Token: 0x06005D52 RID: 23890 RVA: 0x0027B3E8 File Offset: 0x002795E8
	private de5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005D53 RID: 23891 RVA: 0x0027B3F4 File Offset: 0x002795F4
	public de5()
	{
	}

	// Token: 0x06005D54 RID: 23892 RVA: 0x0027B3FC File Offset: 0x002795FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		dd5.d(A_1 as c5x);
	}
}
