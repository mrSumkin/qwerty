using System;
using System.Runtime.Serialization;

// Token: 0x02000797 RID: 1943
[eiz("FOWestRF")]
[Serializable]
public sealed class ee0 : egv, ISerializable
{
	// Token: 0x060030F5 RID: 12533 RVA: 0x0012D024 File Offset: 0x0012B224
	private ee0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030F6 RID: 12534 RVA: 0x0012D02C File Offset: 0x0012B22C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x0012D030 File Offset: 0x0012B230
	public ee0()
	{
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x0012D03C File Offset: 0x0012B23C
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
