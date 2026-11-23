using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010BB RID: 4283
[eiz("DS0")]
[Serializable]
public sealed class ebq : cze, ISerializable
{
	// Token: 0x06005A05 RID: 23045 RVA: 0x0026DD08 File Offset: 0x0026BF08
	private ebq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A06 RID: 23046 RVA: 0x0026DD14 File Offset: 0x0026BF14
	public ebq()
	{
	}

	// Token: 0x06005A07 RID: 23047 RVA: 0x0026DD20 File Offset: 0x0026BF20
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			aru aru = c5x.c();
			aru.a("disruptiveField", false);
			aru.a("disruptiveField", "DisruptiveField", 1f, c9z.a, true, false);
		}
	}
}
