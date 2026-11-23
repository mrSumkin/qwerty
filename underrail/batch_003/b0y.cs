using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001B26 RID: 6950
[eiz("SW1")]
[Serializable]
public sealed class b0y : els, ISerializable
{
	// Token: 0x06009655 RID: 38485 RVA: 0x003AD514 File Offset: 0x003AB714
	private b0y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009656 RID: 38486 RVA: 0x003AD520 File Offset: 0x003AB720
	public b0y(int A_0) : base("safeMode", "Безопасный режим", ci8.b)
	{
		base.Icon = "Status.25";
		base.Duration = A_0;
		base.StaticEffects.Add(new awe(CharacterImmunities.ShortCircuiting));
	}

	// Token: 0x06009657 RID: 38487 RVA: 0x003AD568 File Offset: 0x003AB768
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/SafeMode");
	}
}
