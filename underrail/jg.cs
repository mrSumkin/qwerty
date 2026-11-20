using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001838 RID: 6200
[eiz("INEXASE")]
[Serializable]
public sealed class jg : els, ISerializable
{
	// Token: 0x0600843D RID: 33853 RVA: 0x00371404 File Offset: 0x0036F604
	private jg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600843E RID: 33854 RVA: 0x00371414 File Offset: 0x0036F614
	public jg() : base(jg.a, "Мощность экзоскелета", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Abilities.77";
		base.TickPeriod = d0u.b;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.StaticEffects.Add(new dpw("Stealth", -10000)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Strength.ToString(), e6v.h));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Agility.ToString(), e6v.i));
		base.StaticEffects.Add(new ba(e6v.j, true, false, false));
		base.StaticEffects.Add(new i0(e6v.k, true, false, false));
		base.VisualEffects.Add(new ud(this, "IndustrialExoskeletonAura"));
		this.w = "INEXAA";
		this.x = "INEXAR";
		this.ab = "INEXAA";
		this.aa = "INEXAR";
		this.y = "INEXAR";
		this.z = "INEXAT";
		this.ac = "INEXAM";
	}

	// Token: 0x0600843F RID: 33855 RVA: 0x00371564 File Offset: 0x0036F764
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/IndustrialExoskeletonAura", new object[]
		{
			e6v.h,
			e6v.j,
			e6v.f,
			e6v.g
		});
	}

	// Token: 0x040032B5 RID: 12981
	public new static readonly string a = "industrialExoskeletonAura";
}
