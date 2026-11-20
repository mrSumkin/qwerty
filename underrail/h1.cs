using System;
using TimelapseVertigo.Common;

// Token: 0x02000590 RID: 1424
public sealed class h1
{
	// Token: 0x060024E4 RID: 9444 RVA: 0x000D037C File Offset: 0x000CE57C
	private void a(object A_0, el5 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		iw iw = A_0 as iw;
		if (iw != null)
		{
			serviceOrThrow.aqu().a(iw.g() as au2);
			if (iw.i() != null)
			{
				serviceOrThrow.aqu().a(iw.i());
			}
		}
		d4m serviceOrThrow2 = bpo.GetServiceOrThrow<d4m>();
		if (A_1.a() == cku.b)
		{
			serviceOrThrow2.avp(dla.a(TimelapseWorkflows.ReturnToMainMenu, new object[0]));
			return;
		}
		if (A_1.a() == cku.a)
		{
			serviceOrThrow2.avp(dla.a(TimelapseWorkflows.StartGameInLocale, new object[0]));
		}
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000D0410 File Offset: 0x000CE610
	public void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bcm serviceOrThrow2 = bpo.GetServiceOrThrow<bcm>();
		iw iw = new iw(serviceOrThrow.aqu().v(), a9m.c, true);
		iw.Focusable = true;
		iw.a(new EventHandler<el5>(this.a));
		serviceOrThrow2.aav(iw);
		serviceOrThrow2.aax(iw);
	}
}
