using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02002162 RID: 8546
[bmq("1.1.0.12_L2_SubmarineFix", "1.1.0.12", "xpbl_l2", false)]
public sealed class ezi : fg
{
	// Token: 0x0600C910 RID: 51472 RVA: 0x00470900 File Offset: 0x0046EB00
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_towedSubmarine", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_as_arrived", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("npc_xpbl_ferryman_towedSubmarine_arrived", new bool?(false)).Value)
			{
				foreach (aud aud in A_1.Areas)
				{
					using (List<b0b>.Enumerator enumerator2 = aud.Entities.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (((c5x)enumerator2.Current).GetAspect<bdf>() is atg)
							{
								return true;
							}
						}
					}
				}
				csd csd = A_1.g("TowSubmarine");
				csd csd2 = A_1.g("ExitSubmarine");
				if (csd != null && (csd2 == null || (csd2 != null && csd2.Location != csd.Location - new Vector3(1f, 0f, 0f))))
				{
					c5x c5x = vq.a("Object\\Vehicles\\Xpbl\\LemurianSubmarine", csd, false);
					if (c5x != null)
					{
						if (c5x.y8() != null && c5x.y8() != "Submarine")
						{
							c5x.q("Submarine");
						}
						A_0.r()["vehicle_xpbl_submarine_exitZoneName"] = A_1.y8();
						A_0.r()["vehicle_xpbl_submarine_exitZoneId"] = A_1.qe();
						A_0.r()["vehicle_xpbl_submarine_exitAreaId"] = A_1.n("xpbl_l2").qe();
						new csd("ExitSubmarine");
						csd.Location -= new Vector3(1f, 0f, 0f);
						csd.Direction = HorizontalDirection.West;
						csd.AreaName = A_1.n("xpbl_l2").y8();
						csd.Layer = 1;
						A_1.a(csd);
						A_0.r()["npc_xpbl_ferryman_towedSubmarine_arrived"] = true;
					}
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
