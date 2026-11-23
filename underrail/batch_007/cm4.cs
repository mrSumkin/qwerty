using System;
using System.Runtime.Serialization;

// Token: 0x020015FF RID: 5631
[eiz("CSA0")]
[Serializable]
public sealed class cm4 : a6k, ISerializable
{
	// Token: 0x06007BE5 RID: 31717 RVA: 0x0033F520 File Offset: 0x0033D720
	private cm4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BE6 RID: 31718 RVA: 0x0033F52C File Offset: 0x0033D72C
	public cm4()
	{
	}

	// Token: 0x06007BE7 RID: 31719 RVA: 0x0033F538 File Offset: 0x0033D738
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && c5x.h.b != null && c5x.Zone != null)
		{
			if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
			{
				u6.a(base.vg().q().h.b);
				u6.a(base.vg().q().h.b, true);
			}
			awq.e(c5x.h.b);
			a3w a3w = new a3w(a9.g * d0u.b, a9.a(base.vg().e()));
			a3w.Stacks = a9.c;
			c5x.h.b.aa().StatusEffects.a(a3w, false, false, false);
			return dc4.c;
		}
		return dc4.e;
	}
}
