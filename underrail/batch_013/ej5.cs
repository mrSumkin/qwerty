using System;
using System.Runtime.Serialization;

// Token: 0x02000FAC RID: 4012
[eiz("JSBAX")]
[Serializable]
public sealed class ej5 : a6k, ISerializable
{
	// Token: 0x06005201 RID: 20993 RVA: 0x0024C934 File Offset: 0x0024AB34
	private ej5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005202 RID: 20994 RVA: 0x0024C940 File Offset: 0x0024AB40
	public ej5()
	{
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x0024C948 File Offset: 0x0024AB48
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		c5x.c().a("ItemRecharge");
		bgx a_ = new bgx(c4c.c * d0u.b, c4c.d, c5x.h.b.aa().Offense.u());
		c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
		return dc4.c;
	}
}
