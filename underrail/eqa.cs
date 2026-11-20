using System;
using System.Runtime.Serialization;

// Token: 0x02001482 RID: 5250
[eiz("UBM")]
[Serializable]
public sealed class eqa : a6k, ISerializable
{
	// Token: 0x06007669 RID: 30313 RVA: 0x003214D0 File Offset: 0x0031F6D0
	private eqa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600766A RID: 30314 RVA: 0x003214DC File Offset: 0x0031F6DC
	public eqa()
	{
	}

	// Token: 0x0600766B RID: 30315 RVA: 0x003214E8 File Offset: 0x0031F6E8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (base.vg().q() == null || base.vg().q().Area == null || base.vg().q().Zone == null || base.vg().e() == null || ak == null)
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
			c5x c5x = new ar7(primitivePropertyValue.Value, base.vg().q().Area).ao() as c5x;
			if (c5x != null && c5x.k.b != null)
			{
				c5x.k.b.a(ak, double.MaxValue, 1, 0, true);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
