using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001610 RID: 5648
[eiz("XTD")]
[Serializable]
public sealed class cdx : a6k, ISerializable
{
	// Token: 0x06007C35 RID: 31797 RVA: 0x00343364 File Offset: 0x00341564
	private cdx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C36 RID: 31798 RVA: 0x00343370 File Offset: 0x00341570
	public cdx()
	{
	}

	// Token: 0x06007C37 RID: 31799 RVA: 0x00343378 File Offset: 0x00341578
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		cdx.a(c5x);
		c5x.c().a("Transmute");
		if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
		{
			u6.a(base.vg().q().h.b);
			u6.a(base.vg().q().h.b, false);
		}
		awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
		int a_ = (int)Math.Max(1.0, (double)c5x.h.b.aa().Defense.q().zo() * aph.a(base.vg().e()));
		double a_2 = 0.0;
		if (base.vg().e().b8().Feats.Contains<xk>())
		{
			a_2 = xk.a(base.vg().e());
		}
		c5x.h.b.aa().StatusEffects.a(new d0f(aph.b * d0u.b, a_, a_2), false, false, false);
		awq.a(c5x.h.b, false);
		return dc4.c;
	}

	// Token: 0x06007C38 RID: 31800 RVA: 0x00343534 File Offset: 0x00341734
	private static void a(c5x A_0)
	{
		Vector3 vector = A_0.aj();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					Vector3 vector2 = new Vector3(vector.X + (float)i, vector.Y + (float)j, 0f);
					Point point = vector2.a();
					if (point.X >= 0 && point.Y >= 0 && point.X < A_0.Area.Size.c && point.Y < A_0.Area.Size.d)
					{
						for (float num = 0f; num <= 2f; num += 0.33f)
						{
							vector2.Z = num;
							cdx.a(A_0.Area, vector2, new Vector3(vector.X, vector.Y, vector.Z));
						}
					}
				}
			}
		}
	}

	// Token: 0x06007C39 RID: 31801 RVA: 0x0034363C File Offset: 0x0034183C
	private static void a(aud A_0, Vector3 A_1, Vector3 A_2)
	{
		double num = (double)Vector3.Distance(A_1, A_2);
		b0b b0b;
		auv a_ = es2.a(A_1, A_2, A_0, "SmallRedEnergyBall", null, out b0b);
		e4o e4o = new e4o(b0b as c5x);
		e4o.a(200);
		e4o.b(0);
		e4o.a(dz6.a(0.1 + 0.3 / num));
		qy qy = new qy();
		qy.ad().Add(e4o);
		qy.ad().Add(new c7(b0b, false, false, true, false));
		A_0.Zone.ActionManager.g9(a_, atp.a);
		A_0.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(a_);
		dz6.a(qy);
	}

	// Token: 0x04003154 RID: 12628
	private new static readonly Random a = new Random();
}
