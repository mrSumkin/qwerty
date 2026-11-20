using System;
using System.Runtime.Serialization;

// Token: 0x02000924 RID: 2340
[eiz("CCOTC")]
[Serializable]
public sealed class dm7 : bdw, ISerializable
{
	// Token: 0x0600397F RID: 14719 RVA: 0x00153A7C File Offset: 0x00151C7C
	private dm7(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003980 RID: 14720 RVA: 0x00153A84 File Offset: 0x00151C84
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x00153A88 File Offset: 0x00151C88
	public dm7()
	{
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x00153A94 File Offset: 0x00151C94
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc_tm3");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("e5eb62cf-34f5-4aa7-89b6-e32fada5deb2"), aud).ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "guard_vlatkoLivingRoom", true);
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						aspect.y6()[ddq.ay] = new bt4("guard_vlatkoLivingRoom");
					}
				}
			}
		}
	}
}
