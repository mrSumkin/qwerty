using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010BA RID: 4282
[eiz("ZS0")]
[Serializable]
public sealed class cjk : cze, ISerializable
{
	// Token: 0x06005A02 RID: 23042 RVA: 0x0026DCC4 File Offset: 0x0026BEC4
	private cjk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A03 RID: 23043 RVA: 0x0026DCD0 File Offset: 0x0026BED0
	public cjk()
	{
	}

	// Token: 0x06005A04 RID: 23044 RVA: 0x0026DCDC File Offset: 0x0026BEDC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("disruptiveField", false);
		}
	}
}
