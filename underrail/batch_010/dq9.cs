using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Comm;

// Token: 0x020017C0 RID: 6080
[eiz("CTRA")]
[Serializable]
public sealed class dq9 : a6k, ISerializable
{
	// Token: 0x060081CC RID: 33228 RVA: 0x0036A4D4 File Offset: 0x003686D4
	private dq9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081CD RID: 33229 RVA: 0x0036A4E0 File Offset: 0x003686E0
	public dq9()
	{
	}

	// Token: 0x060081CE RID: 33230 RVA: 0x0036A4EC File Offset: 0x003686EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		a4x a4x = awu.a("trance");
		if (a4x != null)
		{
			if (a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b))
			{
				a20.a(base.vg().q(), null, new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Consume_Psi
				});
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
