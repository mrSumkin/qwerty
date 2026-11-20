using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001694 RID: 5780
[eiz("HEGA")]
[Serializable]
public sealed class e3n : h3, ISerializable, b6a
{
	// Token: 0x06007E1A RID: 32282 RVA: 0x00355CAC File Offset: 0x00353EAC
	private e3n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("HEGA:AE", ref this.a, A_0);
		this.b = (A_0.GetValue("HEGA:FD", typeof(a1q)) as a1q?);
		this.c = (A_0.GetValue("HEGA:MD", typeof(a1q)) as a1q?);
		this.d = A_0.GetString("HEGA:M");
		this.e = A_0.GetBoolean("HEGA:T");
		this.g = (Guid)A_0.GetValue("HEGA:I", typeof(Guid));
		if (ell.a() >= 663)
		{
			this.f = (A_0.GetValue("HEGA:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
		}
		if (ell.a() >= 669)
		{
			this.h = (A_0.GetValue("HEGA:CB", typeof(enp)) as enp);
			this.i = (A_0.GetValue("HEGA:AP", typeof(ekt)) as ekt);
		}
		if (ell.a() >= 679)
		{
			this.j = A_0.GetBoolean("HEGA:C");
		}
	}

	// Token: 0x06007E1B RID: 32283 RVA: 0x00355E0C File Offset: 0x0035400C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("HEGA:AE", this.a, info);
		info.AddValue("HEGA:FD", this.b);
		info.AddValue("HEGA:MD", this.c);
		info.AddValue("HEGA:M", this.d);
		info.AddValue("HEGA:T", this.e);
		info.AddValue("HEGA:I", this.g);
		info.AddValue("HEGA:GL", this.f);
		info.AddValue("HEGA:CB", this.h);
		info.AddValue("HEGA:AP", this.i);
		info.AddValue("HEGA:C", this.j);
	}

	// Token: 0x06007E1C RID: 32284 RVA: 0x00355EE0 File Offset: 0x003540E0
	public string tx()
	{
		return this.d;
	}

	// Token: 0x06007E1D RID: 32285 RVA: 0x00355EE8 File Offset: 0x003540E8
	public void ty(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007E1E RID: 32286 RVA: 0x00355EF4 File Offset: 0x003540F4
	public bool tz()
	{
		return this.e;
	}

	// Token: 0x06007E1F RID: 32287 RVA: 0x00355EFC File Offset: 0x003540FC
	public void t0(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007E20 RID: 32288 RVA: 0x00355F08 File Offset: 0x00354108
	public bool b()
	{
		return this.j;
	}

	// Token: 0x06007E21 RID: 32289 RVA: 0x00355F10 File Offset: 0x00354110
	public void a(bool A_0)
	{
		this.j = A_0;
	}

	// Token: 0x06007E22 RID: 32290 RVA: 0x00355F1C File Offset: 0x0035411C
	public e3n()
	{
		this.g = Guid.NewGuid();
	}

	// Token: 0x06007E23 RID: 32291 RVA: 0x00355F3C File Offset: 0x0035413C
	public e3n(Guid A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06007E24 RID: 32292 RVA: 0x00355F58 File Offset: 0x00354158
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (this.b == null)
		{
			this.a();
		}
		if (A_2 == 0f)
		{
			boj.c(A_0, A_1);
			if (boj.b(A_0, A_1))
			{
				boj.a(A_0, A_1);
				if (!this.j)
				{
					Vector3 a_ = A_1.a() + new Vector3(0.4f, 0.4f, 0f);
					HorizontalDirection? a_2 = null;
					string a_3 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
					int a_4 = 1;
					double maxValue = double.MaxValue;
					float? num = new float?(0.66f);
					int? num2 = null;
					int? a_5 = num2;
					float? a_6 = num;
					float? a_7 = null;
					num2 = null;
					boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num2);
				}
			}
		}
		int value = (int)base.a(A_1);
		double num3 = 0.7;
		if (A_2 == 0f)
		{
			if (this.j)
			{
				int y = cuo.a.Next(3);
				Vector3 a_8 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_9 = null;
				string a_10 = "ClusterExplosion";
				int a_11 = 1;
				double maxValue2 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_12 = num2;
				float? a_13 = null;
				float? a_14 = num;
				num2 = null;
				c5x c5x = boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, num2);
				if (c5x != null && c5x.o.b != null)
				{
					c5x.o.b.b = new Point(c5x.o.b.b.X, y);
				}
				Vector3 a_15 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_16 = null;
				string a_17 = "ClusterExplosionSmoke";
				int a_18 = 1;
				double maxValue3 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_19 = num2;
				float? a_20 = null;
				float? a_21 = num;
				num2 = null;
				c5x c5x2 = boj.a(A_0, a_15, a_16, a_17, a_18, maxValue3, a_19, a_20, a_21, num2);
				if (c5x2 != null && c5x2.o.b != null)
				{
					c5x2.o.b.b = new Point(c5x2.o.b.b.X, y);
				}
			}
			else
			{
				Vector3 a_22 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_23 = null;
				string a_24 = "ExplosionHE_C_Flame";
				int a_25 = 1;
				double maxValue4 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_26 = num2;
				float? a_27 = null;
				float? a_28 = num;
				num2 = null;
				boj.a(A_0, a_22, a_23, a_24, a_25, maxValue4, a_26, a_27, a_28, num2);
				Vector3 a_29 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_30 = null;
				string a_31 = "ExplosionHE_C_Smoke";
				int a_32 = 1;
				double maxValue5 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_33 = num2;
				float? a_34 = null;
				float? a_35 = num;
				num2 = null;
				boj.a(A_0, a_29, a_30, a_31, a_32, maxValue5, a_33, a_34, a_35, num2);
			}
		}
		else if (A_2 == 1f)
		{
			if (!this.j)
			{
				if (cuo.a.NextDouble() < num3)
				{
					Vector3 a_36 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_37 = null;
					string a_38 = "ExplosionHE_O_Flame";
					int a_39 = 1;
					double maxValue6 = double.MaxValue;
					float? num = dz6.b();
					int? num2 = new int?(value);
					boj.a(A_0, a_36, a_37, a_38, a_39, maxValue6, null, null, num, num2);
					Vector3 a_40 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_41 = null;
					string a_42 = "ExplosionHE_O_Smoke";
					int a_43 = 1;
					double maxValue7 = double.MaxValue;
					num = dz6.b();
					num2 = new int?(value);
					boj.a(A_0, a_40, a_41, a_42, a_43, maxValue7, null, null, num, num2);
				}
				else
				{
					Vector3 a_44 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_45 = null;
					string a_46 = "ExplosionHE_O_Weak_Flame";
					int a_47 = 1;
					double maxValue8 = double.MaxValue;
					float? num = dz6.b();
					int? num2 = null;
					int? a_48 = num2;
					float? a_49 = null;
					float? a_50 = num;
					num2 = null;
					boj.a(A_0, a_44, a_45, a_46, a_47, maxValue8, a_48, a_49, a_50, num2);
					Vector3 a_51 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
					HorizontalDirection? a_52 = null;
					string a_53 = "ExplosionHE_O_Weak_Smoke";
					int a_54 = 1;
					double maxValue9 = double.MaxValue;
					num = dz6.b();
					num2 = null;
					int? a_55 = num2;
					float? a_56 = null;
					float? a_57 = num;
					num2 = null;
					boj.a(A_0, a_51, a_52, a_53, a_54, maxValue9, a_55, a_56, a_57, num2);
				}
			}
		}
		else if (!this.j)
		{
			if (cuo.a.NextDouble() < num3)
			{
				Vector3 a_58 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_59 = null;
				string a_60 = "ExplosionHE_O_Weak_Flame1";
				int a_61 = 1;
				double maxValue10 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = new int?(value);
				boj.a(A_0, a_58, a_59, a_60, a_61, maxValue10, null, null, num, num2);
				Vector3 a_62 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_63 = null;
				string a_64 = "ExplosionHE_O_Weak_Smoke1";
				int a_65 = 1;
				double maxValue11 = double.MaxValue;
				num = dz6.b();
				num2 = new int?(value);
				boj.a(A_0, a_62, a_63, a_64, a_65, maxValue11, null, null, num, num2);
			}
			else
			{
				Vector3 a_66 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_67 = null;
				string a_68 = "ExplosionHE_O_Weak_Flame";
				int a_69 = 1;
				double maxValue12 = double.MaxValue;
				float? num = dz6.b();
				int? num2 = null;
				int? a_70 = num2;
				float? a_71 = null;
				float? a_72 = num;
				num2 = null;
				boj.a(A_0, a_66, a_67, a_68, a_69, maxValue12, a_70, a_71, a_72, num2);
				Vector3 a_73 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
				HorizontalDirection? a_74 = null;
				string a_75 = "ExplosionHE_O_Weak_Smoke";
				int a_76 = 1;
				double maxValue13 = double.MaxValue;
				num = dz6.b();
				num2 = null;
				int? a_77 = num2;
				float? a_78 = null;
				float? a_79 = num;
				num2 = null;
				boj.a(A_0, a_73, a_74, a_75, a_76, maxValue13, a_77, a_78, a_79, num2);
			}
		}
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x3 = b0b as c5x;
					if (c5x3 != null)
					{
						if (c5x3.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x3.h.b, A_2);
							this.a.Add(c5x3.qe());
						}
						if (c5x3.y.b != null)
						{
							c5x3.y.b.a(null);
							this.a.Add(c5x3.qe());
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E25 RID: 32293 RVA: 0x00356698 File Offset: 0x00354898
	private void a()
	{
		int a_ = c18.a(base.d());
		this.b = new a1q?(c18.r(a_));
		this.c = new a1q?(c18.q(a_));
	}

	// Token: 0x06007E26 RID: 32294 RVA: 0x003566D4 File Offset: 0x003548D4
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				bool flag;
				if (this.e)
				{
					ZoneControlLevel zoneControlLevel;
					if (!A_0.aa().Passive)
					{
						zoneControlLevel = eir.a(A_0.a8().Zone, A_0.aa().FactionId);
					}
					else
					{
						zoneControlLevel = ZoneControlLevel.Uncontrolled;
					}
					flag = (zoneControlLevel > ZoneControlLevel.Uncontrolled);
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					awq.a(base.c(), A_0, !this.e, true, null, true, !this.e, false, false);
				}
			}
			A_0.u();
			double num;
			if (A_1 > 1f)
			{
				num = Math.Min(c18.az, (double)(A_1 - 1f) * c18.a0);
			}
			else
			{
				num = 0.0;
			}
			double a_ = 0.0;
			double num2 = 1.0;
			double ak = 0.0;
			double num3 = 0.0;
			double num4 = 1.0;
			if (this.i != null)
			{
				xo xo = this.i.a(base.c(), A_0);
				a_ = xo.a;
				num2 = xo.b;
				num3 = xo.c;
				ak = xo.d;
				num4 = xo.e;
			}
			else if (!this.e && base.c() != null)
			{
				a_ = c18.a(base.c().aa());
			}
			bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			double num5 = (1.0 - num) * (1.0 + num3) * num4;
			if (flag2)
			{
				num5 *= 1.0 + num2;
			}
			bool flag3 = !this.e && this.f.GetValueOrDefault() != WeaponSubtype.RocketLauncher_84;
			cwt cwt = new cwt();
			cwt.af = this.g;
			cwt.f.Add(euf.a(this.b.Value, num5));
			cwt.b = true;
			cwt.e = flag2;
			cwt.x = AmmoType.HighExplosives;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = ((this.d != null) ? this.d : "фугасная граната");
			cwt.ad["IsTrap"] = this.e;
			cwt.ad["IsGrenade"] = flag3;
			cwt.ad["IsExplosion"] = true;
			cwt.ae = this.f;
			cru a_2 = A_0.aa().Defense.a(cwt);
			bps a_3 = null;
			bvd bvd = this.h as bvd;
			if (bvd != null)
			{
				a_3 = new bps();
				bvd.mm(base.c(), A_0, cwt, a_2, a_3);
			}
			else if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt, a_2);
			}
			cwt cwt2 = new cwt();
			cwt2.af = this.g;
			cwt2.f.Add(euf.a(this.c.Value, num5));
			cwt2.b = true;
			cwt2.e = flag2;
			cwt2.x = AmmoType.HighExplosives;
			cwt2.q = true;
			cwt2.ak = ak;
			if (base.d().b8() != null)
			{
				cwt2.i = new ap9(base.d().b8());
			}
			cwt2.h = ImpactSpeed.High;
			cwt2.k = ((this.d != null) ? this.d : "фугасная граната");
			cwt2.ad["IsTrap"] = this.e;
			cwt2.ad["IsGrenade"] = flag3;
			cwt2.ad["IsExplosion"] = true;
			cwt2.ae = this.f;
			cru a_4 = A_0.aa().Defense.a(cwt2);
			if (bvd != null)
			{
				bvd.mm(base.c(), A_0, cwt2, a_4, a_3);
				return;
			}
			if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt2, a_4);
			}
		}
	}

	// Token: 0x04003208 RID: 12808
	private new List<Guid> a = new List<Guid>();

	// Token: 0x04003209 RID: 12809
	public a1q? b;

	// Token: 0x0400320A RID: 12810
	public a1q? c;

	// Token: 0x0400320B RID: 12811
	private string d;

	// Token: 0x0400320C RID: 12812
	private bool e;

	// Token: 0x0400320D RID: 12813
	public WeaponSubtype? f;

	// Token: 0x0400320E RID: 12814
	private Guid g;

	// Token: 0x0400320F RID: 12815
	public enp h;

	// Token: 0x04003210 RID: 12816
	public ekt i;

	// Token: 0x04003211 RID: 12817
	private bool j;
}
