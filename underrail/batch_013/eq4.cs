using System;
using System.Diagnostics;

// Token: 0x02002213 RID: 8723
[bmq("1.0.0.10_StationAlpha_Level5", "1.0.0.10", "StationAlpha-Level5", false)]
public sealed class eq4 : fg
{
	// Token: 0x0600CA7F RID: 51839 RVA: 0x0047BB38 File Offset: 0x00479D38
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("49eeff57-8a8b-4195-8f7d-eb61362f5eff"), A_1.Areas[0]).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("6acd573d-873d-4fc4-8ee4-ef879a103e93"), A_1.Areas[0]).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("b78341df-f617-4af6-9129-14d86e180488"), A_1.Areas[0]).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("2cb02ec1-8fe5-47e4-b70d-7ec51ec10020"), A_1.Areas[0]).ao() as c5x;
			if (c5x3 != null && c5x3.GetAspect<axh>() == null)
			{
				axh axh = new axh(c5x3);
				axh.a("sgs_l5_cam1");
				axh.a(true);
				c5x3.SetAspect<axh>(axh);
			}
			if (c5x4 != null && c5x4.GetAspect<axh>() == null)
			{
				axh axh2 = new axh(c5x4);
				axh2.a("sgs_l5_cam2");
				axh2.a(true);
				c5x4.SetAspect<axh>(axh2);
			}
			if (c5x != null)
			{
				dt5 aspect = c5x.GetAspect<dt5>();
				if (aspect != null)
				{
					aspect.g().Clear();
					aspect.g().Add("sgs_l5_cam1");
					aspect.b();
					aspect.h();
				}
			}
			if (c5x2 != null)
			{
				dt5 aspect2 = c5x2.GetAspect<dt5>();
				if (aspect2 != null)
				{
					aspect2.g().Clear();
					aspect2.g().Add("sgs_l5_cam2");
					aspect2.b();
					aspect2.h();
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
