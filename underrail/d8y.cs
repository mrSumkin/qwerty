using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001104 RID: 4356
[eiz("SC9")]
[Serializable]
public sealed class d8y : cze, ISerializable
{
	// Token: 0x06005C69 RID: 23657 RVA: 0x002780C4 File Offset: 0x002762C4
	private d8y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C6A RID: 23658 RVA: 0x002780D0 File Offset: 0x002762D0
	public d8y()
	{
	}

	// Token: 0x06005C6B RID: 23659 RVA: 0x002780D8 File Offset: 0x002762D8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		e8o.a(A_1 as c5x);
	}
}
