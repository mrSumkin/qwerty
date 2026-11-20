using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001685 RID: 5765
[eiz("CGA0")]
[Serializable]
public sealed class dhx : h3, ISerializable
{
	// Token: 0x06007DB8 RID: 32184 RVA: 0x00350CB4 File Offset: 0x0034EEB4
	private dhx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("CGA0:AE", ref this.d, A_0);
		this.e = (Point)A_0.GetValue("CGA0S", typeof(Point));
		this.f = (A_0.GetValue("CGA0:MD", typeof(a1q)) as a1q?);
		this.h = A_0.GetString("CGA0:M");
		this.g = (A_0.GetValue("CGA0:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
		this.j = (A_0.GetValue("CGA0:CB", typeof(enp)) as enp);
		this.k = (A_0.GetValue("CGA0:AP", typeof(ekt)) as ekt);
	}

	// Token: 0x06007DB9 RID: 32185 RVA: 0x00350DA0 File Offset: 0x0034EFA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("CGA0:AE", this.d, info);
		info.AddValue("CGA0:S", this.e);
		info.AddValue("CGA0:MD", this.f);
		info.AddValue("CGA0:M", this.h);
		info.AddValue("CGA0:GL", this.g);
		info.AddValue("CGA0:I", this.i);
		info.AddValue("CGA0:CB", this.j);
		info.AddValue("CGA0:AP", this.k);
	}

	// Token: 0x06007DBA RID: 32186 RVA: 0x00350E54 File Offset: 0x0034F054
	public dhx()
	{
		this.i = Guid.NewGuid();
	}

	// Token: 0x06007DBB RID: 32187 RVA: 0x00350E74 File Offset: 0x0034F074
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (A_2 == 0f)
		{
			this.e = A_1;
		}
		boj.c(A_0, A_1);
		Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_2 = null;
		string a_3 = "xphw_ConcussiveExplosion" + cuo.a.Next(3).ToString();
		int a_4 = 1;
		double maxValue = double.MaxValue;
		float? a_5 = dz6.b();
		boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, null, a_5, null);
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && c5x.h.b != null && !this.d.Contains(b0b.qe()))
					{
						this.a(c5x.h.b);
						this.d.Add(c5x.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007DBC RID: 32188 RVA: 0x00350FDC File Offset: 0x0034F1DC
	private void a(amc A_0)
	{
		if (base.c() != null)
		{
			if (!A_0.a8().IsPlayer && !A_0.aa().Passive && !A_0.aa().c(d8o.e))
			{
				awq.a(base.c(), A_0, true, true, null, true, true, false, false);
			}
			A_0.u();
			double a_ = 0.0;
			double num = 1.0;
			double ak = 0.0;
			double num2 = 0.0;
			double num3 = 1.0;
			if (this.k != null)
			{
				xo xo = this.k.a(base.c(), A_0);
				a_ = xo.a;
				num = xo.b;
				num2 = xo.c;
				ak = xo.d;
				num3 = xo.e;
			}
			bool flag = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			double num4 = num3 * (1.0 + num2);
			if (flag)
			{
				num4 *= 1.0 + num;
			}
			cwt cwt = new cwt();
			cwt.af = this.i;
			cwt.f.Add(euf.a(this.f.Value, num4));
			cwt.b = true;
			cwt.e = flag;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = ((this.h != null) ? this.h : "ошеломляющая граната");
			cwt.ad["IsGrenade"] = true;
			cwt.ad["IsExplosion"] = true;
			cwt.ae = this.g;
			cru cru = A_0.aa().Defense.a(cwt);
			if (this.j != null)
			{
				this.j.af(base.c(), A_0, cwt, cru);
			}
			if (cru != null && cru.a != null)
			{
				efk efk = base.c().aa();
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(dhx.a.a.b)), new Func<csk, int>(dhx.a.a.a)) == 0)
				{
					return;
				}
				if (A_0.aa().Passive)
				{
					return;
				}
				if (A_0.aa().StatusEffects.a(eok.c) && cuo.a.NextDouble() < dhx.a)
				{
					if (A_0.aa().d(CharacterImmunities.Stun) || A_0.aa().c(d8o.e))
					{
						etm a_2 = new etm(new ap9(A_0.aa()), "оглушению");
						bey.a(a_2, A_0.aa(), A_0);
						a7v.a(a_2);
						bmj.a(A_0.a8(), new ba0());
					}
					else if (euf.e(e0d.a(), A_0.aa()))
					{
						c6f a_3 = new c6f(new ap9(A_0.aa()), null, "оглушению");
						bey.a(a_3, A_0.aa(), A_0);
						a7v.a(a_3);
						bmj.a(A_0.a8(), new dym());
					}
					else
					{
						string str;
						els els = awq.a(A_0.aa(), dhx.b * d0u.b, out str);
						A_0.aa().StatusEffects.a(els, false, false, false);
						A_0.aa().bl();
						if (els is ab3 && !(A_0.aa() is e3q) && efk != null && efk is e3q)
						{
							cxc.a(eyy.by);
						}
						vr a_4 = new vr(new ap9(A_0.aa()), null, "{0}: " + str + ".", new Color?(adi.j), null);
						bey.a(a_4, A_0.aa(), A_0);
						a7v.a(a_4);
					}
				}
				if (!A_0.aa().d(CharacterImmunities.Daze))
				{
					A_0.aa().StatusEffects.a(new eok(dhx.c * d0u.b), false, false, false);
					vr a_5 = new vr(new ap9(A_0.aa()), new ap9(efk), "{0}: дезориентация.", new Color?(adi.j), null);
					bey.a(a_5, efk, A_0.aa(), A_0);
					a7v.a(a_5);
					return;
				}
				etm a_6 = new etm(new ap9(A_0.aa()), "дезориентации");
				bey.a(a_6, efk, A_0.aa(), A_0);
				a7v.a(a_6);
				bmj.a(A_0.a8(), new ba0());
			}
		}
	}

	// Token: 0x040031BA RID: 12730
	public new static readonly double a = 0.35;

	// Token: 0x040031BB RID: 12731
	public static readonly int b = 1;

	// Token: 0x040031BC RID: 12732
	public static readonly int c = 1;

	// Token: 0x040031BD RID: 12733
	private List<Guid> d = new List<Guid>();

	// Token: 0x040031BE RID: 12734
	private Point e;

	// Token: 0x040031BF RID: 12735
	public a1q? f;

	// Token: 0x040031C0 RID: 12736
	public WeaponSubtype? g;

	// Token: 0x040031C1 RID: 12737
	public string h;

	// Token: 0x040031C2 RID: 12738
	private Guid i;

	// Token: 0x040031C3 RID: 12739
	public enp j;

	// Token: 0x040031C4 RID: 12740
	public ekt k;

	// Token: 0x02001686 RID: 5766
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007DC0 RID: 32192 RVA: 0x0035150C File Offset: 0x0034F70C
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x00351518 File Offset: 0x0034F718
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040031C5 RID: 12741
		public static readonly dhx.a a = new dhx.a();

		// Token: 0x040031C6 RID: 12742
		public static Func<csk, bool> b;

		// Token: 0x040031C7 RID: 12743
		public static Func<csk, int> c;
	}
}
