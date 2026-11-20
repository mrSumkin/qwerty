using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001ACA RID: 6858
[eiz("SBRSE")]
[Serializable]
public sealed class d2o : els, ISerializable
{
	// Token: 0x060094B1 RID: 38065 RVA: 0x003A75E4 File Offset: 0x003A57E4
	private d2o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094B2 RID: 38066 RVA: 0x003A75F0 File Offset: 0x003A57F0
	public d2o() : base("RestlessSpirits", "Неупокоенные духи", ci8.c)
	{
		base.Duration = d2o.b * d0u.b;
		base.TickPeriod = 0;
		base.Icon = "Status.RestlessSpirits";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Dexterity.ToString(), -d2o.a));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Perception.ToString(), -d2o.a));
	}

	// Token: 0x060094B3 RID: 38067 RVA: 0x003A7684 File Offset: 0x003A5884
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/RestlessSpirits", new object[]
		{
			d2o.a
		});
	}

	// Token: 0x04003946 RID: 14662
	public new static readonly int a = 3;

	// Token: 0x04003947 RID: 14663
	public static readonly int b = 10;
}
