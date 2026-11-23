using System;
using System.Runtime.Serialization;

// Token: 0x0200094B RID: 2379
[eiz("XPBLCCRBC")]
[Serializable]
public sealed class ap7 : bdw, ISerializable
{
	// Token: 0x06003A23 RID: 14883 RVA: 0x00157CE4 File Offset: 0x00155EE4
	private ap7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x00157CEC File Offset: 0x00155EEC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x00157CF0 File Offset: 0x00155EF0
	public ap7()
	{
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x00157CFC File Offset: 0x00155EFC
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_bar");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("cf4b158b-fa36-4d3a-ab72-af1daa42fae7"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
