using System;
using System.Collections.Generic;

// Token: 0x02001C80 RID: 7296
[d29("MadChemist", "Mad Chemist")]
public sealed class ev4 : ai8
{
	// Token: 0x06009FDD RID: 40925 RVA: 0x003E47D0 File Offset: 0x003E29D0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x003E47D4 File Offset: 0x003E29D4
	public ev4() : base("胺Безумный химик")
	{
	}

	// Token: 0x06009FDF RID: 40927 RVA: 0x003E47E4 File Offset: 0x003E29E4
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x003E47E8 File Offset: 0x003E29E8
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009FE1 RID: 40929 RVA: 0x003E47EC File Offset: 0x003E29EC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 7),
			new bap(40, new Type[]
			{
				typeof(ii)
			})
		};
	}
}
