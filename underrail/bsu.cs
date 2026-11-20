using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200168A RID: 5770
[eiz("WPEA")]
[Serializable]
public sealed class bsu : h3, ISerializable, cuu
{
	// Token: 0x06007DD6 RID: 32214 RVA: 0x003529A0 File Offset: 0x00350BA0
	private bsu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("WPEA:I", typeof(Guid));
		di7.ReadList<Guid>("WPEA:A", ref this.c, A_0);
		this.d = (Point)A_0.GetValue("WPEA:S", typeof(Point));
		this.b = (A_0.GetValue("WPEA:AP", typeof(ekt)) as ekt);
		this.e = new a1q?((a1q)A_0.GetValue("WPEA:FD", typeof(a1q)));
		this.f = new a1q?((a1q)A_0.GetValue("WPEA:MD", typeof(a1q)));
		this.g = A_0.GetString("WPEA:M");
		this.h = (A_0.GetValue("WPEA:CB", typeof(enp)) as enp);
	}

	// Token: 0x06007DD7 RID: 32215 RVA: 0x00352AAC File Offset: 0x00350CAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WPEA:I", this.a);
		di7.WriteList<Guid>("WPEA:A", this.c, info);
		info.AddValue("WPEA:S", this.d);
		info.AddValue("WPEA:AP", this.b);
		info.AddValue("WPEA:FD", this.e);
		info.AddValue("WPEA:MD", this.f);
		info.AddValue("WPEA:M", this.g);
		info.AddValue("WPEA:CB", this.h);
	}

	// Token: 0x06007DD8 RID: 32216 RVA: 0x00352B60 File Offset: 0x00350D60
	public bsu()
	{
	}

	// Token: 0x06007DD9 RID: 32217 RVA: 0x00352B74 File Offset: 0x00350D74
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		float? num;
		int? num2;
		if (A_2 == 0f)
		{
			boj.c(A_0, A_1);
			if (boj.b(A_0, A_1))
			{
				boj.a(A_0, A_1);
				Vector3 a_ = A_1.a() + new Vector3(0.4f, 0.4f, 0f);
				HorizontalDirection? a_2 = null;
				string a_3 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
				int a_4 = 1;
				double maxValue = double.MaxValue;
				num = new float?(0.66f);
				num2 = null;
				int? a_5 = num2;
				float? a_6 = num;
				float? a_7 = null;
				num2 = null;
				boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num2);
			}
		}
		Vector3 a_8 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_9 = null;
		string a_10 = "white_phosphore_explosion";
		int a_11 = 1;
		double maxValue2 = double.MaxValue;
		num = dz6.b();
		num2 = new int?(cuo.a.Next(3));
		boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, null, null, num, num2);
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				double num3 = (double)(4f - A_2);
				num3 *= 0.75 + 0.5 * cuo.a.NextDouble();
				num3 = d05.b(1.0, num3, 4.0);
				bpv.a("whitePhosphorusGas", num3, ak, null, false, false, new double?((double)dz6.b(Convert.ToInt32(250f + A_2 * 100f))));
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.c.Contains(b0b.qe()))
					{
						this.a(c5x.h.b, A_2);
						this.c.Add(c5x.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007DDA RID: 32218 RVA: 0x00352DD4 File Offset: 0x00350FD4
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				awq.a(base.c(), A_0, true, true, null, true, true, false, false);
			}
			A_0.u();
			float num = 0.15f;
			double num2;
			if (A_1 > 1f)
			{
				num2 = Math.Min(c18.az, (double)((A_1 - 1f) * num));
			}
			else
			{
				num2 = 0.0;
			}
			double a_ = 0.0;
			double num3 = 1.0;
			double ak = 0.0;
			double num4 = 0.0;
			double num5 = 1.0;
			if (this.b != null)
			{
				xo xo = this.b.a(base.c(), A_0);
				a_ = xo.a;
				num3 = xo.b;
				num4 = xo.c;
				ak = xo.d;
				num5 = xo.e;
			}
			bool flag = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			double num6 = (1.0 - num2) * (1.0 + num4) * num5;
			if (flag)
			{
				num6 *= 1.0 + num3;
			}
			cwt cwt = new cwt();
			cwt.af = this.a;
			cwt.f.Add(euf.a(this.e.Value, num6));
			cwt.b = true;
			cwt.e = flag;
			cwt.x = AmmoType.HighExplosives;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = this.g;
			cwt.ad["IsTrap"] = false;
			cwt.ad["IsGrenade"] = false;
			cwt.ad["IsExplosion"] = true;
			cwt.ae = new WeaponSubtype?(WeaponSubtype.RocketLauncher_84);
			cru cru = A_0.aa().Defense.a(cwt);
			if (cru != null)
			{
				bhd.a(base.c(), A_0, cru.a, 0.4000000059604645, 2.0, 5);
			}
			bps a_2 = null;
			bvd bvd = this.h as bvd;
			if (bvd != null)
			{
				a_2 = new bps();
				bvd.mm(base.c(), A_0, cwt, cru, a_2);
			}
			else if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt, cru);
			}
			cwt cwt2 = new cwt();
			cwt2.af = this.a;
			cwt2.f.Add(euf.a(this.f.Value, num6));
			cwt2.b = true;
			cwt2.e = flag;
			cwt2.x = AmmoType.HighExplosives;
			cwt2.q = true;
			cwt2.ak = ak;
			if (base.d().b8() != null)
			{
				cwt2.i = new ap9(base.d().b8());
			}
			cwt2.h = ImpactSpeed.High;
			cwt2.k = this.g;
			cwt2.ad["IsTrap"] = false;
			cwt2.ad["IsGrenade"] = false;
			cwt2.ad["IsExplosion"] = true;
			cwt2.ae = new WeaponSubtype?(WeaponSubtype.RocketLauncher_84);
			cru a_3 = A_0.aa().Defense.a(cwt2);
			if (bvd != null)
			{
				bvd.mm(base.c(), A_0, cwt2, a_3, a_2);
				return;
			}
			if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt2, a_3);
			}
		}
	}

	// Token: 0x040031DB RID: 12763
	public new Guid a;

	// Token: 0x040031DC RID: 12764
	public ekt b;

	// Token: 0x040031DD RID: 12765
	private List<Guid> c = new List<Guid>();

	// Token: 0x040031DE RID: 12766
	private Point d;

	// Token: 0x040031DF RID: 12767
	public a1q? e;

	// Token: 0x040031E0 RID: 12768
	public a1q? f;

	// Token: 0x040031E1 RID: 12769
	public string g;

	// Token: 0x040031E2 RID: 12770
	public enp h;
}
