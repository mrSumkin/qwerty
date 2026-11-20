using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x020010F7 RID: 4343
[eiz("TJ0")]
[Serializable]
public sealed class cqb : cze
{
	// Token: 0x06005C06 RID: 23558 RVA: 0x00276E70 File Offset: 0x00275070
	private cqb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005C07 RID: 23559 RVA: 0x00276E7C File Offset: 0x0027507C
	public cqb()
	{
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x00276E84 File Offset: 0x00275084
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.r.b is ed2)
		{
			ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
			if (ak != null)
			{
				List<ya> list = ak.a(typeof(cos));
				if (list != null)
				{
					foreach (cos cos in Enumerable.OfType<cos>(list))
					{
						cos.b();
					}
				}
			}
		}
	}
}
