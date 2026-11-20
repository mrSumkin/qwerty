using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009A1 RID: 2465
[eiz("JYLEFG")]
[Serializable]
public sealed class dr2 : bdw, ISerializable
{
	// Token: 0x06003B80 RID: 15232 RVA: 0x00160310 File Offset: 0x0015E510
	private dr2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B81 RID: 15233 RVA: 0x00160318 File Offset: 0x0015E518
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x0016031C File Offset: 0x0015E51C
	public dr2()
	{
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x00160324 File Offset: 0x0015E524
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jy3");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("dd505854-c273-4bc3-8782-70079b2f8a5c")).ao();
				if (d2b != null)
				{
					d2b.e(true);
				}
				cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("dd505854-c273-4bc3-8782-70079b2f8a5c")).ao();
				if (cnb != null)
				{
					cnb.d(false);
				}
				c5x c5x = new ar7(new Guid("53d60fae-d3c4-4b27-9af3-554c09347a6e"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
				}
			}
		}
	}
}
