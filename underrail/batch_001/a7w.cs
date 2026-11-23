using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02000AA4 RID: 2724
[eiz("R10")]
[Serializable]
public sealed class a7w : cze, ISerializable
{
	// Token: 0x06003FC0 RID: 16320 RVA: 0x001831A8 File Offset: 0x001813A8
	private a7w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x001831B4 File Offset: 0x001813B4
	public a7w()
	{
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x001831C0 File Offset: 0x001813C0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a != null && c5x.p.b.a.Count >= 2)
		{
			if (kb.a(c5x))
			{
				d0c aspect = c5x.GetAspect<d0c>();
				if (aspect != null)
				{
					aspect.a(new int?(1));
				}
				return;
			}
			ah7 ah = c5x.Zone.i("Mindshroom");
			if (ah == null || ah.Layer != c5x.Layer)
			{
				ah = new ah7("DetachedMindshroom", null);
				ah.Light = new ae8(new Color(50, 50, 255, 255), 0.75f, LightType.Increment);
				ah.LightFadeRate = 0.25f;
				ah.Range = 3f;
			}
			c5x.p.b.a[0].b = new Point(0, 0);
			c5x.p.b.a[1].d = null;
			c5x.TileFormationModifiers.s3(1);
			c5x.z();
			foreach (string text in c5x.b())
			{
				if (text.StartsWith("visualPriority_", StringComparison.OrdinalIgnoreCase))
				{
					c5x.VisualPriority = int.Parse(Enumerable.Last<string>(text.Split(new char[]
					{
						'_'
					})));
					c5x.ah();
					break;
				}
			}
			if (c5x.s.b != null)
			{
				c5x.s.b.g(true);
			}
			dm aspect2 = c5x.GetAspect<dm>();
			if (aspect2 != null)
			{
				aspect2.b(true);
			}
			ah.g().be(c5x);
		}
	}
}
