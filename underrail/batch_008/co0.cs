using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A4E RID: 2638
[eiz("CSTCJ")]
[Serializable]
public sealed class co0 : cze, ISerializable
{
	// Token: 0x06003E73 RID: 15987 RVA: 0x0017928C File Offset: 0x0017748C
	private co0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x00179298 File Offset: 0x00177498
	public co0()
	{
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x001792A4 File Offset: 0x001774A4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			foreach (ak1 ak in c5x.l)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.o.b != null && string.Equals(c5x2.o.b.a, "creatures\\sht\\di", StringComparison.OrdinalIgnoreCase))
					{
						c5x2.w();
						c5x2.an();
					}
				}
			}
		}
	}
}
