using System;
using System.Diagnostics;

// Token: 0x020020ED RID: 8429
[bmq("1.1.5.10_Dc_Mut2_NervosomniferPlacement", "1.1.5.10", "dc-mut2", false)]
public sealed class e34 : fg
{
	// Token: 0x0600C830 RID: 51248 RVA: 0x00469034 File Offset: 0x00467234
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("4cadf6d1-f5ca-4b36-8017-0e6723cdafec"), A_1.n("dc-mut2")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null && c7j.ItemContainer.z2().a("blueprint.nervosomnifer", 1).Count < 1)
				{
					c7j.ItemContainer.z3(new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\nervosomnifer")), true);
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
