using System;
using System.Runtime.Serialization;

// Token: 0x02001ADF RID: 6879
[eiz("XPBLHISE")]
[Serializable]
public sealed class eyj : els, ISerializable
{
	// Token: 0x0600950E RID: 38158 RVA: 0x003A8804 File Offset: 0x003A6A04
	private eyj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600950F RID: 38159 RVA: 0x003A8810 File Offset: 0x003A6A10
	public eyj(int A_0, int A_1) : base("heavyIntoxication", "Тяжёлое опьянение", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Food.20";
		base.Stacking = axm.b;
		base.Power = A_1;
		base.StaticEffects.Add(new ax6("Strength", base.Power));
		base.StaticEffects.Add(new ax6("Dexterity", base.Power));
		base.StaticEffects.Add(new ax6("Agility", base.Power));
		base.StaticEffects.Add(new ax6("Constitution", base.Power));
		base.StaticEffects.Add(new ax6("Perception", base.Power));
		base.StaticEffects.Add(new ax6("Intelligence", base.Power));
		base.StaticEffects.Add(new ax6("Will", base.Power));
	}

	// Token: 0x06009510 RID: 38160 RVA: 0x003A890C File Offset: 0x003A6B0C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/HeavyIntoxication", new object[]
		{
			Math.Abs(base.Power)
		});
	}
}
