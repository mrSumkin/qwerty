using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A57 RID: 2647
[eiz("LCDJ")]
[Serializable]
public sealed class bp9 : cze, ISerializable
{
	// Token: 0x06003E9A RID: 16026 RVA: 0x00179FCC File Offset: 0x001781CC
	private bp9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E9B RID: 16027 RVA: 0x00179FD8 File Offset: 0x001781D8
	public bp9()
	{
	}

	// Token: 0x06003E9C RID: 16028 RVA: 0x00179FE0 File Offset: 0x001781E0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			axh aspect = c5x.GetAspect<axh>();
			if (aspect != null)
			{
				aspect.a(null, false, null);
			}
			try
			{
				c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\objects\\devices\\xpbl_LemurianSecurityCameraRemains");
				if (c5k != null)
				{
					c5x c5x2 = c5k.a(null, false) as c5x;
					c5x2.o.b.b = new Point(c5x.p.b.a[0].b.X, c5x.p.b.a[0].b.Y);
					c5x2.VisualPriority = c5x.VisualPriority;
					c5x2.Location = c5x.Location;
					c5x2.Size = c5x.Size;
					c5x.Area.a(c5x2);
					c5x a_ = c5x2;
					string a_2 = "ExplosionSmall";
					int a_3 = 1;
					double maxValue = double.MaxValue;
					bool a_4 = true;
					bool a_5 = false;
					float? a_6 = dz6.b();
					boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
					c5x2.c().a("death", "CameraExplosion", 1f, c9z.a, false, false);
				}
				if (c5x.t.b != null)
				{
					bja bja = e5v.f(c5x.t.b);
					if (bja != null)
					{
						bt4 a_7 = new bt4(c5x.Area.y8(), c5x.aj());
						bja.d(new asf(c5x.qe(), a_7));
					}
					cze classPropertyValue = c5x.t.b.y6().GetClassPropertyValue<cze>(ddq.ah);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary["CameraDestroyed"] = true;
					if (classPropertyValue != null)
					{
						classPropertyValue.ym(c5x, (bja != null) ? bja.a8() : null, dictionary);
					}
				}
			}
			catch
			{
			}
		}
	}
}
