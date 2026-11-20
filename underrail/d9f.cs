using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010B0 RID: 4272
[eiz("CCX7")]
[Serializable]
public sealed class d9f : cze, ISerializable
{
	// Token: 0x060059C8 RID: 22984 RVA: 0x0026C3F0 File Offset: 0x0026A5F0
	private d9f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060059C9 RID: 22985 RVA: 0x0026C3FC File Offset: 0x0026A5FC
	public d9f()
	{
	}

	// Token: 0x060059CA RID: 22986 RVA: 0x0026C404 File Offset: 0x0026A604
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			ey7 aspect = c5x.GetAspect<ey7>();
			if (aspect != null)
			{
				aspect.b();
			}
		}
	}
}
