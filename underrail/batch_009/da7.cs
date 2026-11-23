using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200099A RID: 2458
[eiz("FOREQ")]
[Serializable]
public sealed class da7 : bdw, ISerializable
{
	// Token: 0x06003B64 RID: 15204 RVA: 0x0015FC28 File Offset: 0x0015DE28
	private da7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B65 RID: 15205 RVA: 0x0015FC30 File Offset: 0x0015DE30
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x0015FC34 File Offset: 0x0015DE34
	public da7()
	{
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x0015FC3C File Offset: 0x0015DE3C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("fo3_roof");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("26a61009-9e36-4a29-8321-7cf29024b520"), aud).ao() as c5x;
			if (c5x != null)
			{
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.ay] = new bt4("watcher_guard");
				}
			}
			cnb cnb = new EntityAspectReference<cnb, bim>(aud, new Guid("d276a99b-5a17-471c-bdf9-f51ce3154a3d")).ao();
			if (cnb != null && cnb.q())
			{
				cnb.d(false);
			}
			serviceOrThrow.aqu().r()["npc_fo_mysteriousMan_allowedEntry"] = false;
		}
	}
}
