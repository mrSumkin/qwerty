using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AC6 RID: 6854
[eiz("VDSE0")]
[Serializable]
public sealed class cpb : els, ISerializable
{
	// Token: 0x0600949A RID: 38042 RVA: 0x003A6FA4 File Offset: 0x003A51A4
	private cpb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = (A_0.GetValue("VDSE0:A", typeof(vf)) as vf);
	}

	// Token: 0x0600949B RID: 38043 RVA: 0x003A6FD0 File Offset: 0x003A51D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("VDSE0:A", this.d);
	}

	// Token: 0x0600949C RID: 38044 RVA: 0x003A6FEC File Offset: 0x003A51EC
	public cpb(int A_0) : base(cpb.a, "Вытягивание жизни", ci8.c)
	{
		base.Duration = A_0 * d0u.b;
		base.Icon = "Status.VitalityDrain";
		base.Stacking = axm.b;
		base.MaxStacks = 1;
		base.TickPeriod = d0u.b;
		this.d = new vf();
		this.d.TurnTickAttack = new cwt();
		this.d.TurnTickAttack.i = new ap9("Vitality Drain", null);
		this.d.TurnTickAttack.p = true;
		this.d.TurnTickAttack.l = true;
		this.d.TurnTickAttack.f.Add(new csk(DamageType.Bio, cpb.b));
		this.d.TurnTickAttack.b = true;
		this.d.TurnTickAttack.w = true;
		this.d.TurnTickAttack.r = true;
		this.d.DynamicTickAttack = this.d.TurnTickAttack;
		base.DynamicEffects.Add(this.d);
	}

	// Token: 0x0600949D RID: 38045 RVA: 0x003A7110 File Offset: 0x003A5310
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/VitalityDrain", new object[]
		{
			cpb.b
		});
	}

	// Token: 0x04003937 RID: 14647
	public new static readonly string a = "vitalityDrain";

	// Token: 0x04003938 RID: 14648
	public static readonly int b = 3;

	// Token: 0x04003939 RID: 14649
	public new static readonly int c = 10;

	// Token: 0x0400393A RID: 14650
	private new vf d;
}
