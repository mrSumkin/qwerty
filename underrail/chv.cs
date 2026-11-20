using System;
using System.Runtime.Serialization;

// Token: 0x020007AA RID: 1962
[eiz("XPBLFerrymanRF")]
[Serializable]
public sealed class chv : egv, ISerializable
{
	// Token: 0x06003141 RID: 12609 RVA: 0x0012E7CC File Offset: 0x0012C9CC
	private chv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003142 RID: 12610 RVA: 0x0012E7D4 File Offset: 0x0012C9D4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x0012E7D8 File Offset: 0x0012C9D8
	public chv()
	{
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x0012E7E4 File Offset: 0x0012C9E4
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_attitude_neutral", new bool?(false)).Value;
				bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_attitude_neutral", new bool?(false)).Value;
				int num = 0;
				float num2 = bhm.b;
				for (int i = 3; i > 0; i--)
				{
					ai8 ai = ck.a("Philosophy" + i.ToString());
					if (ai != null && serviceOrThrow.aqu().v().Feats.a(ai))
					{
						num = i;
						break;
					}
				}
				if (value2)
				{
					num2 = bhm.a;
				}
				else if (value)
				{
					num2 = bhm.b - 0.5f;
				}
				if (num > 0)
				{
					num2 -= (float)num * 0.25f;
				}
				return Math.Max(bhm.c, num2);
			}
		}
		return bhm.a;
	}
}
