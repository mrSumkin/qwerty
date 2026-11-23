using System;
using System.Runtime.Serialization;

// Token: 0x02000956 RID: 2390
[eiz("XPBLMCC")]
[Serializable]
public sealed class dc3 : bdw, ISerializable
{
	// Token: 0x06003A52 RID: 14930 RVA: 0x00159F0C File Offset: 0x0015810C
	private dc3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A53 RID: 14931 RVA: 0x00159F14 File Offset: 0x00158114
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x00159F18 File Offset: 0x00158118
	public dc3()
	{
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x00159F24 File Offset: 0x00158124
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_md");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("2b421000-57a0-478c-905a-46b4f030ff6a"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("8d3b61db-bb2b-4bfc-9e5d-5999c8761ae5"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("9c8dd673-722a-4d3b-847b-604e4b64ead1"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("65b129dc-9cf8-4a9c-b55c-ca60801970ec"), aud).ao() as c5x;
				if (c5x != null && c5x.o.b != null)
				{
					c5x.o.b.d = new float?((float)1);
					bim aspect = c5x.GetAspect<bim>();
					if (aspect != null)
					{
						aspect.g(true);
					}
				}
				if (c5x2 != null && c5x2.o.b != null)
				{
					c5x2.o.b.d = new float?((float)1);
				}
				if (c5x3 != null && c5x3.o.b != null)
				{
					c5x3.o.b.d = new float?((float)1);
				}
				if (c5x4 != null && c5x4.o.b != null)
				{
					c5x4.o.b.d = new float?((float)1);
				}
			}
		}
	}
}
