using System;
using System.Runtime.Serialization;

// Token: 0x020016CF RID: 5839
[eiz("A63")]
[Serializable]
public sealed class dk8 : a6k, ISerializable
{
	// Token: 0x06007F26 RID: 32550 RVA: 0x0035D078 File Offset: 0x0035B278
	private dk8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F27 RID: 32551 RVA: 0x0035D084 File Offset: 0x0035B284
	public dk8()
	{
	}

	// Token: 0x06007F28 RID: 32552 RVA: 0x0035D090 File Offset: 0x0035B290
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				aw0 a_ = new aw0();
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
