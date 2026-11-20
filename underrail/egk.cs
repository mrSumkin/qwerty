using System;
using System.Runtime.Serialization;

// Token: 0x020009CF RID: 2511
[eiz("RKLDBSH")]
[Serializable]
public sealed class egk : bdw, ISerializable
{
	// Token: 0x06003C37 RID: 15415 RVA: 0x00163C84 File Offset: 0x00161E84
	private egk(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x00163C8C File Offset: 0x00161E8C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x00163C90 File Offset: 0x00161E90
	public egk()
	{
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x00163C9C File Offset: 0x00161E9C
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("rkl2");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("47d3dc37-3dbc-4514-9404-56ceebd19983"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("ce0c147a-b0af-42ff-99f9-4d1c155bb665"), aud).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("3b4d720f-fc94-4e6e-adc5-8fae9df44ced"), aud).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("e9f507ab-09ef-49bf-9652-acb3c41730eb"), aud).ao() as c5x;
				if (c5x != null)
				{
					uk uk = new uk();
					uk.c(true);
					uk.ym(null, c5x, null);
				}
				if (c5x2 != null)
				{
					uk uk2 = new uk();
					uk2.c(true);
					uk2.ym(null, c5x2, null);
				}
				if (c5x3 != null)
				{
					uk uk3 = new uk();
					uk3.c(true);
					uk3.ym(null, c5x3, null);
				}
				if (c5x4 != null)
				{
					uk uk4 = new uk();
					uk4.c(true);
					uk4.ym(null, c5x4, null);
				}
			}
		}
	}
}
