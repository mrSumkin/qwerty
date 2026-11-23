using System;

// Token: 0x02000F29 RID: 3881
[e79("Xpbl_Le_ExpeditionBegins")]
public sealed class ag7 : dgy
{
	// Token: 0x06004EEE RID: 20206 RVA: 0x00238070 File Offset: 0x00236270
	public ag7()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() is c5x)
		{
			serviceOrThrow.aqu().r()["expeditionReturnsWithPlayer"] = true;
			btm[] array = new btm[1];
			int num = 0;
			dky dky = new dky();
			dky.a(0.2f);
			dky.a(false);
			array[num] = dky;
			base.a(array);
			base.a(new btm[]
			{
				new di4(new c2w("xpbl_c3", "playerExpeditionReturnsCutscene"), false, new bool?(false), 0, null, false, false, false)
			});
		}
	}
}
