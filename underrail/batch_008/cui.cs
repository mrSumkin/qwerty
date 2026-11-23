using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B39 RID: 6969
[eiz("KWSE")]
[Serializable]
public sealed class cui : els, ISerializable
{
	// Token: 0x060096B7 RID: 38583 RVA: 0x003AE814 File Offset: 0x003ACA14
	private cui(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("KWSE:DPT");
		this.b = A_0.GetSingle("KWSE:SR");
	}

	// Token: 0x060096B8 RID: 38584 RVA: 0x003AE840 File Offset: 0x003ACA40
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("KWSE:DPT", this.a);
		info.AddValue("KWSE:SR", this.b);
	}

	// Token: 0x060096B9 RID: 38585 RVA: 0x003AE86C File Offset: 0x003ACA6C
	public cui(efk A_0, int A_1, int A_2, cd1 A_3) : base("kneeWound", "Раненое колено", ci8.c)
	{
		base.Duration = A_1;
		base.Icon = "sa.kcs";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = A_2;
		base.TickPeriod = d0u.b;
		this.a = A_2;
		this.b = edd.a;
		i0 i = new i0(-this.b, false, true, false);
		i.Priority = int.MaxValue;
		base.StaticEffects.Add(i);
		ba ba = new ba(-10000, false, true, false);
		ba.Priority = int.MaxValue;
		base.StaticEffects.Add(ba);
		if (this.a > 0)
		{
			cwt cwt = new cwt();
			cwt.i = new ap9("Bleeding wound", (A_0 != null) ? A_0.FactionId : null);
			cwt.f.Add(new csk(DamageType.Mechanical, this.a));
			cwt.l = true;
			cwt.p = true;
			cwt.r = true;
			cwt.b = true;
			cwt.w = true;
			if (A_3 != null && A_3.TypedDefinition != null)
			{
				cwt.ae = euf.d(A_3.TypedDefinition);
			}
			base.DynamicEffects.Add(new vf(cwt, cwt, null));
		}
	}

	// Token: 0x060096BA RID: 38586 RVA: 0x003AE9C0 File Offset: 0x003ACBC0
	public override string cb(ll A_0)
	{
		if (A_0 != null && A_0.a().d(CharacterImmunities.Slow))
		{
			if (this.a > 0)
			{
				return qv.a("StatusEffects/KneeWound1-SlowImmune", new object[]
				{
					this.a
				});
			}
			return qv.b("StatusEffects/KneeWound2-SlowImmune");
		}
		else
		{
			if (this.a > 0)
			{
				return qv.a("StatusEffects/KneeWound1", new object[]
				{
					this.a
				});
			}
			return qv.b("StatusEffects/KneeWound2");
		}
	}

	// Token: 0x040039F8 RID: 14840
	private new int a;

	// Token: 0x040039F9 RID: 14841
	private float b;
}
