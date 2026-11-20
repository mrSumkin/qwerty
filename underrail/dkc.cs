using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200093B RID: 2363
[eiz("XPBLFTS")]
[Serializable]
public sealed class dkc : bdw, ISerializable
{
	// Token: 0x060039E2 RID: 14818 RVA: 0x00156514 File Offset: 0x00154714
	private dkc(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x0015651C File Offset: 0x0015471C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039E4 RID: 14820 RVA: 0x00156520 File Offset: 0x00154720
	public dkc()
	{
	}

	// Token: 0x060039E5 RID: 14821 RVA: 0x0015652C File Offset: 0x0015472C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.Areas[0];
		if (aud != null)
		{
			if (aud.y8() == "xpbl_l12")
			{
				using (List<b0b>.Enumerator enumerator = Enumerable.ToList<b0b>(aud.Entities).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						b0b b0b = enumerator.Current;
						c5x c5x = (c5x)b0b;
						if (c5x.GetAspect<bdf>() is atg)
						{
							c5x.w();
							c5x.an();
						}
					}
					return;
				}
			}
			csd csd = A_0.g("TowSubmarine");
			if (csd != null)
			{
				c5x c5x2 = vq.a("Object\\Vehicles\\Xpbl\\LemurianSubmarine", csd, false);
				if (c5x2 != null)
				{
					if (c5x2.y8() != null && c5x2.y8() != "Submarine")
					{
						c5x2.q("Submarine");
					}
					A_1.r()["vehicle_xpbl_submarine_exitZoneName"] = A_0.y8();
					A_1.r()["vehicle_xpbl_submarine_exitZoneId"] = A_0.qe();
					A_1.r()["vehicle_xpbl_submarine_exitAreaId"] = aud.qe();
					new csd("ExitSubmarine");
					csd.Location -= new Vector3(1f, 0f, 0f);
					csd.Direction = HorizontalDirection.West;
					csd.AreaName = aud.y8();
					csd.Layer = 1;
					A_0.a(csd);
					A_1.r()["npc_xpbl_ferryman_towedSubmarine_arrived"] = true;
				}
			}
		}
	}
}
