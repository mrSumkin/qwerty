using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000B3C RID: 2876
public static class w9
{
	// Token: 0x0600422F RID: 16943 RVA: 0x0019A504 File Offset: 0x00198704
	internal static void a(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			ah7 ah = serviceOrThrow.aqw().i("electricity" + A_0);
			if (ah != null)
			{
				w9.a(A_0, !ah.Enabled);
			}
		}
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x0019A550 File Offset: 0x00198750
	internal static void a(string A_0, bool A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null)
		{
			ah7 ah = serviceOrThrow.aqw().i("electricity" + A_0);
			if (ah != null)
			{
				ah.Enabled = A_1;
				ah.d();
			}
			List<b0b> list = serviceOrThrow.aqw().GetAddon<d60>().ab4(new string[]
			{
				"wall" + A_0
			});
			if (list != null)
			{
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.o.b != null)
					{
						if (A_1)
						{
							c5x.c().c("buzzing");
							c5x.TileFormationModifiers = new bjp(new byte[]
							{
								1
							});
							c5x.o.b.c = new Color?(Color.White);
							c5x.o.b.d = null;
						}
						else
						{
							c5x.c().d("buzzing");
							c5x.TileFormationModifiers = new bjp();
							c5x.o.b.c = null;
							c5x.o.b.d = new float?(0f);
						}
					}
				}
			}
		}
	}
}
