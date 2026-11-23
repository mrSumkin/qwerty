using System;
using System.Runtime.Serialization;

// Token: 0x020007AB RID: 1963
[eiz("XPBLTMRF")]
[Serializable]
public sealed class d9e : egv, ISerializable
{
	// Token: 0x06003145 RID: 12613 RVA: 0x0012E90C File Offset: 0x0012CB0C
	private d9e(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003146 RID: 12614 RVA: 0x0012E914 File Offset: 0x0012CB14
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x0012E918 File Offset: 0x0012CB18
	public d9e()
	{
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x0012E924 File Offset: 0x0012CB24
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				Random random = new Random(serviceOrThrow.aqu().l() + A_0.ap9().Uid.GetHashCode());
				float num = (float)random.NextDouble();
				if (random.Next(0, 2) > 0)
				{
					num = -(num / 2f);
				}
				return bhm.a + num;
			}
		}
		return bhm.a;
	}
}
