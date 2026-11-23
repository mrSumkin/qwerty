using System;
using TimelapseVertigo.Common;

// Token: 0x0200059D RID: 1437
public sealed class ep0 : azl
{
	// Token: 0x06002636 RID: 9782 RVA: 0x000D8280 File Offset: 0x000D6480
	public void a()
	{
		bcm bcm = bjn.b();
		bnr bnr = bpo.GetServiceOrThrow<d1a>().aa7() as bnr;
		bcm.aav(new a8k(this));
		if (bnr != null)
		{
			bnr.e(bcm.aau());
			bnr.ap();
			bnr.a9();
		}
		am7 serviceOrThrow = bpo.GetServiceOrThrow<am7>();
		string text = czo.c();
		string value = czo.b();
		if (serviceOrThrow.ai2() == null || (!serviceOrThrow.ai2().a().Equals(text, StringComparison.OrdinalIgnoreCase) && !serviceOrThrow.ai2().a().Equals(value, StringComparison.OrdinalIgnoreCase)))
		{
			serviceOrThrow.ai5();
			serviceOrThrow.ai3(c2g.a, new bn3(text, 1f, null, null));
			serviceOrThrow.ai6();
			a3o.c();
		}
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x000D8354 File Offset: 0x000D6554
	public void aty()
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.StartNewGame, new object[0]));
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x000D836C File Offset: 0x000D656C
	public void atz()
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ExitProgram, new object[0]));
	}
}
