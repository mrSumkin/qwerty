using System;
using System.Runtime.Serialization;

// Token: 0x02001833 RID: 6195
[eiz("CPRPA")]
[Serializable]
public sealed class cy : a6k, ISerializable
{
	// Token: 0x0600840B RID: 33803 RVA: 0x00370B48 File Offset: 0x0036ED48
	private cy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600840C RID: 33804 RVA: 0x00370B54 File Offset: 0x0036ED54
	public cy()
	{
	}

	// Token: 0x0600840D RID: 33805 RVA: 0x00370B5C File Offset: 0x0036ED5C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || !c5x.h.b.aa().Feats.Contains<ck5>())
		{
			return dc4.e;
		}
		a9w a9w = new a9w();
		a9w.a("ForcefullInnervation");
		a9w.a(true);
		a9w.ym(c5x, c5x, null);
		for (int i = c2h.b(c5x.h.b.aa()); i < aiy.au; i++)
		{
			c5x.h.b.aa().Offense.ai[i] = null;
		}
		return dc4.c;
	}
}
