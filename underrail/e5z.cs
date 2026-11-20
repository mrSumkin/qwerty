using System;
using System.Runtime.Serialization;

// Token: 0x02001481 RID: 5249
[eiz("UBO")]
[Serializable]
public sealed class e5z : a6k, ISerializable
{
	// Token: 0x06007666 RID: 30310 RVA: 0x0032138C File Offset: 0x0031F58C
	private e5z(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007667 RID: 30311 RVA: 0x00321398 File Offset: 0x0031F598
	public e5z()
	{
	}

	// Token: 0x06007668 RID: 30312 RVA: 0x003213A0 File Offset: 0x0031F5A0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (base.vg().q() == null || base.vg().q().Area == null || base.vg().q().Zone == null || base.vg().e() == null || c5x == null || c5x.s.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh == null)
		{
			return dc4.e;
		}
		Guid? primitivePropertyValue = coh.CustomProperties.GetPrimitivePropertyValue<Guid>("RobotId", null);
		if (primitivePropertyValue != null)
		{
			c5x c5x2 = new ar7(primitivePropertyValue.Value, base.vg().q().Area).ao() as c5x;
			if (c5x2 != null && c5x2.k.b != null)
			{
				c5x2.k.b.b(c5x, c5x.s.b.t(), 1, false, null);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
