using System;
using System.Collections.Generic;

// Token: 0x02001C6C RID: 7276
[d29("MajorSupplier", "Major Supplier")]
public sealed class pg : aw2
{
	// Token: 0x06009F8D RID: 40845 RVA: 0x003E3E54 File Offset: 0x003E2054
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F8E RID: 40846 RVA: 0x003E3E58 File Offset: 0x003E2058
	public pg() : base("肝Крупный поставщик")
	{
	}

	// Token: 0x06009F8F RID: 40847 RVA: 0x003E3E68 File Offset: 0x003E2068
	public override object[] at()
	{
		return new object[]
		{
			(int)(pg.a * 100.0)
		};
	}

	// Token: 0x06009F90 RID: 40848 RVA: 0x003E3E8C File Offset: 0x003E208C
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		list.Add(new bap(50, new Type[]
		{
			typeof(e70)
		}));
		return list;
	}

	// Token: 0x04003DA6 RID: 15782
	public new static readonly double a = 0.02;
}
