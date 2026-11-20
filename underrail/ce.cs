using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001AD1 RID: 6865
[eiz("RSFX")]
[Serializable]
public sealed class ce : els, ISerializable
{
	// Token: 0x060094D1 RID: 38097 RVA: 0x003A7B78 File Offset: 0x003A5D78
	private ce(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094D2 RID: 38098 RVA: 0x003A7B84 File Offset: 0x003A5D84
	public ce() : this(ce.b * d0u.b)
	{
	}

	// Token: 0x060094D3 RID: 38099 RVA: 0x003A7B9C File Offset: 0x003A5D9C
	public ce(int A_0) : base("rusting", "Ржавчина", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Rusting";
		base.MaxStacks = ce.a;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.DynamicEffects.Add(new aug((double)(ce.c * base.Stacks), new ItemRepairCategory?(ItemRepairCategory.Mechanical)));
	}

	// Token: 0x060094D4 RID: 38100 RVA: 0x003A7C0C File Offset: 0x003A5E0C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Rusting", new object[]
		{
			ce.c * base.Stacks
		});
	}

	// Token: 0x060094D5 RID: 38101 RVA: 0x003A7C34 File Offset: 0x003A5E34
	protected override void c8()
	{
		((aug)base.DynamicEffects[0]).a((double)(ce.c * base.Stacks));
	}

	// Token: 0x04003951 RID: 14673
	public new static readonly int a = 10;

	// Token: 0x04003952 RID: 14674
	public static readonly int b = 10;

	// Token: 0x04003953 RID: 14675
	public new static readonly int c = 2;
}
