using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200106B RID: 4203
[eiz("LPTSETJ")]
[Serializable]
public sealed class bnc : cze, ISerializable
{
	// Token: 0x06005778 RID: 22392 RVA: 0x00262B8C File Offset: 0x00260D8C
	private bnc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005779 RID: 22393 RVA: 0x00262B98 File Offset: 0x00260D98
	public bnc()
	{
	}

	// Token: 0x0600577A RID: 22394 RVA: 0x00262BA4 File Offset: 0x00260DA4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && A_2 != null)
		{
			au1 au = A_2.SafeGet("StatusEffect", null) as au1;
			if (au != null)
			{
				au1 au2 = au;
				int num = au2.a();
				au2.a(num - 1);
				if (au.a() == 0)
				{
					new dtg().q6(c5x.h.b);
					c5x.h.b.aa().CustomProperties[ddm.i] = null;
					c5x.h.b.a2();
					c5x.h.b.aa().StatusEffects.d(au);
					return;
				}
				if (au.a() > 0)
				{
					bmj.a(c5x, new efj(au.a()));
				}
			}
		}
	}
}
