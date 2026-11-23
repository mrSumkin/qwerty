using System;
using System.Runtime.Serialization;

// Token: 0x0200145F RID: 5215
[eiz("EC5")]
[Serializable]
public sealed class bt6 : a6k, ISerializable
{
	// Token: 0x06007594 RID: 30100 RVA: 0x0031CECC File Offset: 0x0031B0CC
	private bt6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007595 RID: 30101 RVA: 0x0031CED8 File Offset: 0x0031B0D8
	public bt6()
	{
	}

	// Token: 0x06007596 RID: 30102 RVA: 0x0031CEE0 File Offset: 0x0031B0E0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.c;
	}
}
