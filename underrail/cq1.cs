using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200091F RID: 2335
[eiz("CCCAH2")]
[Serializable]
public sealed class cq1 : bdw, ISerializable
{
	// Token: 0x0600396B RID: 14699 RVA: 0x0015372C File Offset: 0x0015192C
	private cq1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x00153734 File Offset: 0x00151934
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600396D RID: 14701 RVA: 0x00153738 File Offset: 0x00151938
	public cq1()
	{
	}

	// Token: 0x0600396E RID: 14702 RVA: 0x00153744 File Offset: 0x00151944
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc_cityEnter");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("b81fc67a-4b80-4386-bb8a-41e0c0a4fad3"), aud).ao() as c5x;
			c5x.p.b.a[0].b = new Point(4, 0);
			c5x.p.b.a[1].b = new Point(4, 1);
		}
	}
}
