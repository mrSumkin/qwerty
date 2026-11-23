using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000A66 RID: 2662
[eiz("LURPHW")]
[Serializable]
public sealed class cvy : cze, ISerializable
{
	// Token: 0x06003EE1 RID: 16097 RVA: 0x0017C06C File Offset: 0x0017A26C
	private cvy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x0017C078 File Offset: 0x0017A278
	public cvy()
	{
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x0017C084 File Offset: 0x0017A284
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				aud aud = c5x.Area;
				HorizontalDirection horizontalDirection = c5x.VisualDirection;
				if (aud != null && A_0 != null && horizontalDirection != HorizontalDirection.East)
				{
					TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("faction_jy_pr_remindPlayerToHolsterWeapons", null);
					if (primitivePropertyValue == null)
					{
						serviceOrThrow.aqu().r()["faction_jy_pr_remindPlayerToHolsterWeapons"] = serviceOrThrow.aqu().p();
					}
					c5x c5x2 = new ar7(new Guid("243dfee7-3933-48f7-81e1-f03f333924d7"), aud).ao() as c5x;
					if (c5x2 != null && c5x2.h.b != null && aw1.a(c5x2, new bt4("guard_guard1"), true) && c5x2.h.b.a(c5x.h.b) != h.a && !c5x.h.b.aa().SpecialStates.g && primitivePropertyValue != null && serviceOrThrow.aqu().p() >= primitivePropertyValue)
					{
						c5x2.u.b.a("Не забудьте убрать всё оружие и другие потенциально опасные предметы прежде чем войти в посольство.", false, null, null);
						serviceOrThrow.aqu().r()["faction_jy_pr_remindPlayerToHolsterWeapons"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(15.0);
					}
				}
			}
		}
	}
}
