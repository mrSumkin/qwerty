using System;
using System.Runtime.Serialization;

// Token: 0x02000957 RID: 2391
[eiz("XPBLRC1DD")]
[Serializable]
public sealed class aky : bdw, ISerializable
{
	// Token: 0x06003A56 RID: 14934 RVA: 0x0015A084 File Offset: 0x00158284
	private aky(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x0015A08C File Offset: 0x0015828C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x0015A090 File Offset: 0x00158290
	public aky()
	{
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x0015A09C File Offset: 0x0015829C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("rc1");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("1c8023b0-3cf3-48cd-86b7-00dc38fd8090"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
			if (c5x2 != null && c5x2.t.b != null)
			{
				c5x2.t.b.y6()[ddq.bc] = "npc_rc_barkeeper_bill_talked";
			}
		}
	}
}
