using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200179B RID: 6043
[eiz("CHPA")]
[Serializable]
public sealed class bdy : a6k, ISerializable
{
	// Token: 0x0600816F RID: 33135 RVA: 0x0036887C File Offset: 0x00366A7C
	private bdy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008170 RID: 33136 RVA: 0x00368888 File Offset: 0x00366A88
	public bdy()
	{
	}

	// Token: 0x06008171 RID: 33137 RVA: 0x00368894 File Offset: 0x00366A94
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("healingSalve");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Healing
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
