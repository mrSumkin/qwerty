using System;
using System.Collections.Generic;

// Token: 0x02001C65 RID: 7269
[d29("Meditation", "Meditation")]
public sealed class edh : ai8
{
	// Token: 0x06009F63 RID: 40803 RVA: 0x003E3A48 File Offset: 0x003E1C48
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F64 RID: 40804 RVA: 0x003E3A4C File Offset: 0x003E1C4C
	public edh() : base("臔Медитация")
	{
	}

	// Token: 0x06009F65 RID: 40805 RVA: 0x003E3A5C File Offset: 0x003E1C5C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new d72(edh.a + A_0.GetSpecializationValue<awl>(true) * awl.a)
		};
	}

	// Token: 0x06009F66 RID: 40806 RVA: 0x003E3A84 File Offset: 0x003E1C84
	public override object[] at()
	{
		return new object[]
		{
			edh.a
		};
	}

	// Token: 0x06009F67 RID: 40807 RVA: 0x003E3A9C File Offset: 0x003E1C9C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axr), 7),
			new awr(typeof(av8), 5),
			new db7(50),
			new b4k(new Type[]
			{
				typeof(cvc)
			})
		};
	}

	// Token: 0x04003D9F RID: 15775
	public new static readonly int a = 25;
}
