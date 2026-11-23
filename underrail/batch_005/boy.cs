using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A6C RID: 6764
[eiz("MUTSSE")]
[Serializable]
public sealed class boy : els, ISerializable
{
	// Token: 0x060092EC RID: 37612 RVA: 0x003A0594 File Offset: 0x0039E794
	private boy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("MUTSSE:I");
	}

	// Token: 0x060092ED RID: 37613 RVA: 0x003A05B0 File Offset: 0x0039E7B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MUTSSE:I", this.b);
	}

	// Token: 0x060092EE RID: 37614 RVA: 0x003A05CC File Offset: 0x0039E7CC
	public boy(int A_0, int A_1) : base(boy.a, "Слабость мутации", ci8.c)
	{
		base.Icon = "Status.MutationSickness";
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.MaxStacks = 1;
		this.b = A_1;
		int num = Math.Abs(this.b);
		base.StaticEffects.Add(new bh1((double)Math.Max(-(0.1f * (float)num), -5f))
		{
			Priority = int.MaxValue
		});
		if (this.b <= -2)
		{
			int a_ = 10 * num;
			cwt cwt = new cwt();
			cwt.i = new ap9("Sickness", null);
			cwt.f.Add(new csk(DamageType.Bio, a_));
			cwt.l = true;
			cwt.p = true;
			cwt.r = true;
			cwt.b = true;
			cwt.w = true;
			cwt.y = "{2} получает ";
			base.DynamicEffects.Add(new vf(cwt, cwt, null));
		}
	}

	// Token: 0x060092EF RID: 37615 RVA: 0x003A06CC File Offset: 0x0039E8CC
	public override string cb(ll A_0)
	{
		int num = 0;
		if (base.DynamicEffects.Count > 0)
		{
			num = ((vf)base.DynamicEffects[0]).TurnTickAttack.f[0].Amount;
		}
		string text = qv.a("StatusEffects/MutationSickness", new object[]
		{
			Math.Abs(10 * this.b)
		});
		if (num != 0)
		{
			text = text + " Кроме того, вы получаете " + num.ToString() + " биологического урона каждый ход.";
		}
		return text;
	}

	// Token: 0x04003868 RID: 14440
	public new static readonly string a = "mutationSickness";

	// Token: 0x04003869 RID: 14441
	private int b;
}
