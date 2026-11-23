using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200179A RID: 6042
[eiz("CTEA")]
[Serializable]
public sealed class bqa : a6k, ISerializable
{
	// Token: 0x0600816C RID: 33132 RVA: 0x003687A0 File Offset: 0x003669A0
	private bqa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600816D RID: 33133 RVA: 0x003687AC File Offset: 0x003669AC
	public bqa()
	{
	}

	// Token: 0x0600816E RID: 33134 RVA: 0x003687B8 File Offset: 0x003669B8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("thirdEye");
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
