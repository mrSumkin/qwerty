using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001792 RID: 6034
[eiz("CPRI")]
[Serializable]
public sealed class c06 : a6k, ISerializable
{
	// Token: 0x06008154 RID: 33108 RVA: 0x0036804C File Offset: 0x0036624C
	private c06(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008155 RID: 33109 RVA: 0x00368058 File Offset: 0x00366258
	public c06()
	{
	}

	// Token: 0x06008156 RID: 33110 RVA: 0x00368064 File Offset: 0x00366264
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("psiReinvigorator");
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
