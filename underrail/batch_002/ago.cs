using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000B1D RID: 2845
[eiz("XPBLMCGA")]
[Serializable]
public sealed class ago : cze, ISerializable
{
	// Token: 0x060041B8 RID: 16824 RVA: 0x00195780 File Offset: 0x00193980
	private ago(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041B9 RID: 16825 RVA: 0x0019578C File Offset: 0x0019398C
	public ago()
	{
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x00195798 File Offset: 0x00193998
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c1a c1a = serviceOrThrow.aqw();
				c5x c5x2 = new ar7(new Guid("eabde184-521e-4f9e-a163-22b091837252"), c1a.n("xpbl_mc1_west")).ao() as c5x;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_firstGateRevealed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_firstGateRevealed_set", new bool?(false)).Value)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_mc1_l" + 4.ToString()) + ".uzl");
					c1a.a(a_, 1, null);
					serviceOrThrow.aqu().r()["loc_xpbl_mc_firstGateRevealed_set"] = true;
				}
				if (c5x2 != null)
				{
					cj4 cj = c5x2.GetAspect<bbw>() as cj4;
					if (cj != null && cj.s8() == (double)cj.s6() && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_gateMansGate_opened", new bool?(false)).Value)
					{
						awh awh = new awh();
						awh.b(c5x.Area.y8());
						awh.b(new Guid("e30c1475-4b75-4149-947e-be8b3fb808bf"));
						awh.a(new Guid("b3c5b9f5-e987-48c3-8d6e-71a608977a3b"));
						awh.a(bbo.b);
						awh.ym(A_0, A_1, null);
						c5x2.t.b.y6().RemoveProperty(ddq.w);
						serviceOrThrow.aqu().r()["loc_xpbl_mc_gateMansGate_opened"] = true;
					}
					if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_gateMansGate_opened", new bool?(false)).Value && c5x2.t.b != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_mc_gateman_follow", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_mc_gateman_setAutoDialog", new bool?(false)).Value)
					{
						dtb dtb = new dtb();
						ekk ekk = new ekk();
						ekk.a(c5x2.Area.y8());
						ekk.a(new Guid?(c5x2.qe()));
						ekk.a()[ddq.bc] = "npc_xpbl_mc_gateman_follow";
						dtb.ad().Add(new bm3(1000));
						dtb.ad().Add(new a4s(ekk, null, null, null));
						c1a.ActionManager.g9(dtb, atp.a);
						serviceOrThrow.aqu().r()["npc_xpbl_mc_gateman_setAutoDialog"] = true;
					}
				}
			}
		}
	}
}
