using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B12 RID: 2834
[eiz("XPSHDJ")]
[Serializable]
public sealed class t5 : cze, ISerializable
{
	// Token: 0x06004188 RID: 16776 RVA: 0x00191DBC File Offset: 0x0018FFBC
	private t5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x00191DC8 File Offset: 0x0018FFC8
	public t5()
	{
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x00191DD0 File Offset: 0x0018FFD0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Zone != null)
		{
			cya aspect = c5x.GetAspect<cya>();
			if (aspect != null)
			{
				aspect.a(false, true);
			}
			c5x c5x2 = vq.a("object\\container\\xpbl_destroyedHive", c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			c5x2.TileFormationModifiers = c5x.TileFormationModifiers;
			c5x2.z = c5x.z;
			c5x2.z();
			c5x2.ah();
			if (c5x2 != null && c5x2.o.b != null)
			{
				if (c5x.GetAspect<buf>() != null)
				{
					buf aspect2 = new buf(c5x2);
					c5x2.SetAspect<buf>(aspect2);
				}
				if (c5x.p.b != null && c5x.p.b.a.Count > 0)
				{
					c5x2.o.b.a = c5x.p.b.a[0].a;
					c5x2.Size = c5x.Size;
					c5x2.ah();
					dtb dtb = new dtb();
					int num = 15;
					for (int i = 0; i < num; i++)
					{
						Vector3 a_;
						if (c5x2.Size.X == 2f && c5x2.Size.Y == 2f)
						{
							a_ = new Vector3(c5x.Location.X + (float)(-0.375 + cuo.a.NextDouble() * 0.75) * c5x.Size.X, c5x.Location.Y + (float)(-0.375 + cuo.a.NextDouble() * 0.75) * c5x.Size.Y, c5x.Location.Z + 0.5f + (float)(cuo.a.NextDouble() * 1.0));
						}
						else if (c5x2.Size.X == 2f)
						{
							a_ = new Vector3(c5x.Location.X + (float)(-0.375 + cuo.a.NextDouble() * 2.0), c5x.Location.Y + (float)(-0.2 + cuo.a.NextDouble() * 0.375), c5x.Location.Z + 0.75f + (float)(cuo.a.NextDouble() * 1.25));
						}
						else
						{
							a_ = new Vector3(c5x.Location.X + (float)(-0.3 + cuo.a.NextDouble() * 0.4), c5x.Location.Y + (float)(-0.15 + cuo.a.NextDouble() * 1.25), c5x.Location.Z + 0.5f + (float)(cuo.a.NextDouble() * 1.0));
						}
						dtb.ad().Add(new au0(c5x.Area, a_, "xpbl_HiveDestruction", 1, double.MaxValue, null, null, null));
						dtb.ad().Add(new bm3(50 + cuo.a.Next(25)));
						if (i % 3 == 0)
						{
							dtb.ad().Add(new a4s(new bfq("xpbl_StriderHiveBloodBurst"), null, new ar7(c5x2), null));
						}
					}
					c5x.Zone.ActionManager.g9(dtb, atp.a);
					dtb dtb2 = new dtb();
					dtb2.ad().Add(new bm3(1000));
					dtb2.ad().Add(new a4s(new bfq("xpbl_StriderHiveDestroyed"), null, new ar7(c5x2), null));
					dtb2.ad().Add(new a4s(new rp(5), null, new ar7(c5x2), null));
					c5x.Zone.ActionManager.g9(dtb2, atp.a);
				}
			}
		}
	}
}
