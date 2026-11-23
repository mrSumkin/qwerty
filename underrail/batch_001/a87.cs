using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001AC8 RID: 6856
[eiz("DPSE4")]
[Serializable]
public sealed class a87 : els, ISerializable
{
	// Token: 0x060094A9 RID: 38057 RVA: 0x003A73F8 File Offset: 0x003A55F8
	private a87(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094AA RID: 38058 RVA: 0x003A7404 File Offset: 0x003A5604
	public a87() : base("DarkPresence", "Тёмное присутствие", ci8.c)
	{
		base.Duration = a87.c * d0u.b;
		base.TickPeriod = 0;
		base.Icon = "Status.DarkPresence";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Will.ToString(), -a87.a));
		base.StaticEffects.Add(new cly((float)(-(float)a87.b))
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x060094AB RID: 38059 RVA: 0x003A7494 File Offset: 0x003A5694
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/DarkPresence", new object[]
		{
			a87.a,
			Convert.ToInt32(a87.b * 100.0)
		});
	}

	// Token: 0x04003942 RID: 14658
	public new static readonly int a = 3;

	// Token: 0x04003943 RID: 14659
	public static readonly double b = 0.75;

	// Token: 0x04003944 RID: 14660
	public new static readonly int c = 10;
}
