using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001808 RID: 6152
[eiz("COEXASE")]
[Serializable]
public sealed class bzz : els, ISerializable
{
	// Token: 0x060082C5 RID: 33477 RVA: 0x0036D254 File Offset: 0x0036B454
	private bzz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060082C6 RID: 33478 RVA: 0x0036D264 File Offset: 0x0036B464
	public bzz(int A_0) : base(bzz.a, "Мощность боевого экзоскелета", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Abilities.77";
		base.TickPeriod = d0u.b;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Strength.ToString(), bem.h));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Agility.ToString(), A_0));
		base.StaticEffects.Add(new ba(bem.j, true, false, false));
		base.StaticEffects.Add(new i0(bem.k, true, false, false));
		this.z = "COEXAT";
		this.ac = "COEXAM";
	}

	// Token: 0x060082C7 RID: 33479 RVA: 0x0036D33C File Offset: 0x0036B53C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CombatExoskeletonAura", new object[]
		{
			bem.h,
			bem.j,
			bem.f,
			bem.g.ToString("0.0")
		});
	}

	// Token: 0x04003275 RID: 12917
	public new static readonly string a = "combatExoskeletonAura";
}
