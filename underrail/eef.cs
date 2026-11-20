using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000923 RID: 2339
[eiz("CCCC22")]
[Serializable]
public sealed class eef : bdw, ISerializable
{
	// Token: 0x0600397B RID: 14715 RVA: 0x001539D4 File Offset: 0x00151BD4
	private eef(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600397C RID: 14716 RVA: 0x001539DC File Offset: 0x00151BDC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600397D RID: 14717 RVA: 0x001539E0 File Offset: 0x00151BE0
	public eef()
	{
	}

	// Token: 0x0600397E RID: 14718 RVA: 0x001539E8 File Offset: 0x00151BE8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc22");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("05901cd5-648a-4a25-918b-42a0b0adfea1")).ao();
				d2b d2b2 = new EntityAspectReference<d2b, d2b>(aud, new Guid("e006d08d-f702-4f58-b786-704e7766d3c0")).ao();
				if (d2b != null && d2b2 != null)
				{
					bool value = A_1.r().GetPrimitivePropertyValue<bool>("loc_tm_sideEntranceUnlocked", new bool?(false)).Value;
					d2b.e(!value);
					d2b2.e(!value);
				}
			}
		}
	}
}
