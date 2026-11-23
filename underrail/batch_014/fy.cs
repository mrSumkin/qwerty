using System;
using System.Runtime.Serialization;

// Token: 0x020008E1 RID: 2273
[eiz("CCDAHFS")]
[Serializable]
public sealed class fy : bdw, ISerializable
{
	// Token: 0x06003870 RID: 14448 RVA: 0x0014EB34 File Offset: 0x0014CD34
	private fy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x0014EB3C File Offset: 0x0014CD3C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003872 RID: 14450 RVA: 0x0014EB40 File Offset: 0x0014CD40
	public fy()
	{
	}

	// Token: 0x06003873 RID: 14451 RVA: 0x0014EB4C File Offset: 0x0014CD4C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_s6c2");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("2ec4fc90-d6aa-45ef-bdea-24cec633aa51"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("ab7c7c03-fa87-47d4-b479-ced7899b7580"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("468550ac-1468-4ac7-a6e6-0e91ee3f66c5"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
			}
			if (c5x2 != null)
			{
				c5x2.an();
			}
			if (c5x3 != null)
			{
				c5x3.an();
			}
		}
	}
}
