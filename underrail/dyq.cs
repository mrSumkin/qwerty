using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001070 RID: 4208
[eiz("PUTOJ")]
[Serializable]
public sealed class dyq : cze
{
	// Token: 0x06005797 RID: 22423 RVA: 0x002631D8 File Offset: 0x002613D8
	private dyq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x002631E4 File Offset: 0x002613E4
	public dyq()
	{
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x002631EC File Offset: 0x002613EC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		c5x c5x2 = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.t.b != null && c5x2 != null)
		{
			c5i aspect = c5x2.GetAspect<c5i>();
			if (aspect != null)
			{
				string text = aspect.g1();
				if (!string.IsNullOrEmpty(text))
				{
					c5x.h.b.aa().CustomProperties[ddm.i] = text;
					c5x.h.b.a2();
					lh lh = ckw.a(text);
					if (lh != null)
					{
						lh.q7(c5x.h.b, aspect);
					}
				}
			}
		}
	}
}
