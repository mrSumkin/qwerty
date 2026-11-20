using System;
using System.Runtime.Serialization;

// Token: 0x020009A7 RID: 2471
[eiz("JYOFDB")]
[Serializable]
public sealed class b5b : bdw, ISerializable
{
	// Token: 0x06003B98 RID: 15256 RVA: 0x00160C20 File Offset: 0x0015EE20
	private b5b(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B99 RID: 15257 RVA: 0x00160C28 File Offset: 0x0015EE28
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B9A RID: 15258 RVA: 0x00160C2C File Offset: 0x0015EE2C
	public b5b()
	{
	}

	// Token: 0x06003B9B RID: 15259 RVA: 0x00160C38 File Offset: 0x0015EE38
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jy7");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("adde23fe-ae77-45d7-b3a7-8635e37e1744"), aud).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					if (aspect != null)
					{
						aspect.e(false);
					}
					cnb cnb = c5x.s.b as cnb;
					if (cnb != null)
					{
						cnb.d(true);
					}
				}
			}
		}
	}
}
