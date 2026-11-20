using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001829 RID: 6185
[eiz("HTRPSE")]
[Serializable]
public sealed class c97 : els, ISerializable
{
	// Token: 0x060083BC RID: 33724 RVA: 0x0036F550 File Offset: 0x0036D750
	private c97(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060083BD RID: 33725 RVA: 0x0036F55C File Offset: 0x0036D75C
	public c97(string A_0, int A_1, int A_2) : base(c97.a, "Ошейник страданий", ci8.c)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Explosives.181";
		base.Stacking = axm.b;
		base.Power = A_2;
		base.VisualEffects.Add(new ud(this, "HeadTrap"));
		cwt cwt = new cwt();
		cwt.i = new ap9("Trapped head", A_0);
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
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Perception.ToString(), -ath.f));
	}

	// Token: 0x060083BE RID: 33726 RVA: 0x0036F654 File Offset: 0x0036D854
	public override string cb(ll A_0)
	{
		int num = (base.DynamicEffects[0] as vf).TurnTickAttack.f[0].Amount;
		int num2 = Math.Abs((base.StaticEffects[0] as ax6).c());
		return qv.a("StatusEffects/HeadTrap", new object[]
		{
			num,
			num2
		});
	}

	// Token: 0x04003296 RID: 12950
	public new static readonly string a = "headTrap";
}
