using System;
using System.Runtime.Serialization;

// Token: 0x020008E6 RID: 2278
[eiz("CCUTABOL")]
[Serializable]
public sealed class coq : bdw, ISerializable
{
	// Token: 0x06003884 RID: 14468 RVA: 0x0014EF88 File Offset: 0x0014D188
	private coq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003885 RID: 14469 RVA: 0x0014EF90 File Offset: 0x0014D190
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x0014EF94 File Offset: 0x0014D194
	public coq()
	{
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x0014EFA0 File Offset: 0x0014D1A0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_0.n("cc_utility1") != null)
		{
			int? primitivePropertyValue = A_1.r().GetPrimitivePropertyValue<int>("loc_cc_utility1_activeBoilersCount", new int?(0));
			int num = 0;
			if (primitivePropertyValue.GetValueOrDefault() == num & primitivePropertyValue != null)
			{
				foreach (b0b b0b in A_0.a().ab4(new string[]
				{
					"cc_utility1_lever"
				}))
				{
					b0b.GetAspect<bim>().g(true);
				}
			}
		}
	}
}
