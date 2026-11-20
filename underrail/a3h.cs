using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001687 RID: 5767
[eiz("THBA")]
[Serializable]
public sealed class a3h : h3, ISerializable, b6a
{
	// Token: 0x06007DC2 RID: 32194 RVA: 0x00351524 File Offset: 0x0034F724
	private a3h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("THBA:AE", ref this.a, A_0);
		this.b = (A_0.GetValue("THBA:FD", typeof(a1q)) as a1q?);
		this.c = (A_0.GetValue("THBA:MD", typeof(a1q)) as a1q?);
		this.d = A_0.GetString("THBA:M");
		this.e = A_0.GetBoolean("THBA:T");
		this.g = (Guid)A_0.GetValue("THBA:I", typeof(Guid));
		this.f = (A_0.GetValue("THBA:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
		this.h = (A_0.GetValue("THBA:CB", typeof(enp)) as enp);
		this.i = (A_0.GetValue("THBA:AP", typeof(ekt)) as ekt);
	}

	// Token: 0x06007DC3 RID: 32195 RVA: 0x00351648 File Offset: 0x0034F848
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("THBA:AE", this.a, info);
		info.AddValue("THBA:FD", this.b);
		info.AddValue("THBA:MD", this.c);
		info.AddValue("THBA:M", this.d);
		info.AddValue("THBA:T", this.e);
		info.AddValue("THBA:I", this.g);
		info.AddValue("THBA:GL", this.f);
		info.AddValue("THBA:CB", this.h);
		info.AddValue("THBA:AP", this.i);
	}

	// Token: 0x06007DC4 RID: 32196 RVA: 0x0035170C File Offset: 0x0034F90C
	public string tx()
	{
		return this.d;
	}

	// Token: 0x06007DC5 RID: 32197 RVA: 0x00351714 File Offset: 0x0034F914
	public void ty(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007DC6 RID: 32198 RVA: 0x00351720 File Offset: 0x0034F920
	public bool tz()
	{
		return this.e;
	}

	// Token: 0x06007DC7 RID: 32199 RVA: 0x00351728 File Offset: 0x0034F928
	public void t0(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007DC8 RID: 32200 RVA: 0x00351734 File Offset: 0x0034F934
	public a3h()
	{
		this.g = Guid.NewGuid();
	}

	// Token: 0x06007DC9 RID: 32201 RVA: 0x00351754 File Offset: 0x0034F954
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
				Vector3 a_ = A_1.a() + new Vector3(0.4f, 0.4f, 0f);
				HorizontalDirection? a_2 = null;
				string a_3 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? num = new float?(0.66f);
				boj.a(A_0, a_, a_2, a_3, a_4, maxValue, null, num, null, null);
			}
		}
		int y = (int)a63.b(base.a(A_1));
		if (A_2 == 0f)
		{
			Vector3 a_5 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_6 = null;
			string a_7 = "ThermobaricCenter";
			int a_8 = 1;
			double maxValue2 = double.MaxValue;
			float? num = dz6.b();
			c5x c5x = boj.a(A_0, a_5, a_6, a_7, a_8, maxValue2, null, null, num, null);
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b = new Point(c5x.o.b.b.X, y);
			}
		}
		else
		{
			Vector3 a_9 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_10 = null;
			string a_11 = "ThermobaricDir";
			int a_12 = 1;
			double maxValue3 = double.MaxValue;
			float? num = dz6.b();
			c5x c5x2 = boj.a(A_0, a_9, a_10, a_11, a_12, maxValue3, null, null, num, null);
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b = new Point(c5x2.o.b.b.X, y);
			}
			Vector3 a_13 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_14 = null;
			string a_15 = "ThermobaricDirSmoke";
			int a_16 = 1;
			double maxValue4 = double.MaxValue;
			num = dz6.b();
			c5x c5x3 = boj.a(A_0, a_13, a_14, a_15, a_16, maxValue4, null, null, num, null);
			if (c5x3 != null && c5x3.o.b != null)
			{
				c5x3.o.b.b = new Point(c5x3.o.b.b.X, y);
			}
		}
		if (base.d() != null)
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x4 = b0b as c5x;
					if (c5x4 != null)
					{
						if (c5x4.h.b != null && !this.a.Contains(b0b.qe()))
						{
							this.a(c5x4.h.b, A_2);
							this.a.Add(c5x4.qe());
						}
						if (c5x4.y.b != null)
						{
							c5x4.y.b.a(null);
							this.a.Add(c5x4.qe());
						}
					}
				}
			}
		}
	}

	// Token: 0x06007DCA RID: 32202 RVA: 0x00351B28 File Offset: 0x0034FD28
	private void a()
	{
		int a_ = c18.a(base.d());
		this.b = new a1q?(c18.r(a_));
		this.c = new a1q?(c18.q(a_));
	}

	// Token: 0x06007DCB RID: 32203 RVA: 0x00351B64 File Offset: 0x0034FD64
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
				num = Math.Pow(c18.a4, (double)(A_1 - 1f));
			}
			else
			{
				num = 1.0;
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
			double num5 = num * (1.0 + num3) * num4;
			if (flag2)
			{
				num5 *= 1.0 + num2;
			}
			cwt cwt = new cwt();
			cwt.af = this.g;
			cwt.f.Add(euf.a(this.b.Value, num5));
			cwt.b = true;
			cwt.e = flag2;
			cwt.x = AmmoType.Thermobaric;
			cwt.q = true;
			cwt.ak = ak;
			if (base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			cwt.h = ImpactSpeed.High;
			cwt.k = ((this.d != null) ? this.d : "термобарическая граната");
			cwt.ad["IsTrap"] = this.e;
			cwt.ad["IsGrenade"] = !this.e;
			cwt.ad["IsExplosion"] = true;
			cwt.ae = this.f;
			cru a_2 = A_0.aa().Defense.a(cwt);
			if (this.h != null)
			{
				this.h.af(base.c(), A_0, cwt, a_2);
			}
			cwt cwt2 = new cwt();
			cwt2.af = this.g;
			cwt2.f.Add(euf.a(this.c.Value, num5));
			cwt2.b = true;
			cwt2.e = flag2;
			cwt2.x = AmmoType.Thermobaric;
			cwt2.q = true;
			cwt2.ak = ak;
			if (base.d().b8() != null)
			{
				cwt2.i = new ap9(base.d().b8());
			}
			cwt2.h = ImpactSpeed.High;
			cwt2.k = ((this.d != null) ? this.d : "термобарическая граната");
			cwt2.ad["IsTrap"] = this.e;
			cwt2.ad["IsGrenade"] = !this.e;
			cwt2.ad["IsExplosion"] = true;
			cwt2.ae = this.f;
			A_0.aa().Defense.a(cwt2);
		}
	}

	// Token: 0x040031C8 RID: 12744
	private new List<Guid> a = new List<Guid>();

	// Token: 0x040031C9 RID: 12745
	public a1q? b;

	// Token: 0x040031CA RID: 12746
	public a1q? c;

	// Token: 0x040031CB RID: 12747
	private string d;

	// Token: 0x040031CC RID: 12748
	private bool e;

	// Token: 0x040031CD RID: 12749
	public WeaponSubtype? f;

	// Token: 0x040031CE RID: 12750
	private Guid g;

	// Token: 0x040031CF RID: 12751
	public enp h;

	// Token: 0x040031D0 RID: 12752
	public ekt i;
}
