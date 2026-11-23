using System;
using System.Runtime.Serialization;

// Token: 0x02001B25 RID: 6949
[eiz("STC")]
[Serializable]
public sealed class aw0 : els, ISerializable
{
	// Token: 0x06009651 RID: 38481 RVA: 0x003AD4C4 File Offset: 0x003AB6C4
	private aw0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009652 RID: 38482 RVA: 0x003AD4D0 File Offset: 0x003AB6D0
	public aw0() : base(aw0.a, "Особая тактика", ci8.b)
	{
		base.Duration = y6.b;
		base.Icon = "SpecialTactics";
	}

	// Token: 0x06009653 RID: 38483 RVA: 0x003AD4FC File Offset: 0x003AB6FC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/SpecialTactics");
	}

	// Token: 0x040039DD RID: 14813
	public new static readonly string a = "specialTactics";
}
