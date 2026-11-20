using System;
using System.Runtime.Serialization;

// Token: 0x02000918 RID: 2328
[eiz("CCRTFSS")]
[Serializable]
public sealed class eqd : bdw, ISerializable
{
	// Token: 0x0600394F RID: 14671 RVA: 0x00153248 File Offset: 0x00151448
	private eqd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x00153250 File Offset: 0x00151450
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x00153254 File Offset: 0x00151454
	public eqd()
	{
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x00153260 File Offset: 0x00151460
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && A_1 != null && A_1.r().GetPrimitivePropertyValue<bool>("global_leftResearchFacilityAfterCubeSnatch", new bool?(true)).Value)
		{
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"tchortist"
				}))
				{
					b0b.w();
					b0b.an();
				}
			}
		}
	}
}
