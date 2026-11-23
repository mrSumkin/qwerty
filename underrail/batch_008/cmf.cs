using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ADE RID: 2782
[eiz("XPBLSPSNTDJ")]
[Serializable]
public sealed class cmf : cze, ISerializable
{
	// Token: 0x060040D0 RID: 16592 RVA: 0x0018B5A0 File Offset: 0x001897A0
	private cmf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040D1 RID: 16593 RVA: 0x0018B5AC File Offset: 0x001897AC
	public cmf()
	{
	}

	// Token: 0x060040D2 RID: 16594 RVA: 0x0018B5B4 File Offset: 0x001897B4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null && c5x.h.b != null && !c5x.h.b.aa().IsInCombat)
		{
			aex.a(c5x.Area, c5x.aj(), 200, 700, 1.5f, 4.25f, false, true);
			c5x.w();
			c5x.an();
		}
	}
}
