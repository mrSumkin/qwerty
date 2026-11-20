using System;
using System.Runtime.Serialization;

// Token: 0x020008E5 RID: 2277
[eiz("CCS1UTD")]
[Serializable]
public sealed class dlv : bdw, ISerializable
{
	// Token: 0x06003880 RID: 14464 RVA: 0x0014EE90 File Offset: 0x0014D090
	private dlv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x0014EE98 File Offset: 0x0014D098
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003882 RID: 14466 RVA: 0x0014EE9C File Offset: 0x0014D09C
	public dlv()
	{
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x0014EEA8 File Offset: 0x0014D0A8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_s1u");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("30df3487-83f8-47ce-8168-232ebc6203d5"), aud).ao() as c5x;
				if (c5x != null)
				{
					if (!A_1.r().GetPrimitivePropertyValue<bool>("npc_cc_tchortistInvestigatorDead", new bool?(false)).Value)
					{
						new be6
						{
							DestinationWaypoint = "corpseLocation",
							OverrideTargetId = new Guid?(c5x.qe()),
							OverrideTargetArea = aud.y8()
						}.ym(c5x, null, null);
					}
					nb nb = new nb();
					nb.a(bvl.e);
					nb.a(new Guid?(c5x.qe()));
					nb.a(false);
					nb.ym(c5x, null, null);
					A_1.r()["npc_cc_tchortistInvestigatorDead"] = true;
				}
			}
		}
	}
}
