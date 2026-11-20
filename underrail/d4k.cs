using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001793 RID: 6035
[eiz("CRXA")]
[Serializable]
public sealed class d4k : a6k, ISerializable
{
	// Token: 0x06008157 RID: 33111 RVA: 0x00368128 File Offset: 0x00366328
	private d4k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x00368134 File Offset: 0x00366334
	public d4k()
	{
	}

	// Token: 0x06008159 RID: 33113 RVA: 0x00368140 File Offset: 0x00366340
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("regenerativeMixture");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Booster
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
