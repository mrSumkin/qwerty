using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x02001FD4 RID: 8148
public sealed class cqi : aiu
{
	// Token: 0x0600BF57 RID: 48983 RVA: 0x004239BC File Offset: 0x00421BBC
	public cqi() : base(TimelapseCursor.PsiBookItemDrag.ToString())
	{
	}

	// Token: 0x0600BF58 RID: 48984 RVA: 0x004239E0 File Offset: 0x00421BE0
	public override void ob(e6d A_0, cp9 A_1, bool A_2)
	{
		chr service = bpo.GetService<chr>();
		cne service2 = bpo.GetService<cne>();
		if (service != null && service2 != null && service.ax() != null)
		{
			c3i c3i = null;
			ejq ejq = service.ax().c() as ejq;
			if (ejq != null && ejq.a != null)
			{
				c3n c3n = dgk.a(ejq.a);
				if (c3n != null)
				{
					c3i = ejh.b(c3n.bm(null), service2);
				}
			}
			if (c3i != null)
			{
				Vector2 a_ = new Vector2((float)(A_0.b().X - c3i.a.c / 2), (float)(A_0.b().Y - c3i.a.d / 2));
				c3i.a(A_1, a_, A_2 ? Color.White : c69.a, 1f, 0, null);
			}
		}
	}
}
