using System;
using System.Runtime.Serialization;

// Token: 0x02001ACF RID: 6863
[eiz("FSE5")]
[Serializable]
public sealed class c53 : els, ISerializable
{
	// Token: 0x060094CA RID: 38090 RVA: 0x003A7A60 File Offset: 0x003A5C60
	private c53(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094CB RID: 38091 RVA: 0x003A7A6C File Offset: 0x003A5C6C
	public c53() : base("flurry", "Шквал", ci8.b)
	{
		base.Duration = b67.g * d0u.b;
		base.Icon = "xpbl_Abilities.14";
		base.MaxStacks = b67.f;
		base.Stacking = axm.b;
	}

	// Token: 0x060094CC RID: 38092 RVA: 0x003A7AB8 File Offset: 0x003A5CB8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Flurry", new object[]
		{
			b67.e * base.Stacks
		});
	}
}
