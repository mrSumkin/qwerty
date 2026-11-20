using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200182C RID: 6188
[eiz("XESA")]
[Serializable]
public sealed class caw : a6k, ISerializable, enp
{
	// Token: 0x060083D7 RID: 33751 RVA: 0x0036F99C File Offset: 0x0036DB9C
	private caw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060083D8 RID: 33752 RVA: 0x0036F9A8 File Offset: 0x0036DBA8
	public caw()
	{
	}

	// Token: 0x060083D9 RID: 33753 RVA: 0x0036F9B4 File Offset: 0x0036DBB4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		if (base.vg().e().b8().Offense.u().Battery < (double)global::w.a)
		{
			return dc4.e;
		}
		base.vg().e().b8().Offense.u().Battery -= (double)global::w.a;
		cmn cmn = awq.b(base.vg().q().h.b, c5x.h.b, null);
		cmn.a = c3u.a;
		cwt cwt = euf.a(base.vg().e().b8(), c5x.h.b.aa(), cmn, 0.0, null, 1.0, null, true);
		cwt.f.Clear();
		cwt.k = "Вытягивание энергии касанием";
		cd1 a_ = base.vg().e().b8().Offense.u();
		awq.a(base.vg().q().h.b, c5x.h.b, cwt, a_, this);
		return dc4.c;
	}

	// Token: 0x060083DA RID: 33754 RVA: 0x0036FB5C File Offset: 0x0036DD5C
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_0 != null && !A_1.aa().Dead && A_2.b)
		{
			boj.a(A_1.a8(), "Electricity", 1, double.MaxValue, true, true, null, null, null, null, false);
			A_1.a8().c().a(Guid.NewGuid().ToString(), "Tazer", 0.4f, c9z.a, false, false);
			if (A_1.aa().b(d8o.e) || A_1.aa().FactionId == asp.a0)
			{
				cwt cwt = new cwt();
				cwt.i = new ap9(base.vg().e().b8());
				cwt.j = new ap9(A_1.aa());
				cwt.b = true;
				cwt.f.Add(euf.a(global::w.f, 1.0));
				cwt.p = true;
				cwt.l = true;
				cwt.k = "Вытягивание энергии касанием";
				cru cru = A_1.aa().Defense.a(cwt);
				if (cru.a != null)
				{
					int num = Enumerable.Sum<csk>(cru.a, new Func<csk, int>(caw.a.a.a));
					if (num > 0)
					{
						double a_ = Math.Max(1.0, (double)num * global::w.g);
						this.a(A_0, a_);
						return;
					}
				}
			}
			else
			{
				if (A_1.aa().Vehicle != null)
				{
					double num2 = (double)cuo.a.Next(global::w.b, global::w.c + 1);
					num2 = Math.Min(A_1.aa().Vehicle.g(), num2);
					A_1.aa().Vehicle.h(num2);
					double num3 = num2 * global::w.d;
					if (num3 > 0.0)
					{
						this.a(A_0, num3);
					}
					this.a(A_1, num2, true);
					return;
				}
				double num4 = (double)cuo.a.Next(global::w.b, global::w.c + 1);
				num4 = this.b(A_1, num4);
				double num5 = num4 * global::w.d;
				if (num5 > 0.0)
				{
					this.a(A_0, num5);
				}
				this.a(A_1, num4, false);
			}
		}
	}

	// Token: 0x060083DB RID: 33755 RVA: 0x0036FDF8 File Offset: 0x0036DFF8
	private double b(amc A_0, double A_1)
	{
		double num = 0.0;
		if (A_0 != null && A_1 > 0.0)
		{
			List<coh> list = new List<coh>();
			using (List<coh>.Enumerator enumerator = A_0.aa().Gear.i().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					coh coh = enumerator.Current;
					if (coh.MaxBattery > 0 && coh.Battery > 0.0)
					{
						list.Add(coh);
					}
				}
				goto IL_100;
			}
			IL_8B:
			double val = A_1 / (double)list.Count;
			for (int i = 0; i < list.Count; i++)
			{
				coh coh2 = list[i];
				double num2 = Math.Min(coh2.Battery, val);
				coh2.Battery -= num2;
				A_1 -= num2;
				num += num2;
				if (coh2.Battery == 0.0)
				{
					list.RemoveAt(i);
					i--;
				}
			}
			IL_100:
			if (list.Count > 0 && A_1 > 0.0)
			{
				goto IL_8B;
			}
		}
		return num;
	}

	// Token: 0x060083DC RID: 33756 RVA: 0x0036FF34 File Offset: 0x0036E134
	private void a(amc A_0, double A_1, bool A_2)
	{
		int num = Convert.ToInt32(A_1 * global::w.e);
		if (num > 0)
		{
			cwt cwt = new cwt();
			cwt.i = new ap9(base.vg().e().b8());
			cwt.j = new ap9(A_0.aa());
			cwt.b = true;
			cwt.c = new bool?(A_2);
			cwt.f.Add(new csk(DamageType.Electricity, num));
			cwt.p = true;
			cwt.l = true;
			cwt.k = "Вытягивание энергии касанием";
			A_0.aa().Defense.a(cwt);
			return;
		}
		etm a_ = new etm(new ap9(A_0.aa()), "вытягивание энергии");
		bey.a(a_, base.vg().e().b8(), A_0.aa(), A_0);
		a7v.a(a_);
		bmj.a(A_0.a8(), new ba0());
	}

	// Token: 0x060083DD RID: 33757 RVA: 0x00370020 File Offset: 0x0036E220
	private void a(amc A_0, double A_1)
	{
		if (A_0 != null && A_1 >= 0.1)
		{
			double num = 0.0;
			List<coh> list = new List<coh>();
			using (List<coh>.Enumerator enumerator = A_0.aa().Gear.i().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					coh coh = enumerator.Current;
					if (coh.MaxBattery > 0 && coh.Battery < (double)coh.MaxBattery)
					{
						list.Add(coh);
					}
				}
				goto IL_10C;
			}
			IL_89:
			double val = A_1 / (double)list.Count;
			for (int i = 0; i < list.Count; i++)
			{
				coh coh2 = list[i];
				double num2 = Math.Min((double)coh2.MaxBattery - coh2.Battery, val);
				coh2.Battery += num2;
				A_1 -= num2;
				num += num2;
				if (coh2.Battery == (double)coh2.MaxBattery)
				{
					list.RemoveAt(i);
					i--;
				}
			}
			IL_10C:
			if (list.Count > 0 && A_1 >= 0.1)
			{
				goto IL_89;
			}
			if (num > 0.0)
			{
				num = Math.Round(num, 2);
				boj.a(A_0.a8(), "MetallicSpark", 3, double.MaxValue, true, true, null, null, null, null, false);
				vr a_ = new vr(new ap9(A_0.aa()), null, "{0} перезаряжает " + num.ToString() + " энергии.", null, null);
				bey.a(a_, A_0.aa(), A_0);
				a7v.a(a_);
				bmj.a(A_0.a8(), new ccq(ScrollingCombatTextOptions.Buffs, "+" + num.ToString() + " энергии", adi.r, null, false));
			}
		}
	}

	// Token: 0x0200182D RID: 6189
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060083E0 RID: 33760 RVA: 0x0037024C File Offset: 0x0036E44C
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040032A1 RID: 12961
		public static readonly caw.a a = new caw.a();

		// Token: 0x040032A2 RID: 12962
		public static Func<csk, int> b;
	}
}
