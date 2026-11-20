using System;
using System.Runtime.Serialization;

// Token: 0x020009B4 RID: 2484
[eiz("JYUGEG")]
[Serializable]
public sealed class a9s : bdw, ISerializable
{
	// Token: 0x06003BCC RID: 15308 RVA: 0x00161E60 File Offset: 0x00160060
	private a9s(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x00161E68 File Offset: 0x00160068
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BCE RID: 15310 RVA: 0x00161E6C File Offset: 0x0016006C
	public a9s()
	{
	}

	// Token: 0x06003BCF RID: 15311 RVA: 0x00161E78 File Offset: 0x00160078
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jy3");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("dd505854-c273-4bc3-8782-70079b2f8a5c"), aud).ao() as c5x;
				if (c5x != null)
				{
					d2b aspect = c5x.GetAspect<d2b>();
					c5x.RemoveAspect<c3g>();
					if (aspect != null)
					{
						aspect.a(true, false);
					}
				}
			}
		}
	}
}
