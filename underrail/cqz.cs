using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200091E RID: 2334
[eiz("CCCAH1")]
[Serializable]
public sealed class cqz : bdw, ISerializable
{
	// Token: 0x06003967 RID: 14695 RVA: 0x00153698 File Offset: 0x00151898
	private cqz(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003968 RID: 14696 RVA: 0x001536A0 File Offset: 0x001518A0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003969 RID: 14697 RVA: 0x001536A4 File Offset: 0x001518A4
	public cqz()
	{
	}

	// Token: 0x0600396A RID: 14698 RVA: 0x001536B0 File Offset: 0x001518B0
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lub-a11");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("0763988d-9cd8-4289-b441-303d7cd6497c"), aud).ao() as c5x;
			c5x.p.b.a[0].b = new Point(6, 0);
			c5x.p.b.a[1].b = new Point(6, 1);
		}
	}
}
