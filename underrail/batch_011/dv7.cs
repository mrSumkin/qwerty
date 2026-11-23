using System;
using System.Collections.Generic;

// Token: 0x02000550 RID: 1360
[euj]
public sealed class dv7
{
	// Token: 0x060022C9 RID: 8905 RVA: 0x000B8AC0 File Offset: 0x000B6CC0
	[ayh("TrainHelper_ExtractTrainInterior_Test")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ld.b(bpo.GetServiceOrThrow<cnk>().aqw(), "train", false);
	}

	// Token: 0x060022CA RID: 8906 RVA: 0x000B8AD8 File Offset: 0x000B6CD8
	[ayh("TrainHelper_DeployTrainInterior_Test")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ld.a(bpo.GetServiceOrThrow<cnk>().aqw(), "train", false);
	}

	// Token: 0x060022CB RID: 8907 RVA: 0x000B8AF0 File Offset: 0x000B6CF0
	[ayh("TrainHelper_ExtractTrainInterior_Test2")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ld.b(bpo.GetServiceOrThrow<cnk>().aqw(), "train2", true);
	}

	// Token: 0x060022CC RID: 8908 RVA: 0x000B8B08 File Offset: 0x000B6D08
	[ayh("TrainHelper_DeployTrainInterior_Test2")]
	public void e(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ld.a(bpo.GetServiceOrThrow<cnk>().aqw(), "train2", true);
	}

	// Token: 0x060022CD RID: 8909 RVA: 0x000B8B20 File Offset: 0x000B6D20
	[ayh("TrainHelper_ExtractTrainInterior_DarkTer2")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		ld.b(bpo.GetServiceOrThrow<cnk>().aqw(), "railcar_itemTransfer", true);
	}
}
