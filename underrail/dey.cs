using System;
using System.Runtime.Serialization;

// Token: 0x02000948 RID: 2376
[eiz("XPBLLEGAJSTP")]
[Serializable]
public sealed class dey : bdw, ISerializable
{
	// Token: 0x06003A17 RID: 14871 RVA: 0x00157A20 File Offset: 0x00155C20
	private dey(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A18 RID: 14872 RVA: 0x00157A28 File Offset: 0x00155C28
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A19 RID: 14873 RVA: 0x00157A2C File Offset: 0x00155C2C
	public dey()
	{
	}

	// Token: 0x06003A1A RID: 14874 RVA: 0x00157A38 File Offset: 0x00155C38
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("xpbl_d5");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("32ff7b37-5c25-4535-84d7-61c039d678d3"), aud).ao() as c5x;
			if (c5x != null)
			{
				wv wv = c5x.GetAspect<bim>() as wv;
				if (wv != null)
				{
					wv.g().l().Clear();
				}
				if (c5x.GetAspect<c3g>() != null)
				{
					c5x.RemoveAspect<c3g>();
				}
			}
		}
	}
}
