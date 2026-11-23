using System;
using System.Runtime.Serialization;

// Token: 0x02001ADA RID: 6874
[eiz("XPBLSHSE")]
[Serializable]
public sealed class djn : els, ISerializable
{
	// Token: 0x060094FA RID: 38138 RVA: 0x003A8460 File Offset: 0x003A6660
	private djn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094FB RID: 38139 RVA: 0x003A846C File Offset: 0x003A666C
	public djn(int A_0, int A_1) : base("soreHands", "Больные руки", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.SoreHands";
		base.Stacking = axm.b;
		base.Power = A_1;
		base.StaticEffects.Add(new ax6("Dexterity", base.Power));
	}

	// Token: 0x060094FC RID: 38140 RVA: 0x003A84C8 File Offset: 0x003A66C8
	public override string cb(ll A_0)
	{
		int num = base.Power;
		return qv.a("StatusEffects/SoreHands", new object[]
		{
			num
		});
	}
}
