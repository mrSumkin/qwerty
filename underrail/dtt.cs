using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x02001796 RID: 6038
[eiz("CPAA")]
[Serializable]
public sealed class dtt : a6k, ISerializable
{
	// Token: 0x06008160 RID: 33120 RVA: 0x00368430 File Offset: 0x00366630
	private dtt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008161 RID: 33121 RVA: 0x0036843C File Offset: 0x0036663C
	public dtt()
	{
	}

	// Token: 0x06008162 RID: 33122 RVA: 0x00368448 File Offset: 0x00366648
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("psionicAccelerator");
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
