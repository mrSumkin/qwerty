using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000921 RID: 2337
[eiz("CCCAH4")]
[Serializable]
public sealed class cq3 : bdw, ISerializable
{
	// Token: 0x06003973 RID: 14707 RVA: 0x00153854 File Offset: 0x00151A54
	private cq3(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003974 RID: 14708 RVA: 0x0015385C File Offset: 0x00151A5C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003975 RID: 14709 RVA: 0x00153860 File Offset: 0x00151A60
	public cq3()
	{
	}

	// Token: 0x06003976 RID: 14710 RVA: 0x0015386C File Offset: 0x00151A6C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc10");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("651057b6-13aa-43a0-a06e-11c263cc6f6a"), aud).ao() as c5x;
			c5x.p.b.a[0].b = new Point(6, 0);
			c5x.p.b.a[1].b = new Point(6, 1);
		}
	}
}
