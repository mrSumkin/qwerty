using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A8B RID: 6795
[eiz("FMMR")]
[Serializable]
public sealed class el : els, ISerializable
{
	// Token: 0x06009388 RID: 37768 RVA: 0x003A2BFC File Offset: 0x003A0DFC
	private el(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009389 RID: 37769 RVA: 0x003A2C08 File Offset: 0x003A0E08
	public el(int A_0) : base(el.a, "Замороженные воспоминания", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.FreezingMemories";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Will.ToString(), a2k.f));
		base.StaticEffects.Add(new e3r(DamageType.Cold, -a2k.a));
		base.StaticEffects.Add(new e3r(DamageType.Mechanical, -a2k.b));
		base.StaticEffects.Add(new awe(CharacterImmunities.Chill | CharacterImmunities.Freeze));
	}

	// Token: 0x0600938A RID: 37770 RVA: 0x003A2CB0 File Offset: 0x003A0EB0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/FreezingMemories", new object[]
		{
			Convert.ToInt32(a2k.a * 100.0),
			Convert.ToInt32(a2k.b * 100.0),
			a2k.f
		});
	}

	// Token: 0x040038AD RID: 14509
	public new static readonly string a = "freezingMemories";
}
