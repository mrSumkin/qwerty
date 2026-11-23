using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001693 RID: 5779
[eiz("E04")]
[Serializable]
public sealed class dug : h3, ISerializable, b6a
{
	// Token: 0x06007E0A RID: 32266 RVA: 0x00355234 File Offset: 0x00353434
	private dug(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("E04:A", ref this.a, A_0);
		this.b = (A_0.GetValue("E04:D", typeof(a1q)) as a1q?);
		this.c = A_0.GetString("E04:M");
		this.d = A_0.GetBoolean("E04:T");
		this.e = (Guid)A_0.GetValue("E04:I", typeof(Guid));
	}

	// Token: 0x06007E0B RID: 32267 RVA: 0x003552CC File Offset: 0x003534CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("E04:A", this.a, info);
		info.AddValue("E04:D", this.b);
		info.AddValue("E04:M", this.c);
		info.AddValue("E04:T", this.d);
		info.AddValue("E04:I", this.e);
	}

	// Token: 0x06007E0C RID: 32268 RVA: 0x00355340 File Offset: 0x00353540
	public string tx()
	{
		return this.c;
	}

	// Token: 0x06007E0D RID: 32269 RVA: 0x00355348 File Offset: 0x00353548
	public void ty(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007E0E RID: 32270 RVA: 0x00355354 File Offset: 0x00353554
	public bool tz()
	{
		return this.d;
	}

	// Token: 0x06007E0F RID: 32271 RVA: 0x0035535C File Offset: 0x0035355C
	public void t0(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007E10 RID: 32272 RVA: 0x00355368 File Offset: 0x00353568
	public a1q? b()
	{
		return this.b;
	}

	// Token: 0x06007E11 RID: 32273 RVA: 0x00355370 File Offset: 0x00353570
	public void a(a1q? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06007E12 RID: 32274 RVA: 0x0035537C File Offset: 0x0035357C
	public dug()
	{
		this.e = Guid.NewGuid();
	}

	// Token: 0x06007E13 RID: 32275 RVA: 0x003553A0 File Offset: 0x003535A0
	public override void cq(aud A_0, Point A_1, float A_2)
	{
		if (this.b == null)
		{
			this.a();
		}
		else
		{
			Vector3 a_ = new Vector3((float)A_1.X, (float)A_1.Y, 0f);
			HorizontalDirection? a_2 = null;
			string a_3 = "EmpCreep";
			int maxValue = int.MaxValue;
			double a_4 = 300.0;
			float? a_5 = dz6.b();
			boj.a(A_0, a_, a_2, a_3, maxValue, a_4, null, null, a_5, null);
		}
		if (base.d() != null || (base.d() == null && base.c() == null))
		{
			ak1 ak = A_0.b(A_1.X, A_1.Y);
			if (ak != null)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
				{
					c5x c5x = b0b as c5x;
					if (c5x != null && !this.a.Contains(b0b.qe()))
					{
						if (c5x.h.b != null)
						{
							if (c5x.h.b.aa().c(d8o.e))
							{
								this.b(c5x.h.b, A_2);
							}
							else if (!c5x.h.b.aa().Passive)
							{
								this.a(c5x.h.b, A_2);
							}
							this.a.Add(c5x.qe());
						}
						bbw aspect = c5x.GetAspect<bbw>();
						if (aspect != null)
						{
							this.a(aspect);
							this.a.Add(c5x.qe());
						}
					}
				}
			}
		}
	}

	// Token: 0x06007E14 RID: 32276 RVA: 0x00355588 File Offset: 0x00353788
	private void a()
	{
		int a_ = c18.a(base.d());
		this.b = new a1q?(c18.n(a_));
	}

	// Token: 0x06007E15 RID: 32277 RVA: 0x003555B4 File Offset: 0x003537B4
	private void b(amc A_0, float A_1)
	{
		if (base.c() != null)
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
		double a_ = 0.0;
		if (!this.d && base.c() != null)
		{
			a_ = c18.a(base.c().aa());
		}
		bool flag2 = !A_0.aa().ImmuneToCriticalHits && euf.a(a_);
		cwt cwt = new cwt();
		cwt.af = this.e;
		cwt.f.Add(euf.a(this.b.Value, (double)(flag2 ? 2 : 1)));
		cwt.b = true;
		cwt.e = flag2;
		cwt.q = false;
		if (A_0.aa().Defense.af()[DamageType.Electricity].c() < 1.0)
		{
			cwt.p = true;
		}
		cwt.l = true;
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.k = ((this.c != null) ? this.c : "ЭМИ-граната");
		cwt.ad["IsEnergyWeapon"] = true;
		cwt.ad["IsEMP"] = true;
		cwt.ad["IsTrap"] = this.d;
		cwt.ad["IsGrenade"] = !this.d;
		if (base.d().b8() != null)
		{
			cwt.i = new ap9(base.d().b8());
		}
		A_0.aa().Defense.a(cwt);
		if (A_0.aa().d(CharacterImmunities.ShortCircuiting))
		{
			etm a_2 = new etm(new ap9(A_0.aa()), "короткому замыканию");
			if (base.d().b8() != null)
			{
				bey.a(a_2, base.d().b8(), A_0.aa(), A_0);
				a7v.a(a_2);
			}
			bmj.a(A_0.a8(), new ba0());
		}
		else
		{
			clt a_3 = new clt(c18.m(c18.a(base.d())) * d0u.b);
			A_0.aa().StatusEffects.a(a_3, false, false, false);
			if (base.d().b8() is e3q && !(A_0.aa() is e3q))
			{
				cxc.a(eyy.bz);
			}
		}
		this.a(A_0);
		this.b(A_0);
	}

	// Token: 0x06007E16 RID: 32278 RVA: 0x003558D8 File Offset: 0x00353AD8
	private void a(amc A_0, float A_1)
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
				awq.a(base.c(), A_0, !this.d, !this.d, null, true, !this.d, false, false);
			}
		}
		A_0.u();
		if (A_0.aa().Vehicle != null)
		{
			this.a(A_0);
		}
		this.b(A_0);
	}

	// Token: 0x06007E17 RID: 32279 RVA: 0x003559A0 File Offset: 0x00353BA0
	private void a(bbw A_0)
	{
		A_0.td(null, double.MaxValue, true);
	}

	// Token: 0x06007E18 RID: 32280 RVA: 0x003559B8 File Offset: 0x00353BB8
	private void b(amc A_0)
	{
		double num = 0.0;
		List<coh> list = new List<coh>();
		list.AddRange(A_0.aa().Gear.i());
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().ae() >= GameDifficulty.Hard)
		{
			list.AddRange(A_0.aa().Bag.z2());
		}
		foreach (coh coh in list)
		{
			if (coh.Battery > 0.0)
			{
				num += coh.Battery;
				coh.Battery = 0.0;
			}
		}
		if (A_0.aa().Vehicle != null)
		{
			A_0.aa().Vehicle.h(double.MaxValue);
		}
		if (num > 0.0)
		{
			cwt cwt = new cwt();
			cwt.af = this.e;
			cwt.f.Add(new csk(DamageType.Electricity, (int)(num * c18.a5)));
			cwt.b = true;
			cwt.q = false;
			cwt.h = ImpactSpeed.VeryHigh;
			cwt.k = ((this.c != null) ? this.c : "ЭМИ-граната");
			cwt.v = "снаряжение закоротило";
			cwt.ad["IsEnergyWeapon"] = true;
			cwt.ad["IsEMP"] = true;
			cwt.ad["IsTrap"] = this.d;
			cwt.ad["IsGrenade"] = !this.d;
			if (base.d() != null && base.d().b8() != null)
			{
				cwt.i = new ap9(base.d().b8());
			}
			else
			{
				cwt.i = new ap9("Устройство", null);
			}
			A_0.aa().Defense.a(cwt);
			this.a(A_0);
			A_0.u();
		}
	}

	// Token: 0x06007E19 RID: 32281 RVA: 0x00355C14 File Offset: 0x00353E14
	private void a(amc A_0)
	{
		c5x a_ = A_0.a8();
		string a_2 = "Electricity";
		int maxValue = int.MaxValue;
		double a_3 = (double)dz6.b(350);
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		boj.a(a_, a_2, maxValue, a_3, a_4, a_5, null, null, null, a_6, false);
		A_0.a8().c().a(Guid.NewGuid().ToString(), "Electroshock", 1f, c9z.a, false, false);
		eym.a(A_0.a8(), (double)aju.bf);
	}

	// Token: 0x04003203 RID: 12803
	private new List<Guid> a = new List<Guid>();

	// Token: 0x04003204 RID: 12804
	private a1q? b;

	// Token: 0x04003205 RID: 12805
	private string c;

	// Token: 0x04003206 RID: 12806
	private bool d;

	// Token: 0x04003207 RID: 12807
	private Guid e;
}
