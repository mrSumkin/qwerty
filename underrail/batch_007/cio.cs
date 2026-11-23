using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001066 RID: 4198
[eiz("PIJ0")]
[Serializable]
public sealed class cio : cze, ISerializable
{
	// Token: 0x06005741 RID: 22337 RVA: 0x002622D8 File Offset: 0x002604D8
	private cio(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x002622E4 File Offset: 0x002604E4
	public cio()
	{
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x002622F0 File Offset: 0x002604F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("polarization", false);
		}
	}
}
