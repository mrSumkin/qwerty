using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000945 RID: 2373
[eiz("XPBLF12OFG")]
[Serializable]
public sealed class b0g : bdw, ISerializable
{
	// Token: 0x06003A0B RID: 14859 RVA: 0x00157794 File Offset: 0x00155994
	private b0g(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A0C RID: 14860 RVA: 0x0015779C File Offset: 0x0015599C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A0D RID: 14861 RVA: 0x001577A0 File Offset: 0x001559A0
	public b0g()
	{
	}

	// Token: 0x06003A0E RID: 14862 RVA: 0x001577AC File Offset: 0x001559AC
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("xpbl_f12");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("a52bd9fc-523a-4709-bdb6-1443883eebed"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("fefc5ea8-2716-4427-9d42-83da4e62ed2c"), aud).ao() as c5x;
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.c();
					c5x.z();
					c5x.VisualPriority = -1;
					if (aspect != null)
					{
						aspect.b = new Point(5, 1);
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers.c();
					c5x2.z();
					c5x2.VisualPriority = 1;
					if (aspect2 != null)
					{
						aspect2.b = new Point(5, 0);
					}
				}
			}
		}
	}
}
