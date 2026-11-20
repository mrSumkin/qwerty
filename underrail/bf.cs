using System;
using System.Runtime.Serialization;

// Token: 0x020009D7 RID: 2519
[eiz("RCDR")]
[Serializable]
public sealed class bf : bdw, ISerializable
{
	// Token: 0x06003C57 RID: 15447 RVA: 0x00165BC8 File Offset: 0x00163DC8
	private bf(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x00165BD0 File Offset: 0x00163DD0
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x00165BD4 File Offset: 0x00163DD4
	public bf()
	{
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x00165BE0 File Offset: 0x00163DE0
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				foreach (b0b b0b in aud.Entities)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.h.b != null && c5x.h.b.aa().b(d8o.e) && !c5x.h.b.aa().Passive)
					{
						if (c5x.t.b != null)
						{
							new bzv(c5x.t.b.y6()).e();
						}
						c5x.h.b.aa().FactionId = asp.a3;
						clt a_ = new clt(0);
						c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
					}
				}
			}
		}
	}
}
