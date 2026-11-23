using System;
using System.Runtime.Serialization;

// Token: 0x02001422 RID: 5154
[bs6("BurningAppliedAction")]
[eiz("B02")]
[Serializable]
public sealed class eb8 : bhv, ISerializable
{
	// Token: 0x06007396 RID: 29590 RVA: 0x0030BFB8 File Offset: 0x0030A1B8
	private eb8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007397 RID: 29591 RVA: 0x0030BFC4 File Offset: 0x0030A1C4
	public eb8()
	{
	}

	// Token: 0x06007398 RID: 29592 RVA: 0x0030BFD0 File Offset: 0x0030A1D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null)
		{
			base.x2().u();
			dd5.d(base.x2().a8());
		}
		return dc4.c;
	}
}
