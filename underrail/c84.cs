using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200094F RID: 2383
[eiz("DCASDS")]
[Serializable]
public sealed class c84 : bdw, ISerializable
{
	// Token: 0x06003A33 RID: 14899 RVA: 0x00158324 File Offset: 0x00156524
	private c84(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003A34 RID: 14900 RVA: 0x0015832C File Offset: 0x0015652C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003A35 RID: 14901 RVA: 0x00158330 File Offset: 0x00156530
	public c84()
	{
	}

	// Token: 0x06003A36 RID: 14902 RVA: 0x0015833C File Offset: 0x0015653C
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			foreach (aud aud in A_0.Areas)
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.GetAspect<axh>() != null && (c5x.GetAspect<axh>().h() == "dc-pp_ama_securityPower" || c5x.GetAspect<axh>().h() == "dc-pp_m_securityPower"))
					{
						c5x.GetAspect<axh>().a(null, false, null);
					}
				}
			}
		}
	}
}
