using System;
using System.Runtime.Serialization;

// Token: 0x020009B5 RID: 2485
[eiz("LUHRMJ")]
[Serializable]
public sealed class cg9 : bdw, ISerializable
{
	// Token: 0x06003BD0 RID: 15312 RVA: 0x00161EDC File Offset: 0x001600DC
	private cg9(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BD1 RID: 15313 RVA: 0x00161EE4 File Offset: 0x001600E4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BD2 RID: 15314 RVA: 0x00161EE8 File Offset: 0x001600E8
	public cg9()
	{
	}

	// Token: 0x06003BD3 RID: 15315 RVA: 0x00161EF4 File Offset: 0x001600F4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			aud aud = A_0.n("lux-b11");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("2b696b3c-8dca-4d6e-ab33-8283cf60c8b6"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.w();
					c5x.an();
					serviceOrThrow.aqu().a(new bw0("dc-tw", new avv(), 1));
					serviceOrThrow.aqu().r()["npc_lu_depressedMan_JumpedOverFence"] = true;
				}
			}
		}
	}
}
