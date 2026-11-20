using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001689 RID: 5769
[eiz("CSHEA")]
[Serializable]
public sealed class ic : h3, ISerializable, cuu
{
	// Token: 0x06007DD1 RID: 32209 RVA: 0x00352174 File Offset: 0x00350374
	private ic(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("CSHEA:I", typeof(Guid));
		di7.ReadList<Guid>("CSHEA:A", ref this.c, A_0);
		this.d = (Point)A_0.GetValue("CSHEA:S", typeof(Point));
		this.b = (A_0.GetValue("CSHEA:AP", typeof(ekt)) as ekt);
		this.e = new a1q?((a1q)A_0.GetValue("CSHEA:FD", typeof(a1q)));
		this.f = new a1q?((a1q)A_0.GetValue("CSHEA:MD", typeof(a1q)));
		this.g = A_0.GetString("CSHEA:M");
		this.h = (A_0.GetValue("CSHEA:CB", typeof(enp)) as enp);
	}

	// Token: 0x06007DD2 RID: 32210 RVA: 0x00352280 File Offset: 0x00350480
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSHEA:I", this.a);
		di7.WriteList<Guid>("CSHEA:A", this.c, info);
		info.AddValue("CSHEA:S", this.d);
		info.AddValue("CSHEA:AP", this.b);
		info.AddValue("CSHEA:FD", this.e);
		info.AddValue("CSHEA:MD", this.f);
		info.AddValue("CSHEA:M", this.g);
		info.AddValue("CSHEA:CB", this.h);
	}

	// Token: 0x06007DD3 RID: 32211 RVA: 0x00352334 File Offset: 0x00350534
	public ic()
	{
	}

	// Token: 0x06007DD4 RID: 32212 RVA: 0x00352348 File Offset: 0x00350548
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		int? num;
		float? num2;
		if (A_2 == 0f)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				ps ps = service;
				int a_ = 1000;
				num = null;
				int? a_2 = num;
				num = null;
				int? a_3 = num;
				num = null;
				int? a_4 = num;
				num = null;
				int? a_5 = num;
				num = null;
				ps.ane(a_, a_2, a_3, a_4, a_5, num);
			}
			boj.c(A_0, A_1);
			if (boj.b(A_0, A_1))
			{
				boj.a(A_0, A_1);
				Vector3 a_6 = A_1.a() + new Vector3(0.4f, 0.4f, 0f);
				HorizontalDirection? a_7 = null;
				string a_8 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
				int a_9 = 1;
				double maxValue = double.MaxValue;
				num2 = new float?(0.66f);
				num = null;
				int? a_10 = num;
				float? a_11 = num2;
				float? a_12 = null;
				num = null;
				boj.a(A_0, a_6, a_7, a_8, a_9, maxValue, a_10, a_11, a_12, num);
			}
		}
		int value = (int)a63.b(base.a(A_1));
		Vector3 a_13 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_14 = null;
		string a_15 = "flame_shockwave";
		int a_16 = 1;
		double maxValue2 = double.MaxValue;
		num2 = dz6.b();
		num = new int?(value);
		boj.a(A_0, a_13, a_14, a_15, a_16, maxValue2, null, null, num2, num);
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
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

	// Token: 0x06007DD5 RID: 32213 RVA: 0x00352588 File Offset: 0x00350788
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				awq.a(base.c(), A_0, true, true, null, true, true, false, false);
			}
			A_0.u();
			float num = 0.125f;
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
			cwt.x = AmmoType.None;
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
			cwt2.af = this.a;
			cwt2.f.Add(euf.a(this.f.Value, num6));
			cwt2.b = true;
			cwt2.e = flag;
			cwt2.x = AmmoType.None;
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
			cru a_4 = A_0.aa().Defense.a(cwt2);
			if (bvd != null)
			{
				bvd.mm(base.c(), A_0, cwt2, a_4, a_3);
			}
			else if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt2, a_4);
			}
			awq.b(base.c(), A_0, 2);
			if (cuo.a.NextDouble() < 0.5)
			{
				awq.a(base.c(), A_0, 2, false, false);
			}
		}
	}

	// Token: 0x040031D3 RID: 12755
	public new Guid a;

	// Token: 0x040031D4 RID: 12756
	public ekt b;

	// Token: 0x040031D5 RID: 12757
	private List<Guid> c = new List<Guid>();

	// Token: 0x040031D6 RID: 12758
	private Point d;

	// Token: 0x040031D7 RID: 12759
	public a1q? e;

	// Token: 0x040031D8 RID: 12760
	public a1q? f;

	// Token: 0x040031D9 RID: 12761
	public string g;

	// Token: 0x040031DA RID: 12762
	public enp h;
}
