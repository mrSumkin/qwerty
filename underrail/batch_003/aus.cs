using System;
using System.Runtime.Serialization;

// Token: 0x0200091B RID: 2331
[eiz("CCRPFED2")]
[Serializable]
public sealed class aus : bdw, ISerializable
{
	// Token: 0x0600395B RID: 14683 RVA: 0x0015350C File Offset: 0x0015170C
	private aus(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x00153514 File Offset: 0x00151714
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x00153518 File Offset: 0x00151718
	public aus()
	{
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x00153524 File Offset: 0x00151724
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc21");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("393da416-28cc-43c1-a1c8-6e96398761e9"), aud).ao() as c5x;
				if (c5x != null)
				{
					c5x.RemoveAspect<c3g>();
				}
			}
		}
	}
}
