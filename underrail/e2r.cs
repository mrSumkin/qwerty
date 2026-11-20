using System;
using System.Runtime.Serialization;

// Token: 0x020016CD RID: 5837
[eiz("AHA")]
[Serializable]
public sealed class e2r : a6k, ISerializable
{
	// Token: 0x06007F20 RID: 32544 RVA: 0x0035CAE4 File Offset: 0x0035ACE4
	private e2r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F21 RID: 32545 RVA: 0x0035CAF0 File Offset: 0x0035ACF0
	public e2r()
	{
	}

	// Token: 0x06007F22 RID: 32546 RVA: 0x0035CAFC File Offset: 0x0035ACFC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				csc a_ = new csc(d0u.b);
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
