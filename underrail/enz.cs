using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001105 RID: 4357
[eiz("SC8")]
[Serializable]
public sealed class enz : cze, ISerializable
{
	// Token: 0x06005C6C RID: 23660 RVA: 0x002780E8 File Offset: 0x002762E8
	private enz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C6D RID: 23661 RVA: 0x002780F4 File Offset: 0x002762F4
	public enz()
	{
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x002780FC File Offset: 0x002762FC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		e8o.b(A_1 as c5x);
	}
}
