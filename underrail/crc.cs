using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001695 RID: 5781
[eiz("FRGA")]
[Serializable]
public sealed class crc : h3, ISerializable, b6a
{
	// Token: 0x06007E27 RID: 32295 RVA: 0x00356BA0 File Offset: 0x00354DA0
	private crc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("FRGA:AE", ref this.b, A_0);
		this.c = (A_0.GetValue("FRGA:FD", typeof(a1q)) as a1q?);
		this.d = (A_0.GetValue("FRGA:SD", typeof(a1q)) as a1q?);
		this.e = A_0.GetString("FRGA:M");
		this.f = A_0.GetBoolean("FRGA:T");
		this.g = (Guid)A_0.GetValue("FRGA:I", typeof(Guid));
		if (ell.a() >= 664)
		{
			this.h = (A_0.GetValue("FRGA:GL", typeof(WeaponSubtype?)) as WeaponSubtype?);
			this.i = (A_0.GetValue("FRGA:CB", typeof(enp)) as enp);
			this.j = (A_0.GetValue("FRGA:AP", typeof(ekt)) as ekt);
		}
	}

	// Token: 0x06007E28 RID: 32296 RVA: 0x00356CD4 File Offset: 0x00354ED4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("FRGA:AE", this.b, info);
		info.AddValue("FRGA:FD", this.c);
		info.AddValue("FRGA:SD", this.d);
		info.AddValue("FRGA:M", this.e);
		info.AddValue("FRGA:T", this.f);
		info.AddValue("FRGA:I", this.g);
		info.AddValue("FRGA:GL", this.h);
		info.AddValue("FRGA:CB", this.i);
		info.AddValue("FRGA:AP", this.j);
	}

	// Token: 0x06007E29 RID: 32297 RVA: 0x00356D98 File Offset: 0x00354F98
	public string tx()
	{
		return this.e;
	}

	// Token: 0x06007E2A RID: 32298 RVA: 0x00356DA0 File Offset: 0x00354FA0
	public void ty(string A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06007E2B RID: 32299 RVA: 0x00356DAC File Offset: 0x00354FAC
	public bool tz()
	{
		return this.f;
	}

	// Token: 0x06007E2C RID: 32300 RVA: 0x00356DB4 File Offset: 0x00354FB4
	public void t0(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06007E2D RID: 32301 RVA: 0x00356DC0 File Offset: 0x00354FC0
	public crc()
	{
		this.g = Guid.NewGuid();
	}

	// Token: 0x06007E2E RID: 32302 RVA: 0x00356DE0 File Offset: 0x00354FE0
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (this.c == null)
		{
			this.a();
		}
		if (A_2 == 0f)
		{
			boj.c(A_0, A_1);
		}
		int value = (int)base.a(A_1);
		float value2 = 0.75f;
		if (A_2 == 0f)
		{
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "ExplosionFrag_C_Flame";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? num = dz6.b();
			float? num2 = new float?(value2);
			int? num3 = null;
			int? a_5 = num3;
			float? a_6 = num2;
			float? a_7 = num;
			num3 = null;
			boj.a(A_0, a_, a_2, a_3, a_4, maxValue, a_5, a_6, a_7, num3);
		}
		else if (A_2 == 2f)
		{
			Vector3 a_8 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_9 = null;
			string a_10 = "ExplosionFrag_O_Flame_Weak";
			int a_11 = 1;
			double maxValue2 = double.MaxValue;
			float? num2 = dz6.b();
			int? num3 = new int?(value);
			float? num = new float?(value2);
			boj.a(A_0, a_8, a_9, a_10, a_11, maxValue2, null, num, num2, num3);
		}
		else if (A_2 == 1f)
		{
			Vector3 a_12 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_13 = null;
			string a_14 = "ExplosionFrag_O_Flame";
			int a_15 = 1;
			double maxValue3 = double.MaxValue;
			float? num = dz6.b();
			int? num3 = new int?(value);
			float? num2 = new float?(value2);
			boj.a(A_0, a_12, a_13, a_14, a_15, maxValue3, null, num2, num, num3);
		}
		float value3 = Math.Max(0.6f, 1f - A_2 * 0.1f);
		if (A_2 == 0f)
		{
			Vector3 a_16 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_17 = null;
			string a_18 = "ExplosionFrag_C_Smoke";
			int a_19 = 1;
			double maxValue4 = double.MaxValue;
			float? num2 = dz6.b();
			float? num = new float?(value3);
			int? num3 = null;
			int? a_20 = num3;
			float? a_21 = num;
			float? a_22 = num2;
			num3 = null;
			boj.a(A_0, a_16, a_17, a_18, a_19, maxValue4, a_20, a_21, a_22, num3);
		}
		else
		{
			Vector3 a_23 = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_24 = null;
			string a_25 = "ExplosionFrag_O_Smoke";
			int a_26 = 1;
			double maxValue5 = double.MaxValue;
			float? num = dz6.b();
			float? num2 = new float?(value3);
			int? num3 = new int?(value);
			boj.a(A_0, a_23, a_24, a_25, a_26, maxValue5, null, num2, num, num3);
		}
		ak1 ak = A_0.b(A_1.X, A_1.Y);
		if (ak != null)
		{
			if (A_2 != 0f && base.h() != null && base.h().ao() != null)
			{
				Vector3 value4 = base.h().ao().Location.a();
				int num4 = 0;
				while ((float)num4 < A_2)
				{
					qy qy = new qy();
					int a_27 = dz6.b(Convert.ToInt32((double)(15f + Math.Max(0f, 3f - A_2) * 75f) * 0.75 + 0.5 * cuo.a.NextDouble()));
					qy.ad().Add(new bm3(a_27));
					Vector3 a_28 = value4 + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
					Vector3 a_29 = ak.Location.a() + new Vector3(0f, 0f, 0.2f) + new Vector3(0.75f, 0.75f, 0.3f) * Convert.ToSingle(cuo.a.NextDouble());
					a6c item = new a6c(a_28, a_29, ak.Area, "ExplosionFrag_Shard", null);
					qy.ad().Add(item);
					ak.Zone.ActionManager.g9(qy, atp.a);
					num4++;
				}
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
			{
				c5x c5x = b0b as c5x;
				if (c5x != null)
				{
					if (c5x.h.b != null && !this.b.Contains(b0b.qe()))
					{
						this.a(c5x.h.b, A_2);
						this.b.Add(c5x.qe());
					}
					if (c5x.y.b != null)
					{
						c5x.y.b.a(null);
						this.b.Add(c5x.qe());
					}
				}
			}
		}
	}

	// Token: 0x06007E2F RID: 32303 RVA: 0x003572D0 File Offset: 0x003554D0
	private void a()
	{
		int a_ = c18.a(base.d());
		this.c = new a1q?(c18.s(a_));
		this.d = new a1q?(c18.t(a_));
	}

	// Token: 0x06007E30 RID: 32304 RVA: 0x0035730C File Offset: 0x0035550C
	private void a(amc A_0, float A_1)
	{
		if (base.c() != null && !A_0.a8().IsPlayer)
		{
			bool flag;
			if (this.f)
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
				awq.a(base.c(), A_0, !this.f, true, null, true, !this.f, false, false);
			}
		}
		A_0.u();
		double num;
		if (A_1 > 1f)
		{
			num = Math.Min(c18.az, (double)(A_1 - 1f) * c18.a1);
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
		if (this.j != null)
		{
			xo xo = this.j.a(base.c(), A_0);
			a_ = xo.a;
			num2 = xo.b;
			num3 = xo.c;
			ak = xo.d;
			num4 = xo.e;
		}
		else if (!this.f && base.c() != null)
		{
			a_ = c18.a(base.c().aa());
		}
		bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
		double num5 = 1.0;
		if (flag2)
		{
			num5 += num2;
		}
		cwt cwt = new cwt();
		cwt.af = this.g;
		cwt.f.Add(euf.a(this.c.Value, (1.0 - num) * (1.0 + num3) * num5 * num4));
		cwt.b = true;
		cwt.e = flag2;
		cwt.q = true;
		cwt.ak = ak;
		if (base.d().b8() != null)
		{
			cwt.i = new ap9(base.d().b8());
		}
		cwt.h = ImpactSpeed.High;
		cwt.k = ((this.e != null) ? this.e : "осколочная граната");
		cwt.ad["IsTrap"] = this.f;
		cwt.ad["IsGrenade"] = !this.f;
		cwt.ad["IsExplosion"] = true;
		cwt.ae = this.h;
		cru a_2 = A_0.aa().Defense.a(cwt);
		bps a_3 = null;
		bvd bvd = this.i as bvd;
		if (bvd != null)
		{
			a_3 = new bps();
			bvd.mm(base.c(), A_0, cwt, a_2, a_3);
		}
		else if (this.i != null)
		{
			this.i.af(base.c(), A_0, cwt, a_2);
		}
		int num6 = Convert.ToInt32(A_1);
		int num7 = crc.a.Next(Math.Max(c18.ar, c18.@as - (num6 + 1)), Math.Max(c18.ar + 1, c18.@as - Math.Max(0, num6 - 1)));
		if (num7 > 0)
		{
			for (int i = 0; i < num7; i++)
			{
				bool flag3 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
				double num8 = 1.0;
				if (flag3)
				{
					num8 += num2;
				}
				cwt cwt2 = new cwt();
				cwt2.af = this.g;
				cwt2.f.Add(euf.a(this.d.Value, (1.0 + num3) * num8 * num4));
				cwt2.b = true;
				cwt2.e = flag3;
				cwt2.q = true;
				cwt2.ak = ak;
				if (base.d().b8() != null)
				{
					cwt2.i = new ap9(base.d().b8());
				}
				cwt2.h = ImpactSpeed.Medium;
				cwt2.k = ((this.e != null) ? this.e : "осколочная граната");
				cwt2.v = "шрапнель";
				cwt2.ad["IsTrap"] = this.f;
				cwt2.ad["IsGrenade"] = !this.f;
				cwt2.ae = this.h;
				cru a_4 = A_0.aa().Defense.a(cwt2);
				if (bvd != null)
				{
					bvd.mm(base.c(), A_0, cwt2, a_4, a_3);
				}
				else if (this.i != null)
				{
					this.i.af(base.c(), A_0, cwt2, a_4);
				}
			}
		}
	}

	// Token: 0x04003212 RID: 12818
	private new static Random a = new Random();

	// Token: 0x04003213 RID: 12819
	private List<Guid> b = new List<Guid>();

	// Token: 0x04003214 RID: 12820
	public a1q? c;

	// Token: 0x04003215 RID: 12821
	public a1q? d;

	// Token: 0x04003216 RID: 12822
	private string e;

	// Token: 0x04003217 RID: 12823
	private bool f;

	// Token: 0x04003218 RID: 12824
	private Guid g;

	// Token: 0x04003219 RID: 12825
	public WeaponSubtype? h;

	// Token: 0x0400321A RID: 12826
	public enp i;

	// Token: 0x0400321B RID: 12827
	public ekt j;

	// Token: 0x02001696 RID: 5782
	[eiz("FRGAa")]
	[Serializable]
	private new sealed class a : aig, ISerializable
	{
		// Token: 0x06007E32 RID: 32306 RVA: 0x0035784C File Offset: 0x00355A4C
		private a(SerializationInfo A_0, StreamingContext A_1)
		{
			this.a = A_0.GetSingle("FRGAa:D");
			this.b = A_0.GetInt32("FRGAa:Y");
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x00357878 File Offset: 0x00355A78
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			info.AddValue("FRGAa:D", this.a);
			info.AddValue("FRGAa:Y", this.b);
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0035789C File Offset: 0x00355A9C
		public a(int A_0)
		{
			this.b = A_0;
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x003578B0 File Offset: 0x00355AB0
		public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
		{
			if ((this.a += A_3) >= 0.5f)
			{
				this.a -= 0.5f;
				if (A_0 != null && A_0.Area != null)
				{
					aud a_ = A_0.Area;
					HorizontalDirection? a_2 = null;
					string a_3 = "ExplosionFrag_Shard_Smoke";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					int? a_5 = new int?(this.b);
					float? a_6 = dz6.b();
					c5x c5x = boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_6, a_5);
					if (c5x != null)
					{
						c5x.VisualPriority = 200;
					}
				}
			}
			return false;
		}

		// Token: 0x0400321C RID: 12828
		private float a;

		// Token: 0x0400321D RID: 12829
		private int b;
	}
}
