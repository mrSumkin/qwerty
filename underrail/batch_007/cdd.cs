using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200107F RID: 4223
[eiz("IHSCJ")]
[Serializable]
public sealed class cdd : cze
{
	// Token: 0x06005805 RID: 22533 RVA: 0x00264004 File Offset: 0x00262204
	private cdd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x00264010 File Offset: 0x00262210
	public cdd()
	{
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x0026401C File Offset: 0x0026221C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		c5x c5x2 = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && c5x2 != null)
		{
			cya aspect = c5x2.GetAspect<cya>();
			if (aspect != null)
			{
				if (c5x.h.b.aa().b(d8o.n))
				{
					cya cya = aspect;
					int num = cya.r();
					cya.c(num + 1);
				}
				else
				{
					cya cya2 = aspect;
					int num = cya2.m();
					cya2.a(num + 1);
				}
			}
			c5x.w();
			c5x.an();
		}
	}
}
