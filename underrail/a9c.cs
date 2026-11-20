using System;
using TimelapseVertigo.Common;

// Token: 0x0200057B RID: 1403
public sealed class a9c
{
	// Token: 0x0600243C RID: 9276 RVA: 0x000CAC6C File Offset: 0x000C8E6C
	private void a(object A_0, el5 A_1)
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ReturnToMainMenu, new object[0]));
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000CAC88 File Offset: 0x000C8E88
	public void a()
	{
		bpo.GetServiceOrThrow<cnk>();
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		t1 t = new t1(true);
		t.Focusable = true;
		t.a(new EventHandler<el5>(this.a));
		serviceOrThrow.aav(t);
		serviceOrThrow.aax(t);
	}
}
