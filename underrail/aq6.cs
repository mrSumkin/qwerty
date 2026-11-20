using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009EF RID: 2543
[eiz("XPBLOPCL")]
[Serializable]
public sealed class aq6 : bdw, ISerializable
{
	// Token: 0x06003CC5 RID: 15557 RVA: 0x00168E24 File Offset: 0x00167024
	private aq6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CC6 RID: 15558 RVA: 0x00168E2C File Offset: 0x0016702C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CC7 RID: 15559 RVA: 0x00168E30 File Offset: 0x00167030
	public aq6()
	{
	}

	// Token: 0x06003CC8 RID: 15560 RVA: 0x00168E3C File Offset: 0x0016703C
	public void av(c1a A_0, cyt A_1)
	{
		bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_i5");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("8b61f252-c229-402a-b8e0-d13ab1823b39"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("53cd0bae-0f6e-400a-996c-98f64fc50942"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
					c5x2.w();
					c5x2.an();
					cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("78e457ce-c2f2-4536-8172-4fd95f020ef6")).ao();
					if (cnb != null)
					{
						cnb.g(true);
					}
				}
			}
		}
	}
}
