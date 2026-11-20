using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AD5 RID: 2773
[eiz("XPBLKLDJ")]
[Serializable]
public sealed class eu1 : cze, ISerializable
{
	// Token: 0x060040AD RID: 16557 RVA: 0x00189C78 File Offset: 0x00187E78
	private eu1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x00189C84 File Offset: 0x00187E84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x00189C90 File Offset: 0x00187E90
	public eu1()
	{
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x00189C98 File Offset: 0x00187E98
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_xpbl_kirill_dead"] = true;
			if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_allied", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_kirillHunters_betrayed", new bool?(false)).Value)
			{
				serviceOrThrow.aqu().r()["loc_xpbl_mutieHuntersVictory"] = true;
			}
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && serviceOrThrow.aqw().y8().StartsWith("xpbl_kirillLab", StringComparison.OrdinalIgnoreCase) && c5x.Zone.a() != null)
			{
				c5x c5x2 = new ar7(new Guid("9600112e-daa5-453d-b9bc-2b45a76e2982"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("6901d7bc-787b-4ddf-8e50-5d20204b4eb0"), c5x.Area).ao() as c5x;
				if (c5x2 != null && c5x3 != null && c5x2.s != null)
				{
					c5x2.s.b.g(true);
					c5x2.o.b.b = new Point(0, 1);
					c5x3.o.b.b = new Point(1, 1);
				}
				awx awx = new awx();
				awx awx2 = awx;
				awx2.a(awx2.kh() | m7.b);
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				awx.ad().Add(new a4s(new bi7(false), new ar7(c5x), null, null));
				awx.ad().Add(new bm3(cuo.a.Next(3100, 4000)));
				c5x.Zone.ActionManager.g9(awx, atp.a);
			}
		}
	}
}
