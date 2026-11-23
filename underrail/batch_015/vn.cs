using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000A4F RID: 2639
[eiz("CTCJ")]
[Serializable]
public sealed class vn : cze, ISerializable
{
	// Token: 0x06003E76 RID: 15990 RVA: 0x00179394 File Offset: 0x00177594
	private vn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E77 RID: 15991 RVA: 0x001793A0 File Offset: 0x001775A0
	public vn()
	{
	}

	// Token: 0x06003E78 RID: 15992 RVA: 0x001793AC File Offset: 0x001775AC
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
					if (c5x2.o.b != null)
					{
						a3f aspect = c5x2.GetAspect<a3f>();
						if (aspect != null && aspect.a().GetClassPropertyValue<string>("CorpseSourceName") == "Tentacle")
						{
							c5x2.w();
							c5x2.an();
						}
					}
				}
			}
		}
	}
}
