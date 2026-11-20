using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B14 RID: 6932
[eiz("CPSE")]
[Serializable]
public sealed class ddr : els, ISerializable, dl2
{
	// Token: 0x06009607 RID: 38407 RVA: 0x003AC484 File Offset: 0x003AA684
	private ddr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("CPSE:P", typeof(vf)) as vf);
	}

	// Token: 0x06009608 RID: 38408 RVA: 0x003AC4B0 File Offset: 0x003AA6B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CPSE:P", this.b);
	}

	// Token: 0x06009609 RID: 38409 RVA: 0x003AC4CC File Offset: 0x003AA6CC
	public override bool oa()
	{
		return false;
	}

	// Token: 0x0600960A RID: 38410 RVA: 0x003AC4D0 File Offset: 0x003AA6D0
	public ddr(efk A_0, int A_1, int A_2) : base(ddr.a, "Яд (краулер)", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "Status.Poison";
		base.Stacking = axm.b;
		base.Power = A_2;
		base.TickPeriod = d0u.b;
		base.ExpiredAction = "CrawlerPoisonExpiresAction";
		cwt cwt = new cwt();
		cwt.i = new ap9("Poison", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Bio, A_2));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		cwt.ag = true;
		this.b = new vf(cwt, cwt, null);
		base.DynamicEffects.Add(this.b);
	}

	// Token: 0x0600960B RID: 38411 RVA: 0x003AC5A8 File Offset: 0x003AA7A8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CrawlerPoison", new object[]
		{
			base.Power,
			l4.a(ezx.f, false)
		});
	}

	// Token: 0x040039BA RID: 14778
	public new static string a = "poison:CrawlerPoison";

	// Token: 0x040039BB RID: 14779
	private vf b;
}
