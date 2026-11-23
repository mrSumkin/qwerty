using System;
using System.Runtime.Serialization;

// Token: 0x02001ABB RID: 6843
[eiz("ISSE2")]
[Serializable]
public sealed class dn9 : els, ISerializable
{
	// Token: 0x0600945F RID: 37983 RVA: 0x003A6104 File Offset: 0x003A4304
	private dn9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009460 RID: 37984 RVA: 0x003A6110 File Offset: 0x003A4310
	public dn9(float A_0, int A_1) : base(dn9.a, "Эксперт спринта", ci8.b)
	{
		base.Icon = "ImprovedSprint";
		base.StaticEffects.Add(new i0(A_0, true, false, false));
		base.StaticEffects.Add(new ba(A_1, true, false, false));
		base.StaticEffects.Add(new d9(aaf.a, false, true));
	}

	// Token: 0x06009461 RID: 37985 RVA: 0x003A6178 File Offset: 0x003A4378
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ImprovedSprint", new object[]
		{
			(base.StaticEffects[1] as ba).a,
			(base.StaticEffects[2] as d9).a
		});
	}

	// Token: 0x0400390D RID: 14605
	public new static readonly string a = "improvedSprint";
}
