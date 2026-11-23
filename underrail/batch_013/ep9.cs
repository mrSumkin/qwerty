using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001600 RID: 5632
[eiz("XAA")]
[Serializable]
public sealed class ep9 : a6k, ISerializable
{
	// Token: 0x06007BE8 RID: 31720 RVA: 0x0033F64C File Offset: 0x0033D84C
	private ep9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BE9 RID: 31721 RVA: 0x0033F658 File Offset: 0x0033D858
	public ep9()
	{
	}

	// Token: 0x06007BEA RID: 31722 RVA: 0x0033F664 File Offset: 0x0033D864
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
		{
			u6.a(base.vg().q().h.b);
			u6.a(base.vg().q().h.b, false);
		}
		if (c5x != base.vg().q())
		{
			awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
		}
		foreach (els a_ in Enumerable.ToList<bk9>(c5x.h.b.aa().StatusEffects.Get<bk9>()))
		{
			c5x.h.b.aa().StatusEffects.d(a_);
		}
		c5x.h.b.aa().StatusEffects.a(new aiw(eod.c * d0u.b), false, false, false);
		awq.a(c5x.h.b, true);
		return dc4.c;
	}
}
