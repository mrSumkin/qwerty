using System;
using System.Runtime.Serialization;

// Token: 0x02001AF3 RID: 6899
[eiz("EOT")]
[Serializable]
public sealed class aav : els, ISerializable
{
	// Token: 0x06009575 RID: 38261 RVA: 0x003AA02C File Offset: 0x003A822C
	private aav(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009576 RID: 38262 RVA: 0x003AA038 File Offset: 0x003A8238
	public aav(int A_0) : base(aav.a, "Глаз Чорта", ci8.c)
	{
		base.Icon = "Status.EyeOfTchort";
		base.Duration = A_0;
		base.StaticEffects.Add(new bxb("Guns", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Heavy Guns", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Crossbows", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Throwing", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Melee", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Dodge", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Evasion", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Metathermics", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Thought Control", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Psychokinesis", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new bxb("Temporal Manipulation", -v7.b * (float)v7.c)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009577 RID: 38263 RVA: 0x003AA258 File Offset: 0x003A8458
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/EyeOfTchort", new object[]
		{
			(int)(Math.Round((double)(v7.b * (float)v7.c), 2) * 100.0)
		});
	}

	// Token: 0x0400398D RID: 14733
	public new static readonly string a = "eyeofTchort";
}
