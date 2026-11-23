using System;
using System.Runtime.Serialization;

// Token: 0x02000795 RID: 1941
[eiz("FOBryanRF")]
[Serializable]
public sealed class dba : egv, ISerializable
{
	// Token: 0x060030ED RID: 12525 RVA: 0x0012CF24 File Offset: 0x0012B124
	private dba(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030EE RID: 12526 RVA: 0x0012CF2C File Offset: 0x0012B12C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030EF RID: 12527 RVA: 0x0012CF30 File Offset: 0x0012B130
	public dba()
	{
	}

	// Token: 0x060030F0 RID: 12528 RVA: 0x0012CF3C File Offset: 0x0012B13C
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
