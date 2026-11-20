using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FC2 RID: 8130
public static class bd1
{
	// Token: 0x0600BF05 RID: 48901 RVA: 0x00421694 File Offset: 0x0041F894
	public static dsy a(euz A_0, amj A_1, Rectangle? A_2 = null)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int a_;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			a_ = (int)((double)djp.b * 2.5);
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			a_ = djp.b * 2;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			a_ = (int)((double)djp.b * 1.5);
		}
		else
		{
			a_ = djp.b;
		}
		return new dsy(A_0, A_1, djp.a, a_, A_2, null, djp.c, false, false);
	}
}
