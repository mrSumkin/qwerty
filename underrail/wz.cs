using System;
using System.Runtime.Serialization;

// Token: 0x02000A1B RID: 2587
[eiz("XPBLRFTO")]
[Serializable]
public sealed class wz : bdw, ISerializable
{
	// Token: 0x06003D8D RID: 15757 RVA: 0x00170C98 File Offset: 0x0016EE98
	private wz(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003D8E RID: 15758 RVA: 0x00170CA0 File Offset: 0x0016EEA0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003D8F RID: 15759 RVA: 0x00170CA4 File Offset: 0x0016EEA4
	public wz()
	{
	}

	// Token: 0x06003D90 RID: 15760 RVA: 0x00170CB0 File Offset: 0x0016EEB0
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_k7");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("01efd90b-af9d-46b2-8966-0db092e26ca7"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("fc676a4f-91b3-442f-ba55-05279f498430"), aud).ao() as c5x;
				if (c5x != null)
				{
					axh aspect = c5x.GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a(null, true, null);
					}
				}
				if (c5x2 != null && c5x2.p.b != null)
				{
					c5x2.p.b.a[1].d = new float?((float)1);
				}
			}
		}
	}
}
