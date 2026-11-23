using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A82 RID: 2690
[eiz("TCHUSBBJ")]
[Serializable]
public sealed class jv : cze, ISerializable
{
	// Token: 0x06003F48 RID: 16200 RVA: 0x0017F4A0 File Offset: 0x0017D6A0
	private jv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x0017F4AC File Offset: 0x0017D6AC
	public jv()
	{
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x0017F4B8 File Offset: 0x0017D6B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.o.b != null)
		{
			c5x.o.b.f = Math.Max(0f, 1f - (float)Math.Pow((double)(Math.Abs(c5x.Location.Z - 0.5f) / 4.1f), 2.0));
		}
	}
}
