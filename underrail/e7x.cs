using System;
using System.Runtime.Serialization;

// Token: 0x020016D3 RID: 5843
[eiz("AQT")]
[Serializable]
public sealed class e7x : a6k, ISerializable
{
	// Token: 0x06007F32 RID: 32562 RVA: 0x0035D6EC File Offset: 0x0035B8EC
	private e7x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F33 RID: 32563 RVA: 0x0035D6F8 File Offset: 0x0035B8F8
	public e7x()
	{
	}

	// Token: 0x06007F34 RID: 32564 RVA: 0x0035D700 File Offset: 0x0035B900
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				a4l a_ = new a4l(dp3.a * d0u.b);
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
