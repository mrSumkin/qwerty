using System;
using System.Runtime.Serialization;

// Token: 0x02001AF6 RID: 6902
[eiz("SSDS")]
[Serializable]
public sealed class kd : els, ISerializable
{
	// Token: 0x06009582 RID: 38274 RVA: 0x003AA624 File Offset: 0x003A8824
	private kd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009583 RID: 38275 RVA: 0x003AA630 File Offset: 0x003A8830
	public kd(int A_0) : base("supersoldierDrug", "Сыворотка сверхсолдата", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.68";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6("Strength", kd.a));
		base.StaticEffects.Add(new ax6("Dexterity", kd.a));
		base.StaticEffects.Add(new ax6("Constitution", kd.a));
		base.StaticEffects.Add(new ax6("Agility", kd.a));
		base.StaticEffects.Add(new ax6("Perception", kd.a));
		base.StaticEffects.Add(new bxb("Guns", kd.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Throwing", kd.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Crossbows", kd.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Melee", kd.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Dodge", kd.b)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Evasion", kd.b)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009584 RID: 38276 RVA: 0x003AA7C8 File Offset: 0x003A89C8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SupersoldierDrug", new object[]
		{
			kd.a,
			(int)(kd.b * 100f)
		});
	}

	// Token: 0x04003992 RID: 14738
	public new static readonly int a = 2;

	// Token: 0x04003993 RID: 14739
	public static readonly float b = 0.2f;
}
