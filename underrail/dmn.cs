using System;
using System.Runtime.Serialization;

// Token: 0x0200095C RID: 2396
[eiz("SGSDTS")]
[Serializable]
public sealed class dmn : bdw, ISerializable
{
	// Token: 0x06003A6A RID: 14954 RVA: 0x0015A3E4 File Offset: 0x001585E4
	private dmn(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A6B RID: 14955 RVA: 0x0015A3EC File Offset: 0x001585EC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x0015A3F0 File Offset: 0x001585F0
	public dmn()
	{
	}

	// Token: 0x06003A6D RID: 14957 RVA: 0x0015A3FC File Offset: 0x001585FC
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("sa2");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("ea9b4123-6cc6-4de5-b004-00dd1e4485a2"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("1d551f09-3d81-4dec-838c-a723da8a2168"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("81a1d754-4a3a-4bfa-afab-1c8f22382c6e"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
			if (c5x2 != null)
			{
				c5x2.w();
				c5x2.an();
			}
			if (c5x3 != null)
			{
				c5x3.w();
				c5x3.an();
			}
		}
	}
}
