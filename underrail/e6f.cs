using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200102B RID: 4139
[eiz("ACX7")]
[Serializable]
public sealed class e6f : cze, ISerializable
{
	// Token: 0x0600556D RID: 21869 RVA: 0x0025B7B4 File Offset: 0x002599B4
	private e6f(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x0025B7C0 File Offset: 0x002599C0
	public e6f()
	{
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x0025B7CC File Offset: 0x002599CC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			e11 aspect = c5x.GetAspect<e11>();
			if (aspect != null)
			{
				aspect.d();
			}
		}
	}
}
