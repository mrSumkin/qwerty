using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020008F3 RID: 2291
[eiz("SGSSHE")]
[Serializable]
public sealed class e2j : bdw, ISerializable
{
	// Token: 0x060038BB RID: 14523 RVA: 0x00150920 File Offset: 0x0014EB20
	private e2j(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038BC RID: 14524 RVA: 0x00150928 File Offset: 0x0014EB28
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038BD RID: 14525 RVA: 0x0015092C File Offset: 0x0014EB2C
	public e2j()
	{
	}

	// Token: 0x060038BE RID: 14526 RVA: 0x00150938 File Offset: 0x0014EB38
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lup-a1");
			if (aud != null)
			{
				string classPropertyValue = A_1.r().GetClassPropertyValue<string>("quest_sgs_dun_investigateUnderPassages_ordnanceReceived");
				if (classPropertyValue != null)
				{
					if (classPropertyValue == "full")
					{
						doq a_ = doq.a(Path.Combine(d5x.q(), "lup-a1_l4") + ".uzl");
						aud.Zone.a(a_, 1, null);
						c5x c5x = new ar7(new Guid("2a005f99-2366-46c2-8fcc-ceb11844b337"), aud).ao() as c5x;
						if (c5x != null)
						{
							c5x.w();
							c5x.an();
						}
					}
					doq a_2 = doq.a(Path.Combine(d5x.q(), "lup-a1_l3") + ".uzl");
					aud.Zone.a(a_2, 1, null);
				}
				A_1.r()["npc_sgs_harland_shouldCommentOnEquipment"] = true;
			}
		}
	}
}
