using System;
using System.Runtime.Serialization;

// Token: 0x0200093D RID: 2365
[eiz("XPBLESS")]
[Serializable]
public sealed class av7 : bdw, ISerializable
{
	// Token: 0x060039EA RID: 14826 RVA: 0x0015679C File Offset: 0x0015499C
	private av7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x001567A4 File Offset: 0x001549A4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039EC RID: 14828 RVA: 0x001567A8 File Offset: 0x001549A8
	public av7()
	{
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x001567B4 File Offset: 0x001549B4
	public void av(c1a A_0, cyt A_1)
	{
		foreach (aud aud in A_0.Areas)
		{
			foreach (b0b b0b in aud.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == aju.x)
				{
					amc aspect = c5x.GetAspect<amc>();
					if (aspect != null && aspect.aa().FactionId == asp.fx && aspect.aa().Feats.Contains<c3v>())
					{
						bv0 a_ = new bv0(0);
						aspect.aa().StatusEffects.a(a_, false, false, false);
					}
				}
			}
		}
	}
}
