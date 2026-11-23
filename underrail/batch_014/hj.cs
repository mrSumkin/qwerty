using System;
using TimelapseVertigo.Common;

// Token: 0x02000578 RID: 1400
public sealed class hj
{
	// Token: 0x0600242F RID: 9263 RVA: 0x000CA918 File Offset: 0x000C8B18
	private void a(object A_0, el5 A_1)
	{
		d4m serviceOrThrow = bpo.GetServiceOrThrow<d4m>();
		if (A_1.a() == cku.b)
		{
			serviceOrThrow.avp(dla.a(TimelapseWorkflows.ReturnToMainMenu, new object[0]));
			return;
		}
		if (A_1.a() == cku.a)
		{
			serviceOrThrow.avp(dla.a(TimelapseWorkflows.StartCharacterGeneration, new object[0]));
		}
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x000CA968 File Offset: 0x000C8B68
	public void a()
	{
		bpo.GetServiceOrThrow<cnk>();
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		c9v c9v = new c9v(true, true);
		c9v.Focusable = true;
		c9v.a(new EventHandler<el5>(this.a));
		serviceOrThrow.aav(c9v);
		serviceOrThrow.aax(c9v);
	}
}
