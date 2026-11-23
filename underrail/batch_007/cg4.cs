using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000B9E RID: 2974
[eiz("XPBLCIPSFIM")]
[Serializable]
public sealed class cg4 : cze, ISerializable
{
	// Token: 0x060043A1 RID: 17313 RVA: 0x001A8D58 File Offset: 0x001A6F58
	private cg4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060043A2 RID: 17314 RVA: 0x001A8D64 File Offset: 0x001A6F64
	public cg4()
	{
	}

	// Token: 0x060043A3 RID: 17315 RVA: 0x001A8D70 File Offset: 0x001A6F70
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_oldfield_shouldFollowDownManhole", new bool?(false)).Value)
			{
				bv9 bv = serviceOrThrow.aqu().ac() as bv9;
				cky cky = bv.abu(asp.a, asp.f8);
				d2b aspect = new ar7(new Guid("f88cda55-daf3-4ae5-b081-cfeba11168ff"), aud).ao().GetAspect<d2b>();
				if (cky.a != h.a && (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_e3_attackedPiratesDuringInterrogation", new bool?(false)).Value || (aspect != null && !aspect.n())))
				{
					using (List<b0b>.Enumerator enumerator = Enumerable.ToList<b0b>(aud.Entities).GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							c5x c5x = (c5x)enumerator.Current;
							if (c5x == null || c5x.h.b == null || !c5x.h.b.aa().FactionId.Contains("pirate"))
							{
								serviceOrThrow.aqu().r()["npc_xpbl_oldfield_shouldFollowDownManhole"] = true;
								bv.a(asp.fr, asp.a, h.a, null, true, false, false);
								bv.a(asp.fv, asp.a, h.a, null, true, false, false);
								bv.a(asp.ft, asp.a, h.a, null, true, false, false);
								bv.a(asp.fr, asp.f8, h.a, null, true, false, false);
								bv.a(asp.fr, asp.f6, h.a, null, true, false, false);
								bv.a(asp.fr, asp.f5, h.a, null, true, false, false);
							}
						}
					}
				}
			}
		}
	}
}
