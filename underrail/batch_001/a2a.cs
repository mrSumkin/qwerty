using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001B27 RID: 6951
[eiz("SW0")]
[Serializable]
public sealed class a2a : els, ISerializable
{
	// Token: 0x06009658 RID: 38488 RVA: 0x003AD574 File Offset: 0x003AB774
	private a2a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009659 RID: 38489 RVA: 0x003AD580 File Offset: 0x003AB780
	public a2a(int A_0) : base(a2a.a, "Второе дыхание", ci8.b)
	{
		base.Icon = "Status.SecondWind";
		base.Duration = A_0;
		base.StaticEffects.Add(new awe(CharacterImmunities.Stun));
	}

	// Token: 0x0600965A RID: 38490 RVA: 0x003AD5C4 File Offset: 0x003AB7C4
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/SecondWind");
	}

	// Token: 0x040039DE RID: 14814
	public new static readonly string a = "secondWind";
}
