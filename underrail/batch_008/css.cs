using System;
using System.Runtime.Serialization;

// Token: 0x02000949 RID: 2377
[eiz("XPBLLETOFL")]
[Serializable]
public sealed class css : bdw, ISerializable
{
	// Token: 0x06003A1B RID: 14875 RVA: 0x00157AAC File Offset: 0x00155CAC
	private css(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A1C RID: 14876 RVA: 0x00157AB4 File Offset: 0x00155CB4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x00157AB8 File Offset: 0x00155CB8
	public css()
	{
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x00157AC4 File Offset: 0x00155CC4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("xpbl_e6");
			if (aud != null && bpo.GetServiceOrThrow<cnk>() != null)
			{
				axh aspect = new ar7(new Guid("e111427e-43c9-4642-84fd-51c69915eae0"), aud).ao().GetAspect<axh>();
				if (aspect != null)
				{
					aspect.a(null, false, null);
				}
			}
		}
	}
}
