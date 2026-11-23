using System;
using System.Runtime.Serialization;

// Token: 0x02000960 RID: 2400
[eiz("JYDBCB")]
[Serializable]
public sealed class gq : bdw, ISerializable
{
	// Token: 0x06003A7A RID: 14970 RVA: 0x0015A73C File Offset: 0x0015893C
	private gq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x0015A744 File Offset: 0x00158944
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x0015A748 File Offset: 0x00158948
	public gq()
	{
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x0015A754 File Offset: 0x00158954
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("jy3");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("98e670ed-5dd0-4d34-9feb-d34617eb9ec2"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
