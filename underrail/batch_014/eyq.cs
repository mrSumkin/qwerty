using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010DD RID: 4317
[eiz("EX1")]
[Serializable]
public sealed class eyq : cze
{
	// Token: 0x06005B08 RID: 23304 RVA: 0x00272CF0 File Offset: 0x00270EF0
	private eyq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005B09 RID: 23305 RVA: 0x00272CFC File Offset: 0x00270EFC
	public eyq()
	{
	}

	// Token: 0x06005B0A RID: 23306 RVA: 0x00272D08 File Offset: 0x00270F08
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			HashSet<c5x> hashSet = new HashSet<c5x>();
			foreach (ak1 ak in Enumerable.ToList<ak1>(c5x.l))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.c.Values))
				{
					c5x c5x2 = (c5x)b0b;
					if (!hashSet.Contains(c5x2))
					{
						new n0().ym(c5x2, null, null);
					}
					hashSet.Add(c5x2);
				}
			}
		}
	}
}
