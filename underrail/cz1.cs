using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B04 RID: 2820
[eiz("XPBLCCPZDSPCFJ")]
[Serializable]
public sealed class cz1 : cze, ISerializable
{
	// Token: 0x06004150 RID: 16720 RVA: 0x0018F694 File Offset: 0x0018D894
	private cz1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004151 RID: 16721 RVA: 0x0018F6A0 File Offset: 0x0018D8A0
	public cz1()
	{
	}

	// Token: 0x06004152 RID: 16722 RVA: 0x0018F6AC File Offset: 0x0018D8AC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		gx gx = new gx();
		if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cc_pz2_wipedOut", new bool?(false)).Value)
		{
			List<cze> list = new List<cze>();
			x6 x = new x6();
			x.a(true);
			x.a(1);
			x.a("faction_protectorate_coreCity_jetSkiersKilled");
			list.Add(x);
			List<cze> a_ = list;
			c5x c5x = gx.a(serviceOrThrow.aqw().g("spawnCruiser1"), new int?(15), "Protectorate_Jetski", null, asp.bg, null, "support\\xpbl\\pr_jetPatrols1", false, a_, false);
			c5x c5x2 = gx.a(serviceOrThrow.aqw().g("spawnCruiser2"), new int?(15), "Protectorate_Jetski", null, asp.bg, null, "support\\xpbl\\pr_jetPatrols1", false, a_, false);
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4("guardCruiser1");
			}
			if (c5x2 != null && c5x2.t.b != null)
			{
				c5x2.t.b.y6()[ddq.ay] = new bt4("guardCruiser2");
			}
		}
	}
}
