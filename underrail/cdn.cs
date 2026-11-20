using System;
using System.Runtime.Serialization;

// Token: 0x02001425 RID: 5157
[eiz("SC10")]
[bs6("ScAppliedAction")]
[Serializable]
public sealed class cdn : bhv, ISerializable
{
	// Token: 0x0600739F RID: 29599 RVA: 0x0030C0A8 File Offset: 0x0030A2A8
	private cdn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060073A0 RID: 29600 RVA: 0x0030C0B4 File Offset: 0x0030A2B4
	public cdn()
	{
	}

	// Token: 0x060073A1 RID: 29601 RVA: 0x0030C0BC File Offset: 0x0030A2BC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x2() != null)
		{
			e8o.b(base.x2().a8());
		}
		return dc4.c;
	}
}
