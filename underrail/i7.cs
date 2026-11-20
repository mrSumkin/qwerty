using System;
using System.Runtime.Serialization;

// Token: 0x020008E3 RID: 2275
[eiz("CCSSRELDR")]
[Serializable]
public sealed class i7 : bdw, ISerializable
{
	// Token: 0x06003878 RID: 14456 RVA: 0x0014EDB0 File Offset: 0x0014CFB0
	private i7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003879 RID: 14457 RVA: 0x0014EDB8 File Offset: 0x0014CFB8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x0014EDBC File Offset: 0x0014CFBC
	public i7()
	{
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x0014EDC8 File Offset: 0x0014CFC8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_s6");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("0ceb0c1e-ed28-4132-aea8-3c889f1e14a4"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.ae = new float?((float)1);
					if (c5x.s.b != null)
					{
						c5x.s.b.g(true);
					}
				}
			}
		}
	}
}
