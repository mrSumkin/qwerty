using System;
using System.Runtime.Serialization;

// Token: 0x02001423 RID: 5155
[bs6("BurningExpiresAction")]
[eiz("B03")]
[Serializable]
public sealed class ad9 : bhv, ISerializable
{
	// Token: 0x06007399 RID: 29593 RVA: 0x0030C004 File Offset: 0x0030A204
	private ad9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600739A RID: 29594 RVA: 0x0030C010 File Offset: 0x0030A210
	public ad9()
	{
	}

	// Token: 0x0600739B RID: 29595 RVA: 0x0030C018 File Offset: 0x0030A218
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		base.xy();
		if (base.x2() != null)
		{
			dd5.c(base.x2().a8());
		}
		return dc4.c;
	}
}
