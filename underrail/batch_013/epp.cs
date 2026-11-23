using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020020F7 RID: 8439
[bmq("1.1.4.0_Tch_Util3_MindCrackerRemovalAndTweaks", "1.1.4.0", "tch-util3", false)]
public sealed class epp : fg
{
	// Token: 0x0600C842 RID: 51266 RVA: 0x0046993C File Offset: 0x00467B3C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("d491d7df-925a-4b1e-a751-e83509ac89fa"), A_1.n("tch-util3")).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
			c5x c5x2 = new ar7(new Guid("0857c814-67b9-4b6e-8a74-0a5822b9dd88"), A_1.n("tch-util3")).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.Location = new Vector3(26.5f, 36.2f, 1f);
			}
			foreach (c5x c5x3 in new List<c5x>
			{
				new ar7(new Guid("efd60aa4-5e83-47a0-be70-b55e397ccb56"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("800ef221-8f27-462d-9b67-7feb649edc6b"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("6fd05aaa-6bd8-4508-868a-af358092ad35"), A_1.n("tch-util3")).ao() as c5x
			})
			{
				if (c5x3 != null && c5x3.h.b != null)
				{
					c5x3.h.b.aa().FactionId = asp.et;
					c5x3.h.b.aa().HostilityBroadcastMode = c2n.c;
					bn5 bn = c5x3.GetAspect<j7>() as bn5;
					if (bn == null)
					{
						bn = new bn5(c5x3);
						c5x3.SetAspect<j7>(bn);
					}
					bn.b("support\\tch_util3_inv");
					bn.a(true);
					bn.b(true);
					bn.a("speaker");
				}
			}
			foreach (c5x c5x4 in new List<c5x>
			{
				new ar7(new Guid("d0a8d8f2-36f1-46b5-919f-40a174b9e1f3"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("7e4eac47-adb7-47a8-9c3d-80ce50645102"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("795635bb-5077-4043-a2f1-8f0b34ffacb2"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("10a0378f-9076-47e4-b4c6-36eb5f87cb89"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("deb8d93b-bc22-4804-91d6-9b699903ed4d"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("35f02ee7-42a3-42cd-bbc9-1383adeb49da"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("e6cd7723-3d12-420a-95eb-9a7deee4d005"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("2d3ebf60-2807-494b-aa19-c837c1b51874"), A_1.n("tch-util3")).ao() as c5x,
				new ar7(new Guid("60d2dfc7-f872-47af-bf36-74dda1fd5269"), A_1.n("tch-util3")).ao() as c5x
			})
			{
				if (c5x4 != null)
				{
					c3g c3g = c5x4.GetAspect<c3g>();
					if (c3g == null)
					{
						c3g = new c3g(c5x4);
						c5x4.SetAspect<c3g>(c3g);
					}
					c3g.d().Add(asp.es);
					c3g.d().Add(asp.et);
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
