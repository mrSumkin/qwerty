using System;
using System.Runtime.Serialization;

// Token: 0x020007A0 RID: 1952
[eiz("XPBLMUChefRF")]
[Serializable]
public sealed class d6o : egv, ISerializable
{
	// Token: 0x06003119 RID: 12569 RVA: 0x0012DB6C File Offset: 0x0012BD6C
	private d6o(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600311A RID: 12570 RVA: 0x0012DB74 File Offset: 0x0012BD74
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600311B RID: 12571 RVA: 0x0012DB78 File Offset: 0x0012BD78
	public d6o()
	{
	}

	// Token: 0x0600311C RID: 12572 RVA: 0x0012DB80 File Offset: 0x0012BD80
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
