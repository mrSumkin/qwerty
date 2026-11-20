using System;
using System.Collections.Generic;

// Token: 0x02001C17 RID: 7191
[d29("BeastOfBurden", "Beast of Burden")]
public sealed class ecm : ai8
{
	// Token: 0x06009DD6 RID: 40406 RVA: 0x003E0D10 File Offset: 0x003DEF10
	public override string au()
	{
		return "xphw";
	}

	// Token: 0x06009DD7 RID: 40407 RVA: 0x003E0D18 File Offset: 0x003DEF18
	public ecm() : base("肅Вьючное животное")
	{
	}

	// Token: 0x06009DD8 RID: 40408 RVA: 0x003E0D28 File Offset: 0x003DEF28
	public override object[] at()
	{
		return new object[]
		{
			ecm.a
		};
	}

	// Token: 0x06009DD9 RID: 40409 RVA: 0x003E0D40 File Offset: 0x003DEF40
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new bgl(ecm.a + A_0.GetSpecializationValue<a9j>(true) * a9j.a)
		};
	}

	// Token: 0x06009DDA RID: 40410 RVA: 0x003E0D68 File Offset: 0x003DEF68
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(d3m), 10)
		};
	}

	// Token: 0x04003D44 RID: 15684
	public new static readonly int a = 150;
}
