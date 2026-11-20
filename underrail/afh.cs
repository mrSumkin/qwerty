using System;
using System.Diagnostics;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200215D RID: 8541
[bmq("1.1.0.15_TchortModifiersFix", "1.1.0.15", "dc-tchb", false)]
public sealed class afh : fg
{
	// Token: 0x0600C906 RID: 51462 RVA: 0x00470214 File Offset: 0x0046E414
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			foreach (b0b b0b in A_1.n("dc-tchb").Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.y8() == "Tchort" && c5x.h.b != null && !c5x.IsPlayer)
				{
					c5x.h.b.aa().AttributesBase |= d8o.m;
					c5x.h.b.aa().ImmunitiesBase |= CharacterImmunities.Unbalancing;
					c5x.h.b.aa().ImmunitiesBase |= CharacterImmunities.Decapitation;
					c5x.h.b.aa().ImmunitiesBase |= CharacterImmunities.Bilocation;
					c5x.h.b.aa().bl();
					break;
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
