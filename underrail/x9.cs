using System;
using System.Runtime.Serialization;

// Token: 0x020009A6 RID: 2470
[eiz("JYFDB")]
[Serializable]
public sealed class x9 : bdw, ISerializable
{
	// Token: 0x06003B94 RID: 15252 RVA: 0x00160B00 File Offset: 0x0015ED00
	private x9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B95 RID: 15253 RVA: 0x00160B08 File Offset: 0x0015ED08
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B96 RID: 15254 RVA: 0x00160B0C File Offset: 0x0015ED0C
	public x9()
	{
	}

	// Token: 0x06003B97 RID: 15255 RVA: 0x00160B18 File Offset: 0x0015ED18
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("jyfd");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("9dbdf002-8639-4d9b-899e-df70ee16c0ac"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("95c5c75a-32d3-4794-b9ce-7fe398d1c9d2"), aud).ao() as c5x;
				if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
				{
					c5x.h.b.aa().Name = "Сара";
					c5x.h.b.aa().a(null, null, false);
				}
				if (c5x2 != null && c5x2.h.b != null && !c5x2.h.b.aa().Dead)
				{
					c5x2.h.b.aa().a(null, null, false);
				}
			}
		}
	}
}
