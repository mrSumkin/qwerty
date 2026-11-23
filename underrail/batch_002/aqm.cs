using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000909 RID: 2313
[eiz("CCOWGI")]
[Serializable]
public sealed class aqm : bdw, ISerializable
{
	// Token: 0x06003913 RID: 14611 RVA: 0x0015209C File Offset: 0x0015029C
	private aqm(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x001520A4 File Offset: 0x001502A4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x001520A8 File Offset: 0x001502A8
	public aqm()
	{
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x001520B4 File Offset: 0x001502B4
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc_warehouse");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("f4d212d0-0f18-4e58-b803-c0793c75d3c5"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("ffc6c0e1-9c1a-41dd-b2c3-e81451083985"), aud).ao() as c5x;
				Point b = new Point(5, 0);
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.c();
					c5x.z();
					c5x.VisualPriority = 1;
					if (aspect != null)
					{
						aspect.b = b;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers.c();
					c5x2.z();
					c5x2.VisualPriority = -1;
					if (aspect2 != null)
					{
						aspect2.b = b;
					}
				}
			}
		}
	}
}
