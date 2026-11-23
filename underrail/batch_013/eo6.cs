using System;
using System.Runtime.Serialization;

// Token: 0x020008F5 RID: 2293
[eiz("OJY4CPTXOJYC3")]
[Serializable]
public sealed class eo6 : bdw, ISerializable
{
	// Token: 0x060038C3 RID: 14531 RVA: 0x00150A84 File Offset: 0x0014EC84
	private eo6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x00150A8C File Offset: 0x0014EC8C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x00150A90 File Offset: 0x0014EC90
	public eo6()
	{
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x00150A9C File Offset: 0x0014EC9C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("ojy4");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("2bf166f0-83f8-4a1e-92e2-d73354d625ba"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("d16e7ed6-55c5-4386-8b1d-02113ac3b1ea"), aud).ao() as c5x;
				if (c5x2 != null && c5x != null)
				{
					bim aspect = c5x2.GetAspect<bim>();
					if (aspect != null)
					{
						aspect.g(true);
						c5x.w();
						c5x.an();
					}
				}
			}
		}
	}
}
