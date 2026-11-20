using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001607 RID: 5639
[eiz("P41")]
[Serializable]
public sealed class a9o : a6k, ISerializable
{
	// Token: 0x06007C10 RID: 31760 RVA: 0x00340F8C File Offset: 0x0033F18C
	private a9o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C11 RID: 31761 RVA: 0x00340F98 File Offset: 0x0033F198
	public a9o()
	{
	}

	// Token: 0x06007C12 RID: 31762 RVA: 0x00340FA0 File Offset: 0x0033F1A0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || ak.Zone == null)
		{
			return dc4.e;
		}
		base.vg().i();
		if (base.vg().q() != null)
		{
			foreach (aud aud in ak.Zone.Areas)
			{
				foreach (ya ya in Enumerable.ToList<ya>(aud.Triggers))
				{
					ba9 ba = ya as ba9;
					if (ba != null && ba.TrapEntity != null)
					{
						ed2 ed = ba.TrapEntity.GetAspect<b4h>() as ed2;
						if (ed != null && ed.a() == base.vg().q().h.b)
						{
							ya.o();
							dtb dtb = new dtb();
							dtb.b(false);
							dtb.c(false);
							List<auv> list = dtb.ad();
							ad6 ad = new ad6(ba.TrapEntity);
							ad.b(1.0);
							ad.c(0.0);
							ad.a(dz6.a(0.001));
							list.Add(ad);
							dtb.ad().Add(new c7(ba.TrapEntity, false, false, true, false));
							ak.Zone.ActionManager.g9(dtb, atp.a);
							dz6.a(dtb);
						}
					}
				}
			}
		}
		if ((ak.Formation.c(2L) && !ak.Formation.c(128L)) || ak.f(null) != 0L)
		{
			if (base.vg().q().IsPlayer)
			{
				bmj.a(base.vg().q(), new d53("Можно установить только на незанятое место.", adi.l, null, false));
			}
			return dc4.e;
		}
		IEnumerable<cos> enumerable = Enumerable.OfType<cos>(ak.a(typeof(cos)) ?? new List<ya>());
		bool flag = false;
		foreach (cos cos in enumerable)
		{
			cos.b();
			flag = true;
		}
		ak1 ak2;
		if (flag)
		{
			ak2 = base.vg().q().Area.a(base.vg().q().aj().a());
			if (ak2 == null)
			{
				return dc4.e;
			}
		}
		else
		{
			ak2 = ak;
		}
		d02 service = bpo.GetService<d02>();
		cnk service2 = bpo.GetService<cnk>();
		List<Guid> list2 = new List<Guid>();
		if (service2 != null && service != null && service2.aqu() != null)
		{
			r0 r = new r0(ak2.Area.c(), new Vector2((float)ak2.Location.X, (float)ak2.Location.Y));
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b.aa().a(service2.aqu().ac(), base.vg().e().b8().FactionId) == h.e)
				{
					list2.Add(d4n.b.a8().qe());
				}
				else if (service.ahg() && d4n.b != null && d4n.b.a8() != null && d4n.b.a8().t.b != null && d4n.b.a8().t.b.b(service).Contains(r))
				{
					double num = aw1.a(d4n.b.a8(), ak2);
					if (d4n.b.aa().b(d8o.b | d8o.d | d8o.h) && num <= (double)Math.Min(4f, d4n.b.aa().SightRange))
					{
						awq.a(d4n.b.a8(), base.vg().q(), false, false, false, true, false, false);
					}
				}
			}
		}
		c5x c5x = vq.a("objects\\special\\ElectrokineticImprint", false);
		if (c5x == null)
		{
			return dc4.e;
		}
		c5x.Location = ak2.Location.a();
		c5x.Layer = aju.x;
		c5x.TileFormationModifiers.s3(10);
		b30 aspect = new b30(c5x);
		c5x.SetAspect<b30>(aspect);
		ak2.Area.a(c5x);
		c5x.c().a("InscribeElectroGlyph");
		ad6 ad2 = new ad6(c5x);
		ad2.b(0.0);
		ad2.c(1.0);
		ad2.a(dz6.a(0.001));
		ad6 a_ = ad2;
		ak2.Zone.ActionManager.g9(a_, atp.a);
		dz6.a(a_);
		ed2 ed2 = new ed2(c5x, base.vg().q().h.b);
		ed2.a(int.MaxValue);
		foreach (Guid guid in list2)
		{
			ed2.a.Add(guid);
		}
		double num2 = (double)base.vg().e().b8().Offense.ag()[PsiSchool.Psychokinesis].b() * 1.25;
		ed2.c = (int)num2;
		ed2.d = int.MaxValue;
		ed2.a.Add(base.vg().q().qe());
		if (base.vg().q().IsPlayer)
		{
			ed2.a(true);
		}
		c5x.SetAspect<b4h>(ed2);
		do6 @do = new do6(c5x);
		@do.d().Add(new asz());
		c5x.SetAspect<do6>(@do);
		int a_2 = 10;
		if (base.vg().q().h.b != null)
		{
			a_2 = base.vg().q().h.b.aa().Offense.ag()[PsiSchool.Psychokinesis].b();
		}
		ba9 ba2 = new ba9(c5x, a_2);
		if (ba2 != null)
		{
			ba2.Location = ak2.Location;
			ba2.Size = new esj(1, 1);
			ba2.Layer = aju.x;
			ba2.TriggeringRadius = new double?(0.55);
			ak2.Area.b(ba2);
			if (flag)
			{
				ba2.a(base.vg().q());
			}
			return dc4.c;
		}
		return dc4.e;
	}
}
