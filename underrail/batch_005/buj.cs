using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;

// Token: 0x02001474 RID: 5236
[eiz("VA1")]
[Serializable]
public sealed class buj : a6k, ISerializable
{
	// Token: 0x06007636 RID: 30262 RVA: 0x0031F100 File Offset: 0x0031D300
	private buj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007637 RID: 30263 RVA: 0x0031F10C File Offset: 0x0031D30C
	public buj()
	{
	}

	// Token: 0x06007638 RID: 30264 RVA: 0x0031F118 File Offset: 0x0031D318
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		eym.a(base.vg().q(), 0.0);
		boj.a(new ah7("vanishFlash", null)
		{
			LightFadeRate = 0.1f,
			Range = 4f,
			Light = new ae8(Color.White, 0.75f, LightType.Increment)
		}, 100, base.vg().q().Area, base.vg().q().Location);
		aud a_ = base.vg().q().Area;
		Vector3 a_2 = base.vg().q().Location.b().b();
		HorizontalDirection? a_3 = null;
		string a_4 = "SmokeBombPuff";
		int a_5 = 1;
		double maxValue = double.MaxValue;
		float? a_6 = dz6.b();
		boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, null);
		aud a_7 = base.vg().q().Area;
		Vector3 a_8 = base.vg().q().Location.b().b();
		HorizontalDirection? a_9 = null;
		string a_10 = "FastFlash";
		int a_11 = 1;
		double maxValue2 = double.MaxValue;
		a_6 = dz6.b();
		boj.a(a_7, a_8, a_9, a_10, a_11, maxValue2, null, null, a_6, null);
		base.vg().q().c().a("VanishingPowderGrenade");
		d02 serviceOrThrow = bpo.GetServiceOrThrow<d02>();
		bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(base.vg().q().h.b)), base.vg().e().b9()) as bl6;
		if (bl != null)
		{
			cp.a(bl, base.vg().q(), true);
			if (serviceOrThrow.ahg() && serviceOrThrow.ahe() != null && serviceOrThrow.ahe().b == base.vg().q().h.b)
			{
				double num = serviceOrThrow.ahe().c + (double)bl.d(null);
				dtb dtb = new dtb();
				dtb.ad().Add(new bm3(100));
				List<auv> list = dtb.ad();
				b00 b = new b00();
				b.b((int)num);
				list.Add(new a4s(b, null, new ar7(base.vg().q()), null));
				base.vg().q().Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
			foreach (d4n d4n in serviceOrThrow.ahl())
			{
				if (d4n.b != null && d4n.b.a8() != null && d4n.b != base.vg().q().h.b && !d4n.b.aa().Truesighted && d4n.b.a8().t.b != null)
				{
					bm6 b2 = d4n.b.a8().t.b;
					erl erl = b2.c(base.vg().q().h.b);
					if (erl != null && erl.f() == cem.d)
					{
						erl.a(cem.c);
						erl.a(0.0);
						EntityAspectReference<amc, amc> classPropertyValue = b2.y6().GetClassPropertyValue<EntityAspectReference<amc, amc>>(cy1.b);
						if (classPropertyValue != null && classPropertyValue.ao() == base.vg().q().h.b)
						{
							e4w.b(b2.y6());
						}
					}
				}
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
