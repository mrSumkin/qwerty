using System;
using System.Collections.Generic;

// Token: 0x02001C60 RID: 7264
[d29("PsychostaticElectricity", "Psychostatic Electricity")]
public sealed class e59 : ai8
{
	// Token: 0x06009F42 RID: 40770 RVA: 0x003E3674 File Offset: 0x003E1874
	public override bool ap()
	{
		return false;
	}

	// Token: 0x06009F43 RID: 40771 RVA: 0x003E3678 File Offset: 0x003E1878
	public e59() : base("致Психостатическое электричество")
	{
	}

	// Token: 0x06009F44 RID: 40772 RVA: 0x003E3688 File Offset: 0x003E1888
	public override void ar(efk A_0)
	{
	}

	// Token: 0x06009F45 RID: 40773 RVA: 0x003E368C File Offset: 0x003E188C
	public override void @as(efk A_0)
	{
	}

	// Token: 0x06009F46 RID: 40774 RVA: 0x003E3690 File Offset: 0x003E1890
	public override object[] at()
	{
		return new object[]
		{
			(int)(cyi.c * 100.0),
			l4.a(cyi.b, false),
			cyi.d
		};
	}

	// Token: 0x06009F47 RID: 40775 RVA: 0x003E36CC File Offset: 0x003E18CC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new bap(40, new Type[]
			{
				typeof(fd)
			}),
			new b6h(new Type[]
			{
				typeof(dl3),
				typeof(ehf)
			})
		};
	}
}
