using System;
using System.Runtime.Serialization;

// Token: 0x02001594 RID: 5524
[eiz("SAAA")]
[Serializable]
public sealed class bvh : a6k, ISerializable
{
	// Token: 0x06007AA2 RID: 31394 RVA: 0x003356FC File Offset: 0x003338FC
	private bvh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007AA3 RID: 31395 RVA: 0x00335708 File Offset: 0x00333908
	public bvh()
	{
	}

	// Token: 0x06007AA4 RID: 31396 RVA: 0x00335714 File Offset: 0x00333914
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (base.vg().q() != null && base.vg().q().h.b != null && c5x != null && c5x.h.b != null)
		{
			base.vg().q().h.b.b(c5x.h.b);
			return dc4.c;
		}
		return dc4.e;
	}
}
