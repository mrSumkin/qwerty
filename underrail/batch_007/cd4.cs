using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000929 RID: 2345
[eiz("CCCAH5")]
[Serializable]
public sealed class cd4 : bdw, ISerializable
{
	// Token: 0x06003998 RID: 14744 RVA: 0x00154CBC File Offset: 0x00152EBC
	private cd4(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003999 RID: 14745 RVA: 0x00154CC4 File Offset: 0x00152EC4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x00154CC8 File Offset: 0x00152EC8
	public cd4()
	{
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x00154CD4 File Offset: 0x00152ED4
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("cc-res");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("da934ea8-c7fc-46c1-a5ad-bfb92b240930"), aud).ao() as c5x;
			c5x.p.b.a[0].b = new Point(4, 0);
			c5x.p.b.a[1].b = new Point(4, 1);
		}
	}
}
