using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AE2 RID: 2786
[eiz("XPBLSSHJ")]
[Serializable]
public sealed class ca2 : cze, ISerializable
{
	// Token: 0x060040DD RID: 16605 RVA: 0x0018B9E8 File Offset: 0x00189BE8
	private ca2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040DE RID: 16606 RVA: 0x0018B9F4 File Offset: 0x00189BF4
	public ca2()
	{
	}

	// Token: 0x060040DF RID: 16607 RVA: 0x0018BA00 File Offset: 0x00189C00
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null && c5x.h.b != null)
		{
			aex.a(c5x.Area, c5x.aj() + new Vector3(0f, 0f, 0.1f), 1, 0, 0.3f, 0.5f, true, false);
			float? num = eh5.a(cwy.a) ? null : new float?(0.05f);
			if (c5x.h.b.aa().EtherealBase == !eh5.a(cwy.a))
			{
				float? ae = c5x.ae;
				float? num2 = num;
				if (ae.GetValueOrDefault() == num2.GetValueOrDefault() & ae != null == (num2 != null))
				{
					return;
				}
			}
			c5x.h.b.aa().EtherealBase = !eh5.a(cwy.a);
			c5x.h.b.aa().bl();
			c5x.ae = num;
		}
	}
}
