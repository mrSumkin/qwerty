using System;
using System.IO;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200090A RID: 2314
[eiz("CCOWGO")]
[Serializable]
public sealed class ap8 : bdw, ISerializable
{
	// Token: 0x06003917 RID: 14615 RVA: 0x00152194 File Offset: 0x00150394
	private ap8(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x0015219C File Offset: 0x0015039C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x001521A0 File Offset: 0x001503A0
	public ap8()
	{
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x001521AC File Offset: 0x001503AC
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("40f80484-45ae-4ce4-a3b6-a471b3232498"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("0b2a79a2-087f-4159-84ea-a5394151d8aa"), aud).ao() as c5x;
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
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc2_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
