using System;
using System.Runtime.Serialization;

// Token: 0x02001B20 RID: 6944
[eiz("ISQ")]
[Serializable]
public sealed class ef2 : els, ISerializable
{
	// Token: 0x0600963E RID: 38462 RVA: 0x003AD08C File Offset: 0x003AB28C
	private ef2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600963F RID: 38463 RVA: 0x003AD098 File Offset: 0x003AB298
	public ef2(int A_0, int A_1) : base(ef2.a, "Запугивание", ci8.c)
	{
		base.Icon = "Yell";
		base.Power = A_1;
		base.Duration = A_0;
		base.StaticEffects.Add(new dpw("Guns", -base.Power)
		{
			Priority = 200
		});
		base.StaticEffects.Add(new dpw("Heavy Guns", -base.Power)
		{
			Priority = 200
		});
		base.StaticEffects.Add(new dpw("Crossbows", -base.Power)
		{
			Priority = 200
		});
		base.StaticEffects.Add(new dpw("Throwing", -base.Power)
		{
			Priority = 200
		});
		base.StaticEffects.Add(new dpw("Melee", -base.Power)
		{
			Priority = 200
		});
	}

	// Token: 0x06009640 RID: 38464 RVA: 0x003AD194 File Offset: 0x003AB394
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Intimidated", new object[]
		{
			base.Power
		});
	}

	// Token: 0x040039D6 RID: 14806
	public new static readonly string a = "запугивание";
}
