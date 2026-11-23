using System;
using System.Runtime.Serialization;

// Token: 0x02001AB9 RID: 6841
[eiz("SCSE7")]
[Serializable]
public sealed class eq7 : els, ISerializable
{
	// Token: 0x06009457 RID: 37975 RVA: 0x003A5F5C File Offset: 0x003A415C
	private eq7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009458 RID: 37976 RVA: 0x003A5F68 File Offset: 0x003A4168
	public eq7() : base(eq7.a, "Подсчёт дроби", ci8.b)
	{
		base.Icon = "xpbl_Abilities.24";
		base.MaxStacks = 5;
		base.Duration = d0u.b * 3;
		base.Stacking = axm.b;
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x003A5FAC File Offset: 0x003A41AC
	public override string cb(ll A_0)
	{
		double num = eb9.a((A_0 != null) ? A_0.a() : null, base.Stacks);
		return qv.a("StatusEffects/ShellCount", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}

	// Token: 0x0400390A RID: 14602
	public new static readonly string a = "shellCount";
}
