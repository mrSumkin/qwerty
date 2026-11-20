using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010B4 RID: 4276
[eiz("TCX4")]
[Serializable]
public sealed class e1p : cze, ISerializable
{
	// Token: 0x060059D6 RID: 22998 RVA: 0x0026CBF8 File Offset: 0x0026ADF8
	private e1p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060059D7 RID: 22999 RVA: 0x0026CC04 File Offset: 0x0026AE04
	public e1p()
	{
	}

	// Token: 0x060059D8 RID: 23000 RVA: 0x0026CC10 File Offset: 0x0026AE10
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			zb aspect = c5x.GetAspect<zb>();
			if (aspect != null)
			{
				aspect.b();
			}
		}
	}
}
