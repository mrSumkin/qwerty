using System;
using System.Runtime.Serialization;

// Token: 0x020016B7 RID: 5815
[eiz("AEIA")]
[Serializable]
public sealed class d43 : a6k, ISerializable
{
	// Token: 0x06007ED5 RID: 32469 RVA: 0x003595B0 File Offset: 0x003577B0
	private d43(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ED6 RID: 32470 RVA: 0x003595BC File Offset: 0x003577BC
	public d43()
	{
	}

	// Token: 0x06007ED7 RID: 32471 RVA: 0x003595C8 File Offset: 0x003577C8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				en9 a_ = new en9(cch.a(b.aa()), d0u.b);
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
