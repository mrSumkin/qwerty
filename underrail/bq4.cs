using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ABC RID: 6844
[eiz("VRSE")]
[Serializable]
public sealed class bq4 : els, ISerializable, dl2
{
	// Token: 0x06009463 RID: 37987 RVA: 0x003A61E0 File Offset: 0x003A43E0
	private bq4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009464 RID: 37988 RVA: 0x003A61EC File Offset: 0x003A43EC
	public bq4(efk A_0) : base(bq4.a, "Гниль пустоты", ci8.c)
	{
		base.Duration = d0u.b * 3;
		base.Icon = "Status.VoidRot";
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.MaxStacks = bq4.c;
		cwt cwt = new cwt();
		cwt.i = new ap9("Void Rot", (A_0 != null) ? A_0.FactionId : null);
		cwt.f.Add(new csk(DamageType.Energy, bq4.b));
		cwt.l = true;
		cwt.p = true;
		cwt.r = true;
		cwt.b = true;
		cwt.w = true;
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x06009465 RID: 37989 RVA: 0x003A62B4 File Offset: 0x003A44B4
	public override string cb(ll A_0)
	{
		int num = ((vf)base.DynamicEffects[0]).TurnTickAttack.f[0].Amount;
		return qv.a("StatusEffects/VoidRot", new object[]
		{
			num
		});
	}

	// Token: 0x06009466 RID: 37990 RVA: 0x003A6304 File Offset: 0x003A4504
	protected override void c8()
	{
		base.c8();
		((vf)base.DynamicEffects[0]).TurnTickAttack.f[0] = new csk(DamageType.Energy, bq4.b * base.Stacks);
	}

	// Token: 0x0400390E RID: 14606
	public new static string a = "voidRot";

	// Token: 0x0400390F RID: 14607
	public static int b = 2;

	// Token: 0x04003910 RID: 14608
	public new static int c = 5;
}
