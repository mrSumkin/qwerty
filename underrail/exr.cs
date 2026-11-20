using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000946 RID: 2374
[eiz("XPBLLESFR")]
[Serializable]
public sealed class exr : bdw, ISerializable
{
	// Token: 0x06003A0F RID: 14863 RVA: 0x0015788C File Offset: 0x00155A8C
	private exr(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A10 RID: 14864 RVA: 0x00157894 File Offset: 0x00155A94
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A11 RID: 14865 RVA: 0x00157898 File Offset: 0x00155A98
	public exr()
	{
	}

	// Token: 0x06003A12 RID: 14866 RVA: 0x001578A4 File Offset: 0x00155AA4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_fu");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "xpbl_fu_l5") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
		}
	}
}
