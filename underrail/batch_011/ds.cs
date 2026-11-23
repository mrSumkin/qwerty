using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001487 RID: 5255
[eiz("D0")]
[Serializable]
public sealed class ds : a6k, ISerializable
{
	// Token: 0x06007679 RID: 30329 RVA: 0x00321E4C File Offset: 0x0032004C
	private ds(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600767A RID: 30330 RVA: 0x00321E58 File Offset: 0x00320058
	public ds()
	{
	}

	// Token: 0x0600767B RID: 30331 RVA: 0x00321E64 File Offset: 0x00320064
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		ed2 ed = c5x.r.b as ed2;
		if (ed == null)
		{
			return dc4.e;
		}
		int num = base.vg().q().h.b.aa().Skills.Get<c0b>().g();
		if (ed.a() == base.vg().q().h.b || num >= ed.d)
		{
			cos cos = ed.e();
			if (cos != null && cos.TrapItem != null && (ed.a() == base.vg().q().h.b || num >= ed.d + 20))
			{
				if (base.vg().q().IsPlayer)
				{
					bmj.a(base.vg().q(), new d53("Ловушка снята!", adi.h, null, false));
				}
				mk mk = new mk();
				mk.StaticItems.z3(cos.TrapItem.fy(), true);
				mk.GiveTo = bvl.c;
				mk.ym(null, base.vg().q(), null);
			}
			else if (base.vg().q().IsPlayer)
			{
				bmj.a(base.vg().q(), new d53("Ловушка обезврежена.", adi.h, null, false));
			}
			if (cos != null)
			{
				cos.o();
				ed.a8().an();
			}
			if (!string.IsNullOrEmpty(ed.g))
			{
				base.vg().q().c().a("trapDisarm", ed.g, 1f, c9z.a, false, false);
			}
			if (ed.f != base.vg().q().h.b.aa().FactionId && base.vg().q().IsPlayer)
			{
				e3q e3q = base.vg().e().b8() as e3q;
				if (e3q != null && e3q.e() == ExperienceSystem.Classic)
				{
					int a_ = Convert.ToInt32(c2h.d(c2h.d(base.vg().q().h.b.aa()), ed.d));
					base.vg().q().h.b.a(a_, null);
				}
				cxc.a(eyy.bq);
			}
		}
		else if (num <= ed.d - 15)
		{
			cos cos2 = ed.e();
			if (cos2 != null)
			{
				cos2.a(base.vg().q());
			}
			if (base.vg().q().IsPlayer)
			{
				bmj.a(base.vg().q(), new d53("Критическая неудача!", adi.l, null, false));
			}
		}
		else if (base.vg().q().IsPlayer)
		{
			bmj.a(base.vg().q(), new d53("Обезвреживание не удалось. Недостаточно навыка.", adi.m, null, false));
		}
		return dc4.c;
	}
}
