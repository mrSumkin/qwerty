using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B2D RID: 6957
[eiz("B01")]
[Serializable]
public sealed class bk9 : els, ISerializable
{
	// Token: 0x06009671 RID: 38513 RVA: 0x003ADA1C File Offset: 0x003ABC1C
	private bk9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("B01:D");
		this.c = A_0.GetBoolean("B01:M");
	}

	// Token: 0x06009672 RID: 38514 RVA: 0x003ADA48 File Offset: 0x003ABC48
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("B01:D", this.b);
		info.AddValue("B01:M", this.c);
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06009673 RID: 38515 RVA: 0x003ADA74 File Offset: 0x003ABC74
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06009674 RID: 38516 RVA: 0x003ADA78 File Offset: 0x003ABC78
	public int Damage
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06009675 RID: 38517 RVA: 0x003ADA80 File Offset: 0x003ABC80
	public bk9(efk A_0, int A_1, int A_2, bool A_3 = false) : this(bk9.b(A_0), A_1, A_2, A_3)
	{
	}

	// Token: 0x06009676 RID: 38518 RVA: 0x003ADA98 File Offset: 0x003ABC98
	public bk9(ap9 A_0, int A_1, int A_2, bool A_3 = false) : base(bk9.a, "Горение", ci8.c)
	{
		this.b = A_2;
		this.c = A_3;
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.Pyrokinesis";
		base.VisualEffects.Add(new ud(this, "Burning"));
		base.Stacking = axm.b;
		base.AppliedAction = "BurningAppliedAction";
		base.ExpiredAction = "BurningExpiresAction";
		base.RemovedAction = "BurningExpiresAction";
		this.z = "HCDFHJ";
		this.w = "B04";
		this.x = "B05";
		base.Power = this.b;
		cwt cwt = this.a(A_0);
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
		base.StaticEffects.Add(new dpw("Stealth", -1000));
	}

	// Token: 0x06009677 RID: 38519 RVA: 0x003ADB84 File Offset: 0x003ABD84
	public void a(ap9 A_0, int A_1)
	{
		this.b = A_1;
		cwt cwt = this.a(A_0);
		base.DynamicEffects.Clear();
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x06009678 RID: 38520 RVA: 0x003ADBC0 File Offset: 0x003ABDC0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Burning", new object[]
		{
			this.b
		});
	}

	// Token: 0x06009679 RID: 38521 RVA: 0x003ADBE0 File Offset: 0x003ABDE0
	private static ap9 b(efk A_0)
	{
		if (A_0 != null)
		{
			return new ap9(A_0);
		}
		return null;
	}

	// Token: 0x0600967A RID: 38522 RVA: 0x003ADBF0 File Offset: 0x003ABDF0
	private cwt a(efk A_0)
	{
		return this.a(bk9.b(A_0));
	}

	// Token: 0x0600967B RID: 38523 RVA: 0x003ADC00 File Offset: 0x003ABE00
	private cwt a(ap9 A_0)
	{
		cwt cwt = new cwt();
		cwt.i = A_0;
		cwt.l = true;
		cwt.p = true;
		cwt.y = "{2} горит на ";
		cwt.f.Add(new csk(DamageType.Heat, this.b));
		cwt.b = true;
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.r = true;
		cwt.w = true;
		if (this.c)
		{
			cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
		}
		return cwt;
	}

	// Token: 0x040039E5 RID: 14821
	public new static readonly string a = "burning";

	// Token: 0x040039E6 RID: 14822
	private int b;

	// Token: 0x040039E7 RID: 14823
	private new bool c;
}
