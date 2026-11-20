using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001799 RID: 6041
[eiz("XCTA")]
[Serializable]
public sealed class ehs : a6k, ISerializable
{
	// Token: 0x06008169 RID: 33129 RVA: 0x003686C4 File Offset: 0x003668C4
	private ehs(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600816A RID: 33130 RVA: 0x003686D0 File Offset: 0x003668D0
	public ehs()
	{
	}

	// Token: 0x0600816B RID: 33131 RVA: 0x003686DC File Offset: 0x003668DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("twitch");
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
