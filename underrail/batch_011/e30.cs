using System;
using System.Runtime.Serialization;

// Token: 0x0200141A RID: 5146
[bs6("StunExpiresAction")]
[eiz("SE0")]
[Serializable]
public sealed class e30 : bhv, ISerializable
{
	// Token: 0x06007377 RID: 29559 RVA: 0x0030AB48 File Offset: 0x00308D48
	private e30(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007378 RID: 29560 RVA: 0x0030AB54 File Offset: 0x00308D54
	public e30()
	{
	}

	// Token: 0x06007379 RID: 29561 RVA: 0x0030AB5C File Offset: 0x00308D5C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		base.x0().a().StatusEffects.a(new a2a(d0u.b * 2), false, false, false);
		return dc4.c;
	}
}
