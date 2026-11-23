using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AA4 RID: 6820
[eiz("CASE")]
[Serializable]
public sealed class bni : els, ISerializable
{
	// Token: 0x060093FA RID: 37882 RVA: 0x003A4900 File Offset: 0x003A2B00
	private bni(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CASE:PD");
	}

	// Token: 0x060093FB RID: 37883 RVA: 0x003A491C File Offset: 0x003A2B1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CASE:PD", this.a);
	}

	// Token: 0x060093FC RID: 37884 RVA: 0x003A493C File Offset: 0x003A2B3C
	public bni(int A_0, int A_1) : base("cerebralAcidization", "Разъедание кислотой мозга", ci8.c)
	{
		this.a = A_1;
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.121";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = A_1;
		cwt cwt = new cwt();
		cwt.i = new ap9("Cerebral acidization", null);
		cwt.l = true;
		cwt.p = true;
		cwt.e = false;
		cwt.r = true;
		cwt.w = true;
		cwt.f = new List<csk>
		{
			new csk(DamageType.Acid, A_1)
		};
		cwt.q = false;
		cwt.b = true;
		cwt.y = "{2} получает кислотный ожог мозга на ";
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x060093FD RID: 37885 RVA: 0x003A4A14 File Offset: 0x003A2C14
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CerebralAcidization", new object[]
		{
			this.a
		});
	}

	// Token: 0x040038DE RID: 14558
	private new int a;
}
