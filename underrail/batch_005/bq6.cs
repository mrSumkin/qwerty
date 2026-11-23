using System;
using System.Runtime.Serialization;

// Token: 0x02000962 RID: 2402
[eiz("FODEB")]
[Serializable]
public sealed class bq6 : bdw, ISerializable
{
	// Token: 0x06003A82 RID: 14978 RVA: 0x0015A80C File Offset: 0x00158A0C
	private bq6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A83 RID: 14979 RVA: 0x0015A814 File Offset: 0x00158A14
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x0015A818 File Offset: 0x00158A18
	public bq6()
	{
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x0015A824 File Offset: 0x00158A24
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("fo2");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("f7c1e7e5-5573-4e8e-a9a5-f53418c721c1"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
		}
	}
}
