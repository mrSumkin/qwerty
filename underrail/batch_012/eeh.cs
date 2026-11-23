using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ouroboros.Playfield.Space;

// Token: 0x02002199 RID: 8601
[bmq("1.0.1.5_Up3xTrapDoor", "1.0.1.5", "up3x", false)]
public sealed class eeh : fg
{
	// Token: 0x0600C986 RID: 51590 RVA: 0x0047409C File Offset: 0x0047229C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("15492910-dbca-444d-8255-02f775772f97"), A_1.n("up3x")).ao() as c5x;
			if (c5x != null)
			{
				b4h aspect = c5x.GetAspect<b4h>();
				if (aspect != null && aspect.h() != "потайной люк")
				{
					aspect.a("потайной люк");
					aspect.a(1.0);
				}
				bim aspect2 = c5x.GetAspect<bim>();
				if (aspect2 != null && aspect2.s().Count <= 1)
				{
					aspect2.a(new List<HorizontalDirection>
					{
						HorizontalDirection.East
					});
					List<cze> list = aspect2.s();
					bfq bfq = new bfq();
					bfq.a(bvl.c);
					bfq.b("open_close");
					bfq.c("MetalTrapDoorOpen");
					bfq.a(c9z.a);
					bfq.a(true);
					bfq.a(1f);
					list.Add(bfq);
					List<cze> list2 = aspect2.s();
					bfq bfq2 = new bfq();
					bfq2.a(bvl.a);
					bfq2.b("open_close");
					bfq2.a("up3xu");
					bfq2.a(new Guid?(new Guid("16d7357e-9ee3-41a5-a6f3-67aafafbc852")));
					bfq2.c("MetalTrapDoorOpen");
					bfq2.a(c9z.a);
					bfq2.a(true);
					bfq2.a(1f);
					list2.Add(bfq2);
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
