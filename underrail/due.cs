using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A83 RID: 6787
[eiz("MFGSE")]
[Serializable]
public sealed class due : els, ISerializable
{
	// Token: 0x0600935E RID: 37726 RVA: 0x003A2134 File Offset: 0x003A0334
	private due(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600935F RID: 37727 RVA: 0x003A2140 File Offset: 0x003A0340
	public due(int A_0) : base(due.c, "Туман разума", ci8.c)
	{
		base.Stacking = axm.b;
		base.Duration = A_0;
		base.Icon = "Status.126";
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Intelligence.ToString(), -due.a));
		base.StaticEffects.Add(new ato(null, due.b));
	}

	// Token: 0x06009360 RID: 37728 RVA: 0x003A21BC File Offset: 0x003A03BC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/MindFog", new object[]
		{
			due.a,
			Convert.ToInt32(due.b * 100f)
		});
	}

	// Token: 0x0400388D RID: 14477
	private new static readonly int a = 2;

	// Token: 0x0400388E RID: 14478
	private static readonly float b = 0.35f;

	// Token: 0x0400388F RID: 14479
	public new static readonly string c = "mindFog";
}
