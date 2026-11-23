using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A7E RID: 2686
[eiz("TCHDRAV")]
[Serializable]
public sealed class cil : cze, ISerializable
{
	// Token: 0x06003F39 RID: 16185 RVA: 0x0017ED00 File Offset: 0x0017CF00
	private cil(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x0017ED0C File Offset: 0x0017CF0C
	public cil()
	{
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x0017ED18 File Offset: 0x0017CF18
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_tch_rejectLeader_toldThemToLeaveByVents", new bool?(false)).Value;
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_tch_rejectsEscaped", new int?(0)).Value;
			if (value)
			{
				c5x c5x = A_0 as c5x;
				if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId == asp.ev)
				{
					c5x c5x2 = new ar7(new Guid("f7307b7f-6c39-4c20-83b8-8026c2764b1b"), A_0.Area).ao() as c5x;
					if (c5x2 != null)
					{
						dbm dbm = c5x2.s.b as dbm;
						if (dbm != null && !dbm.m())
						{
							dbm.e();
						}
					}
					num++;
					serviceOrThrow.aqu().r()["loc_tch_rejectsEscaped"] = num;
					if (c5x.i.b != null)
					{
						c5x.i.b.a(true, false);
						qy qy = new qy();
						qy.b(false);
						qy.c(false);
						List<auv> list = qy.ad();
						a4s a4s = new a4s(new uk(), null, null, null);
						a4s.b(new ar7(c5x));
						list.Add(a4s);
						c5x.Zone.ActionManager.g9(qy, atp.a);
					}
				}
			}
		}
	}
}
