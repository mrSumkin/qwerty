using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001B2A RID: 6954
[eiz("L09")]
[Serializable]
public sealed class bgo : els, ISerializable
{
	// Token: 0x06009666 RID: 38502 RVA: 0x003AD804 File Offset: 0x003ABA04
	private bgo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009667 RID: 38503 RVA: 0x003AD810 File Offset: 0x003ABA10
	public bgo(int A_0) : base(bgo.a, "Локус контроля", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "LocusOfControl";
		base.StaticEffects.Add(new awe(CharacterImmunities.MindAffecting | CharacterImmunities.Stun | CharacterImmunities.Incapacitation | CharacterImmunities.Fear));
	}

	// Token: 0x06009668 RID: 38504 RVA: 0x003AD858 File Offset: 0x003ABA58
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/LocusOfControl");
	}

	// Token: 0x040039E2 RID: 14818
	public new static readonly string a = "locusOfContorl";

	// Token: 0x040039E3 RID: 14819
	public static readonly int b = 2;
}
