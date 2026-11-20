using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020015F2 RID: 5618
[eiz("L77")]
[Serializable]
public sealed class c7h : a6k, ISerializable
{
	// Token: 0x06007BB4 RID: 31668 RVA: 0x0033CFC4 File Offset: 0x0033B1C4
	private c7h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BB5 RID: 31669 RVA: 0x0033CFD0 File Offset: 0x0033B1D0
	public c7h()
	{
	}

	// Token: 0x06007BB6 RID: 31670 RVA: 0x0033CFDC File Offset: 0x0033B1DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		awq.a(qy, base.vg().q(), c5x, true, true);
		bfq bfq = new bfq();
		bfq.b("xpbl_TemporalDistorsionApply" + Guid.NewGuid().ToString());
		bfq.c("xpbl_TemporalDistorsionApply");
		bfq.d.a = true;
		bfq.d.b = "temporalDistortion";
		bfq.d.c = 150;
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		c5x a_ = c5x;
		string a_2 = "Xpbl_TemporalDistorsionApply";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		a7j item = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
		qy.ad().Add(item);
		if (c5x.h.b.aa().d(CharacterImmunities.TemporalEffects))
		{
			etm a_7 = new etm(new ap9(c5x.h.b.aa()), "временному эффекту");
			bey.a(a_7, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			anw item2 = new anw(a_7);
			b8p item3 = new b8p(c5x, new ba0());
			qy.ad().Add(item2);
			qy.ad().Add(item3);
		}
		else
		{
			int a_8 = ed3.k * d0u.b;
			double a_9 = c7h.a(c5x.h.b.aa(), ref a_8);
			List<a1q> list = ed3.a(base.vg().e());
			bha bha = new bha(a_8, new ap9(base.vg().e().b8()), list[0], list[1], a_9, base.vg().e().b8().Feats.Contains<d3w>(), Math.Round(d3w.a + (double)base.vg().e().b8().GetSpecializationValue<eo1>(true) * eo1.a, 2));
			qy.ad().Add(new amd(c5x.h.b, new els[]
			{
				bha
			}));
			cyk microfeat = base.vg().q().h.b.aa().GetMicrofeat<cyk>();
			if (microfeat != null && cuo.a.NextDouble() < microfeat.a())
			{
				qy.ad().Add(new e2t(new EntityAspectReference<amc, amc>(c5x.h.b), new ap9(base.vg().q().h.b.aa()), list[0], list[1]));
			}
		}
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}

	// Token: 0x06007BB7 RID: 31671 RVA: 0x0033D364 File Offset: 0x0033B564
	public static double a(efk A_0, ref int A_1)
	{
		double? num = null;
		double num2 = 1.0;
		foreach (bha bha in A_0.StatusEffects.Get<bha>())
		{
			double val = num2;
			bha bha2 = bha;
			double val2;
			bha2.a(val2 = bha2.b() + ed3.j);
			num2 = Math.Max(val, val2);
			if (num == null)
			{
				num = new double?(bha.TimeLeft);
			}
			else
			{
				num = new double?((double)((int)Math.Min(num.Value, bha.TimeLeft)));
			}
		}
		if (num != null)
		{
			A_1 = (int)num.Value;
		}
		return num2;
	}
}
