using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200099E RID: 2462
[eiz("LUPCCIFDB")]
[Serializable]
public sealed class duq : bdw, ISerializable
{
	// Token: 0x06003B74 RID: 15220 RVA: 0x0015FFB0 File Offset: 0x0015E1B0
	private duq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B75 RID: 15221 RVA: 0x0015FFB8 File Offset: 0x0015E1B8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B76 RID: 15222 RVA: 0x0015FFBC File Offset: 0x0015E1BC
	public duq()
	{
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x0015FFC8 File Offset: 0x0015E1C8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_1 != null && A_0 != null)
		{
			aud aud = A_0.n("lup_freeDroneBase");
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (aud != null && serviceOrThrow != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_fd_Bate_dead", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_revealSpyCompleted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_clearedCorpses", new bool?(false)).Value)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (!string.IsNullOrEmpty(c5x.y8()) && c5x.h.b == null && c5x.s.b is c7j && (c5x.y8().EndsWith("- тело") || c5x.y8() == "Останки"))
					{
						c5x.w();
						c5x.an();
					}
				}
				serviceOrThrow.aqu().r()["quest_fd_clearedCorpses"] = true;
			}
		}
	}
}
