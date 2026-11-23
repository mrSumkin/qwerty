using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000920 RID: 2336
[eiz("CCCAH3")]
[Serializable]
public sealed class cq0 : bdw, ISerializable
{
	// Token: 0x0600396F RID: 14703 RVA: 0x001537C0 File Offset: 0x001519C0
	private cq0(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003970 RID: 14704 RVA: 0x001537C8 File Offset: 0x001519C8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003971 RID: 14705 RVA: 0x001537CC File Offset: 0x001519CC
	public cq0()
	{
	}

	// Token: 0x06003972 RID: 14706 RVA: 0x001537D8 File Offset: 0x001519D8
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc1");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("e2f5f470-1346-42ba-830e-eac4ad21594b"), aud).ao() as c5x;
			c5x.p.b.a[0].b = new Point(4, 0);
			c5x.p.b.a[1].b = new Point(4, 1);
		}
	}
}
