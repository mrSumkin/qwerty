using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x02002196 RID: 8598
[bmq("1.0.1.5_Tch_Che_Wardrobe", "1.0.1.5", "tch-labche", false)]
public sealed class ccb : fg
{
	// Token: 0x0600C980 RID: 51584 RVA: 0x00473D0C File Offset: 0x00471F0C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("f06f8046-4d64-425e-ac38-0760b9b91b7f"), A_1.n("tch-labche")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("ea129330-7b1c-43b9-aafb-9d755faebba5"), A_1.n("tch-labche")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("812e4b0c-e2e8-4679-808d-74d5234777e3"), A_1.n("tch-labche")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("2184cdd9-946f-4e48-b664-df4eaaac0aac"), A_1.n("tch-labche")).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("72709463-12b3-4d1c-a650-c129f1e4740a"), A_1.n("tch-labche")).ao() as c5x;
			if (c5x != null)
			{
				c7j c7j = c5x.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					c7j.t().Clear();
					c7j.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x2 != null)
			{
				c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
				if (c7j2 != null)
				{
					c7j2.t().Clear();
					c7j2.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x3 != null)
			{
				c7j c7j3 = c5x3.GetAspect<bim>() as c7j;
				if (c7j3 != null)
				{
					c7j3.t().Clear();
					c7j3.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x4 != null)
			{
				c7j c7j4 = c5x4.GetAspect<bim>() as c7j;
				if (c7j4 != null)
				{
					c7j4.t().Clear();
					c7j4.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
				}
			}
			if (c5x5 != null)
			{
				c7j c7j5 = c5x5.GetAspect<bim>() as c7j;
				if (c7j5 != null)
				{
					c7j5.t().Clear();
					c7j5.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
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
