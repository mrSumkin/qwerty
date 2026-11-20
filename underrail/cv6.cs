using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001794 RID: 6036
[eiz("CSSDA")]
[Serializable]
public sealed class cv6 : a6k, ISerializable
{
	// Token: 0x0600815A RID: 33114 RVA: 0x00368204 File Offset: 0x00366404
	private cv6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600815B RID: 33115 RVA: 0x00368210 File Offset: 0x00366410
	public cv6()
	{
	}

	// Token: 0x0600815C RID: 33116 RVA: 0x0036821C File Offset: 0x0036641C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("supersoldierDrug");
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
