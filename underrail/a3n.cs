using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FD5 RID: 8149
public sealed class a3n : aiu
{
	// Token: 0x0600BF59 RID: 48985 RVA: 0x00423AD0 File Offset: 0x00421CD0
	public a3n() : base(TimelapseCursor.ItemDrag.ToString())
	{
	}

	// Token: 0x0600BF5A RID: 48986 RVA: 0x00423AF4 File Offset: 0x00421CF4
	public override void ob(e6d A_0, cp9 A_1, bool A_2)
	{
		chr service = bpo.GetService<chr>();
		cne service2 = bpo.GetService<cne>();
		if (service != null && service2 != null && service.ax() != null)
		{
			c3i c3i = null;
			coh coh = service.ax().c() as coh;
			if (coh != null)
			{
				c3i = ejh.b(coh.Definition.a3(), service2);
			}
			else
			{
				av av = service.ax().c() as av;
				bool a_ = false;
				if (av == null)
				{
					aui aui = service.ax().c() as aui;
					if (aui != null)
					{
						av = aui.a;
						a_ = aui.b;
					}
				}
				if (av != null)
				{
					c3i = ejh.a(av, service2, a_);
				}
			}
			if (c3i != null)
			{
				Vector2 vector = new Vector2((float)(A_0.b().X - c3i.a.c / 2), (float)(A_0.b().Y - c3i.a.d / 2));
				wj wj = wj.a();
				if (wj.d == UiSize.Classic)
				{
					c3i.a(A_1, vector, A_2 ? Color.White : c69.a, 1f, 0, null);
					return;
				}
				Rectangle a_2 = new Rectangle((int)vector.X, (int)vector.Y, wj.y.c, wj.y.d);
				c3i.a(A_1, a_2, A_2 ? Color.White : c69.a, 0, null);
			}
		}
	}
}
