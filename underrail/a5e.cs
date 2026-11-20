using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B2B RID: 6955
[eiz("BW")]
[Serializable]
public sealed class a5e : els, ISerializable
{
	// Token: 0x0600966A RID: 38506 RVA: 0x003AD878 File Offset: 0x003ABA78
	private a5e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("BW:PD");
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x003AD894 File Offset: 0x003ABA94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BW:PD", this.a);
	}

	// Token: 0x0600966C RID: 38508 RVA: 0x003AD8B4 File Offset: 0x003ABAB4
	public a5e(string A_0, int A_1, int A_2, string A_3 = "bleedingWound", cd1 A_4 = null) : base(A_3, "Кровоточащая рана", ci8.c)
	{
		this.a = A_2;
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.8";
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		cwt cwt = new cwt();
		cwt.i = new ap9("Bleeding wound", A_0);
		cwt.l = true;
		cwt.p = true;
		cwt.e = false;
		cwt.r = true;
		cwt.w = true;
		cwt.f = new List<csk>
		{
			new csk(DamageType.Mechanical, A_2)
		};
		cwt.q = false;
		cwt.b = true;
		cwt.y = "{2} истекает кровью на ";
		if (A_4 != null && A_4.TypedDefinition != null)
		{
			cwt.ae = euf.d(A_4.TypedDefinition);
		}
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x0600966D RID: 38509 RVA: 0x003AD9A4 File Offset: 0x003ABBA4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/BleedingWound", new object[]
		{
			this.a
		});
	}

	// Token: 0x040039E4 RID: 14820
	private new int a;
}
