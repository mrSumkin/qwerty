using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200104A RID: 4170
[eiz("HCDFHJ")]
[Serializable]
public sealed class e2a : cze
{
	// Token: 0x06005662 RID: 22114 RVA: 0x0025EED0 File Offset: 0x0025D0D0
	private e2a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005663 RID: 22115 RVA: 0x0025EEDC File Offset: 0x0025D0DC
	public e2a()
	{
	}

	// Token: 0x06005664 RID: 22116 RVA: 0x0025EEE8 File Offset: 0x0025D0E8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			awq.a(c5x.h.b, true);
		}
	}
}
