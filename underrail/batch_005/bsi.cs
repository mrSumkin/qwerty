using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001691 RID: 5777
[eiz("MGA")]
[Serializable]
public sealed class bsi : h3, ISerializable, b6a
{
	// Token: 0x06007DFB RID: 32251 RVA: 0x0035470C File Offset: 0x0035290C
	private bsi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("MGA:AE", ref this.a, A_0);
		this.b = (A_0.GetValue("MGA:FD", typeof(a1q)) as a1q?);
		this.c = A_0.GetString("MGA:M");
		this.d = A_0.GetBoolean("MGA:T");
		this.e = (Guid)A_0.GetValue("MGA:I", typeof(Guid));
		if (ell.a() >= 664)
		{
			this.f = (A_0.GetValue("MGA:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
			this.g = (A_0.GetValue("MGA:C", typeof(b1j?)) as b1j?);
			this.h = (A_0.GetValue("MGA:CB", typeof(enp)) as enp);
			this.i = (A_0.GetValue("MGA:AP", typeof(ekt)) as ekt);
		}
		if (ell.a() >= 702)
		{
			this.j = (A_0.GetValue("MGA:IC", typeof(float?)) as float?);
			this.k = (A_0.GetValue("MGA:ID", typeof(float?)) as float?);
			this.l = (A_0.GetValue("MGA:IT", typeof(int?)) as int?);
		}
	}

	// Token: 0x06007DFC RID: 32252 RVA: 0x003548BC File Offset: 0x00352ABC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("MGA:AE", this.a, info);
		info.AddValue("MGA:FD", this.b);
		info.AddValue("MGA:M", this.c);
		info.AddValue("MGA:T", this.d);
		info.AddValue("MGA:I", this.e);
		info.AddValue("MGA:GL", this.f);
		info.AddValue("MGA:C", this.g);
		info.AddValue("MGA:CB", this.h);
		info.AddValue("MGA:AP", this.i);
		info.AddValue("MGA:IC", this.j);
		info.AddValue("MGA:ID", this.k);
		info.AddValue("MGA:IT", this.l);
	}

	// Token: 0x06007DFD RID: 32253 RVA: 0x003549C0 File Offset: 0x00352BC0
	public string tx()
	{
		return this.c;
	}

	// Token: 0x06007DFE RID: 32254 RVA: 0x003549C8 File Offset: 0x00352BC8
	public void ty(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007DFF RID: 32255 RVA: 0x003549D4 File Offset: 0x00352BD4
	public bool tz()
	{
		return this.d;
	}

	// Token: 0x06007E00 RID: 32256 RVA: 0x003549DC File Offset: 0x00352BDC
	public void t0(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007E01 RID: 32257 RVA: 0x003549E8 File Offset: 0x00352BE8
	public bsi()
	{
		this.e = Guid.NewGuid();
	}

	// Token: 0x06007E02 RID: 32258 RVA: 0x00354A08 File Offset: 0x00352C08
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (this.b == null)
		{
			this.a();
		}
		Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
		HorizontalDirection? a_2 = null;
		string a_3 = "ScorchGround";
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
					if (c5x != null)
					{
						if (c5x.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x.h.b, A_2);
							this.a.Add(c5x.qe());
						}
						if (c5x.y.b != null)
						{
							c5x.y.b.a(null);
							this.a.Add(c5x.qe());
						}
					}
				}
				this.a(ak, A_2);
			}
		}
	}

	// Token: 0x06007E03 RID: 32259 RVA: 0x00354B98 File Offset: 0x00352D98
	private void a()
	{
		int a_ = c18.a(base.d());
		this.b = new a1q?(c18.e(a_));
	}

	// Token: 0x06007E04 RID: 32260 RVA: 0x00354BC4 File Offset: 0x00352DC4
	private void a(amc A_0, float A_1)
	{
		if (base.d() != null)
		{
			if (base.c() != null && !A_0.a8().IsPlayer)
			{
				bool flag;
				if (this.d)
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
					awq.a(base.c(), A_0, !this.d, true, null, true, !this.d, false, false);
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
			else if (!this.d && base.c() != null)
			{
				a_ = c18.a(base.c().aa());
			}
			bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
			double num5 = (1.0 - num) * (1.0 + num3) * num4;
			if (flag2)
			{
				num5 *= 1.0 + num2;
			}
			bool flag3 = !this.d && this.f.GetValueOrDefault() != WeaponSubtype.RocketLauncher_66;
			cwt cwt = new cwt();
			cwt.af = this.e;
			cwt.f.Add(euf.a(this.b.Value, num5));
			cwt.b = true;
			cwt.e = flag2;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = ((this.c != null) ? this.c : "коктейль Молотова");
			cwt.ad["IsTrap"] = this.d;
			cwt.ad["IsGrenade"] = flag3;
			cwt.ad["IsExplosion"] = true;
			cru cru = A_0.aa().Defense.a(cwt);
			if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt, cru);
			}
			if (cru.a != null)
			{
				int num6 = Enumerable.Sum<csk>(Enumerable.Where<csk>(cru.a, new Func<csk, bool>(bsi.a.a.b)), new Func<csk, int>(bsi.a.a.a));
				if (num6 >= 3)
				{
					float? num7 = this.j;
					double num8 = (num7 != null) ? ((double)num7.GetValueOrDefault()) : c18.v;
					num7 = this.k;
					double num9 = (num7 != null) ? ((double)num7.GetValueOrDefault()) : c18.w;
					int valueOrDefault = this.l.GetValueOrDefault(3);
					if (cuo.a.NextDouble() < num8)
					{
						if (A_0.aa().d(CharacterImmunities.Burning))
						{
							if (base.c() != null)
							{
								etm a_2 = new etm(new ap9(A_0.aa()), "горению");
								bey.a(a_2, base.c().aa(), A_0.aa(), A_0);
								a7v.a(a_2);
							}
							bmj.a(A_0.a8(), new ba0());
						}
						else
						{
							int a_3 = (int)((double)num6 * num9 / (double)valueOrDefault);
							bk9 bk = Enumerable.FirstOrDefault<bk9>(A_0.aa().StatusEffects.Get<bk9>());
							if (bk != null)
							{
								dd5.a(bk, (base.c() != null) ? base.c().aa() : null, a_3, valueOrDefault * d0u.b);
							}
							else
							{
								bk = new bk9((base.c() != null) ? base.c().aa() : null, valueOrDefault * d0u.b, a_3, false);
								A_0.aa().StatusEffects.a(bk, false, false, false);
								dd5.a(A_0.aa());
							}
							if (base.c() != null && base.c().aa() is e3q && !(A_0.aa() is e3q))
							{
								cxc.a(eyy.b1);
							}
						}
					}
				}
			}
			awq.a(A_0, true);
		}
	}

	// Token: 0x06007E05 RID: 32261 RVA: 0x00355114 File Offset: 0x00353314
	private void a(ak1 A_0, float A_1)
	{
		if (aw1.b(A_0))
		{
			int num;
			if (this.g != null)
			{
				num = Convert.ToInt32(this.g.Value.a());
			}
			else
			{
				int num2 = c18.a(base.d());
				int num3 = d05.a(1, num2 + 1, 4);
				int num4 = d05.a(1, num2, 4);
				int num5 = d05.a(1, num2 - 1, 4);
				double num6 = Math.Max(0.1, 0.66 - (double)A_1);
				double num7 = Math.Max(0.1, (double)(1f - A_1));
				double num8 = cuo.a.NextDouble();
				if (num8 < num6)
				{
					num = num3;
				}
				else if (num8 < num7)
				{
					num = num4;
				}
				else
				{
					num = num5;
				}
			}
			if (num > 0)
			{
				dd5.a(base.c(), A_0, (double)num, int.MaxValue, false);
			}
		}
	}

	// Token: 0x040031F4 RID: 12788
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031F5 RID: 12789
	public a1q? b;

	// Token: 0x040031F6 RID: 12790
	private string c;

	// Token: 0x040031F7 RID: 12791
	private bool d;

	// Token: 0x040031F8 RID: 12792
	private Guid e;

	// Token: 0x040031F9 RID: 12793
	public WeaponSubtype? f;

	// Token: 0x040031FA RID: 12794
	public b1j? g;

	// Token: 0x040031FB RID: 12795
	public enp h;

	// Token: 0x040031FC RID: 12796
	public ekt i;

	// Token: 0x040031FD RID: 12797
	public float? j;

	// Token: 0x040031FE RID: 12798
	public float? k;

	// Token: 0x040031FF RID: 12799
	public int? l;

	// Token: 0x02001692 RID: 5778
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007E08 RID: 32264 RVA: 0x0035521C File Offset: 0x0035341C
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Heat;
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x00355228 File Offset: 0x00353428
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04003200 RID: 12800
		public static readonly bsi.a a = new bsi.a();

		// Token: 0x04003201 RID: 12801
		public static Func<csk, bool> b;

		// Token: 0x04003202 RID: 12802
		public static Func<csk, int> c;
	}
}
