using System;
using System.Runtime.Serialization;

// Token: 0x02000796 RID: 1942
[eiz("FOMesserRF")]
[Serializable]
public sealed class esw : egv, ISerializable
{
	// Token: 0x060030F1 RID: 12529 RVA: 0x0012CFA4 File Offset: 0x0012B1A4
	private esw(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030F2 RID: 12530 RVA: 0x0012CFAC File Offset: 0x0012B1AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030F3 RID: 12531 RVA: 0x0012CFB0 File Offset: 0x0012B1B0
	public esw()
	{
	}

	// Token: 0x060030F4 RID: 12532 RVA: 0x0012CFBC File Offset: 0x0012B1BC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
				{
					return 2f;
				}
				return bhm.a;
			}
		}
		return bhm.a;
	}
}
