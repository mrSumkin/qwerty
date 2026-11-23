using System;
using System.Runtime.Serialization;

// Token: 0x020009FA RID: 2554
[eiz("XPBLPIRMTMASP")]
[Serializable]
public sealed class dl7 : bdw, ISerializable
{
	// Token: 0x06003CF5 RID: 15605 RVA: 0x0016A0EC File Offset: 0x001682EC
	private dl7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x0016A0F4 File Offset: 0x001682F4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x0016A0F8 File Offset: 0x001682F8
	public dl7()
	{
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x0016A104 File Offset: 0x00168304
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_f2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("a816709f-5ec4-4bf9-ba21-c44bf5ac12a7"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("69d63d5a-904d-49b8-9812-9230aa4e8c17"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("44fb1294-77fe-4fb3-a93f-23aa8d11bff2"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.an();
				}
				if (c5x2 != null)
				{
					c5x2.an();
				}
				if (c5x3 != null)
				{
					c5x3.an();
				}
				gx gx = new gx();
				gx.a(new csd("spawnPirate1"), new int?(15), "Pirates", null, null, null, "support\\xpbl\\pir_main1", false, null, false);
				gx.a(new csd("spawnPirate2"), new int?(15), "Pirates", null, null, null, "support\\xpbl\\pir_main1", false, null, false);
			}
		}
	}
}
