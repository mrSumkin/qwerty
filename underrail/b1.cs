using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020009E8 RID: 2536
[eiz("XPHWDT2UB")]
[Serializable]
public sealed class b1 : bdw, ISerializable
{
	// Token: 0x06003CA8 RID: 15528 RVA: 0x001681BC File Offset: 0x001663BC
	private b1(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x001681C4 File Offset: 0x001663C4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x001681C8 File Offset: 0x001663C8
	public b1()
	{
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x001681D4 File Offset: 0x001663D4
	public void av(c1a A_0, cyt A_1)
	{
		d60 addon = A_0.GetAddon<d60>();
		if (addon != null)
		{
			foreach (b0b b0b in addon.ab4(new string[]
			{
				"gate"
			}))
			{
				b0b.VisualPriority = 10;
				b0b.TileFormationModifiers.c();
				b0b.z();
				cd0 aspect = b0b.GetAspect<cd0>();
				if (aspect != null)
				{
					aspect.b.X = 5;
				}
			}
		}
		c5x c5x = new ar7(new Guid("1170487a-f06b-4ae9-bd40-e3d01db2e0ee"), A_0.n("xphw_darkTer2")).ao() as c5x;
		if (c5x != null)
		{
			if (c5x.p.b != null)
			{
				c5x.p.b.a[1].c = new Color?(new Color(43, 255, 43, 255));
			}
			c5x.RemoveAspect<bim>();
			d85 d = new d85(c5x);
			c5x.SetAspect<bim>(d);
			d.a().Add("STATUS: UNLOCKED");
		}
		foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
		{
			if (csd.Name.StartsWith("coilSpider"))
			{
				c5x c5x2 = vq.a("creatures\\GreaterCoilSpider", csd, false);
				if (c5x2 != null && c5x2.h.b != null && c5x2.t.b != null)
				{
					c5x2.RemoveAspect<a6p>();
					c5x2.t.b.y6()[ddq.ay] = new bt4(csd.Name);
					if (csd.Name.EndsWith("1"))
					{
						c5x2.h.b.aa().StatusEffects.a(new ah8(0, 100), false, false, false);
						c5x2.t.b.y6()[ddq.w] = CharacterState.Operating;
					}
					c5x2.h.b.aa().AttributesBase |= d8o.d;
					c5x2.h.b.aa().StatusEffects.a(new j3(0), false, false, false);
					c5x2.h.b.aa().StatusEffects.a(new doe(0, 10), false, false, false);
					if (cuo.a.Next(0, 101) <= 50)
					{
						c5x2.t.b.y6()[ddq.a5] = new List<Guid>
						{
							c29.a
						};
					}
				}
			}
		}
	}
}
