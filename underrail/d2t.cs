using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200140F RID: 5135
[bs6("ElectroshockAuraTickAction")]
[eiz("EATA6")]
[Serializable]
public sealed class d2t : bhv, ISerializable
{
	// Token: 0x0600734C RID: 29516 RVA: 0x00309A24 File Offset: 0x00307C24
	private d2t(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600734D RID: 29517 RVA: 0x00309A30 File Offset: 0x00307C30
	public d2t()
	{
	}

	// Token: 0x0600734E RID: 29518 RVA: 0x00309A3C File Offset: 0x00307C3C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.x0().a() != null && base.x2() != null && base.x2().a8() != null)
		{
			List<amc> list = aw1.a(base.x2().a8(), 1);
			coh coh = base.x2().aa().Gear.l().Item;
			if (coh != null)
			{
				if (coh.Battery < cs4.e)
				{
					return dc4.e;
				}
				coh.Battery = Math.Max(0.0, coh.Battery - cs4.e);
				if (list != null && list.Count > 0)
				{
					foreach (amc amc in list)
					{
						if (coh.Battery == 0.0)
						{
							break;
						}
						coh.Battery = Math.Max(0.0, coh.Battery - cs4.f);
						cwt a_ = d2t.a(base.x2().aa(), amc.aa());
						dtb a_2 = d2t.a(base.x2(), amc, a_);
						base.x2().a8().Zone.ActionManager.g9(a_2, atp.a);
						dz6.a(a_2);
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x00309BB8 File Offset: 0x00307DB8
	public static dtb a(amc A_0, amc A_1, cwt A_2)
	{
		if (A_0 == null || A_1 == null || A_2 == null)
		{
			return null;
		}
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		dtb.ad().Add(new bm3(dz6.b((int)(100.0 + 100.0 * cuo.a.NextDouble()))));
		List<auv> list = dtb.ad();
		c5x a_ = A_1.a8();
		string a_2 = "Electricity";
		int maxValue = int.MaxValue;
		double a_3 = (double)dz6.b(300);
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, maxValue, a_3, a_4, a_5, null, null, null, a_6, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(A_1.a8()), null));
		dtb.ad().Add(new akg(A_0, A_1, A_2, new dlq(), false));
		awq.a(dtb, A_0.a8(), A_1.a8(), true, true);
		eym.a(dtb, A_1.a8(), (double)aju.bf);
		return dtb;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x00309CF4 File Offset: 0x00307EF4
	public static cwt a(efk A_0, efk A_1)
	{
		return new cwt
		{
			i = new ap9(A_0),
			j = new ap9(A_1),
			f = 
			{
				euf.a(cs4.a(), 1.0)
			},
			k = "Электрошоковая аура",
			b = true,
			h = ImpactSpeed.VeryHigh,
			w = true
		};
	}
}
