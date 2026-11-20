using System;
using System.Runtime.Serialization;

// Token: 0x020007A3 RID: 1955
[eiz("XPBLMUEustaceRF")]
[Serializable]
public sealed class wl : egv, ISerializable
{
	// Token: 0x06003125 RID: 12581 RVA: 0x0012DED4 File Offset: 0x0012C0D4
	private wl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003126 RID: 12582 RVA: 0x0012DEDC File Offset: 0x0012C0DC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003127 RID: 12583 RVA: 0x0012DEE0 File Offset: 0x0012C0E0
	public wl()
	{
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x0012DEEC File Offset: 0x0012C0EC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_mu_repairedGenerator", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_mu_gaveMedicine", new bool?(false)).Value;
				float num = bhm.b;
				if (value)
				{
					num -= 1f;
				}
				if (value2)
				{
					num -= 1f;
				}
				return Math.Max(bhm.c, num);
			}
		}
		return bhm.a;
	}
}
