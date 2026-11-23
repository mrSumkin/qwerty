using System;
using System.Runtime.Serialization;

// Token: 0x02001ACC RID: 6860
[eiz("PMSE")]
[Serializable]
public sealed class cyo : els, ISerializable
{
	// Token: 0x060094B9 RID: 38073 RVA: 0x003A77DC File Offset: 0x003A59DC
	private cyo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094BA RID: 38074 RVA: 0x003A77E8 File Offset: 0x003A59E8
	public cyo() : this(cyo.b)
	{
	}

	// Token: 0x060094BB RID: 38075 RVA: 0x003A77F8 File Offset: 0x003A59F8
	public cyo(int A_0) : base("pelletMayhem", "Семя раздора", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.PelletMayhem";
		base.MaxStacks = cyo.a;
		base.Stacking = axm.b;
	}

	// Token: 0x060094BC RID: 38076 RVA: 0x003A783C File Offset: 0x003A5A3C
	public override string cb(ll A_0)
	{
		double num = etq.a;
		if (A_0 != null && A_0.a() != null)
		{
			num += (double)A_0.a().GetSpecializationValue<b62>(true) * b62.a;
		}
		return qv.a("StatusEffects/PelletMayhem", new object[]
		{
			Math.Round(num * (double)base.Stacks * 100.0, 2)
		});
	}

	// Token: 0x04003949 RID: 14665
	public new static readonly int a = 100;

	// Token: 0x0400394A RID: 14666
	public static readonly int b = 3 * d0u.b;
}
