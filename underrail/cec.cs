using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017C3 RID: 6083
[eiz("CJBA")]
[Serializable]
public sealed class cec : a6k, ISerializable
{
	// Token: 0x060081D5 RID: 33237 RVA: 0x0036A7BC File Offset: 0x003689BC
	private cec(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081D6 RID: 33238 RVA: 0x0036A7C8 File Offset: 0x003689C8
	public cec()
	{
	}

	// Token: 0x060081D7 RID: 33239 RVA: 0x0036A7D0 File Offset: 0x003689D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("jumpingBean");
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
