using System;
using System.Runtime.Serialization;

// Token: 0x0200094D RID: 2381
[eiz("RNDGCPRSF")]
[Serializable]
public sealed class d96 : bdw, ISerializable
{
	// Token: 0x06003A2B RID: 14891 RVA: 0x00157FD8 File Offset: 0x001561D8
	private d96(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A2C RID: 14892 RVA: 0x00157FE0 File Offset: 0x001561E0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A2D RID: 14893 RVA: 0x00157FE4 File Offset: 0x001561E4
	public d96()
	{
	}

	// Token: 0x06003A2E RID: 14894 RVA: 0x00157FF0 File Offset: 0x001561F0
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_1.v().b().Area;
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("4238c82a-8455-4ad1-85ed-153b384721f6"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
			}
		}
	}
}
