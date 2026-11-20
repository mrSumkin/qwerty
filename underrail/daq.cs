using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000BBA RID: 3002
[euj]
public class daq
{
	// Token: 0x06004488 RID: 17544 RVA: 0x001B6E90 File Offset: 0x001B5090
	[ayh("LUXHJUATM")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				List<b0b> list = c5x.Zone.a().ab4(new string[]
				{
					"futureTimeBeetle"
				});
				if (list.Count <= 1)
				{
					this.b("futureObjectSection1");
					this.b("futureObjectSection2");
					this.b("futureObjectSection3");
					this.b("pastTimeObject");
					list.Clear();
					list = c5x.Zone.a().ab4(new string[]
					{
						"futureTimeObject"
					});
					foreach (b0b b0b in list)
					{
						c5x c5x2 = (c5x)b0b;
						awx awx = new awx();
						awx awx2 = awx;
						awx2.a(awx2.kh() | m7.b);
						List<auv> list2 = awx.ad();
						ad6 ad = new ad6(c5x2);
						ad.b(0.0);
						ad.c(1.0);
						ad.a(0.001);
						list2.Add(ad);
						c5x2.Zone.ActionManager.g9(awx, atp.a);
					}
					serviceOrThrow.aqw().n("lux-holeTM").StartingLightning = new Color(100, 100, 100, 255);
					for (int i = 0; i < serviceOrThrow.aqw().n("lux-holeTM").Size.c; i++)
					{
						for (int j = 0; j < serviceOrThrow.aqw().n("lux-holeTM").Size.d; j++)
						{
							ak1 ak = serviceOrThrow.aqw().n("lux-holeTM").b(i, j);
							if (ak != null)
							{
								ak.e();
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004489 RID: 17545 RVA: 0x001B70A8 File Offset: 0x001B52A8
	[ayh("LUXHJUATMSO")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (this.a("futureTimeBeetleSection1"))
		{
			this.b("futureObjectSection1");
		}
	}

	// Token: 0x0600448A RID: 17546 RVA: 0x001B70C8 File Offset: 0x001B52C8
	[ayh("LUXHJUATMST")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (this.a("futureTimeBeetleSection2"))
		{
			this.b("futureObjectSection2");
		}
	}

	// Token: 0x0600448B RID: 17547 RVA: 0x001B70E8 File Offset: 0x001B52E8
	[ayh("LUXHJUATMSTH")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (this.a("futureTimeBeetleSection3"))
		{
			this.b("futureObjectSection3");
		}
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x001B7108 File Offset: 0x001B5308
	public void b(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				List<b0b> list = c5x.Zone.a().ab4(new string[]
				{
					A_0
				});
				foreach (b0b b0b in list)
				{
					c5x c5x2 = (c5x)b0b;
					bim aspect = c5x2.GetAspect<bim>();
					if (aspect != null)
					{
						aspect.g(false);
					}
					awx awx = new awx();
					awx awx2 = awx;
					awx2.a(awx2.kh() | m7.b);
					List<auv> list2 = awx.ad();
					ad6 ad = new ad6(c5x2);
					ad.b(1.0);
					ad.c(0.0);
					ad.a(0.001);
					list2.Add(ad);
					awx.ad().Add(new bm3(1000));
					List<auv> list3 = awx.ad();
					uk uk = new uk();
					uk.a(bvl.e);
					uk.a(new Guid?(c5x2.qe()));
					list3.Add(new a4s(uk, new ar7(c5x2), null, null));
					c5x2.Zone.ActionManager.g9(awx, atp.a);
				}
				list.Clear();
			}
		}
	}

	// Token: 0x0600448D RID: 17549 RVA: 0x001B7284 File Offset: 0x001B5484
	public bool a(string A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				return c5x.Zone.a().ab4(new string[]
				{
					A_0
				}).Count <= 1;
			}
		}
		return false;
	}
}
