using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A9C RID: 6812
[eiz("BSE")]
[Serializable]
public sealed class e8l : els, ISerializable
{
	// Token: 0x060093D5 RID: 37845 RVA: 0x003A406C File Offset: 0x003A226C
	private e8l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093D6 RID: 37846 RVA: 0x003A4078 File Offset: 0x003A2278
	public e8l(int A_0) : base("bullhead", "Твердолобость", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.Bullhead";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new awe(CharacterImmunities.Stun));
		base.StaticEffects.Add(new awe(CharacterImmunities.Incapacitation));
		base.StaticEffects.Add(new awe(CharacterImmunities.Daze));
	}

	// Token: 0x060093D7 RID: 37847 RVA: 0x003A40EC File Offset: 0x003A22EC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Bullhead");
	}
}
