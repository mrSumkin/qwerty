using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B0E RID: 2830
[eiz("XPBLSCCBCASLJ")]
[Serializable]
public sealed class b3x : cze, ISerializable
{
	// Token: 0x0600417A RID: 16762 RVA: 0x00191428 File Offset: 0x0018F628
	private b3x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x00191434 File Offset: 0x0018F634
	public b3x()
	{
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x00191440 File Offset: 0x0018F640
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null && bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			c7j c7j = A_1.GetAspect<bim>() as c7j;
			if (c7j != null)
			{
				alv aspect = A_1.GetAspect<alv>();
				if (Enumerable.Any<coh>(c7j.ItemContainer.z2()))
				{
					if (aspect != null)
					{
						aspect.a[1].c = new Color?(new Color(223, 0, 73, 255));
						return;
					}
				}
				else if (aspect != null)
				{
					aspect.a[1].c = new Color?(new Color(50, 170, 150, 255));
				}
			}
		}
	}
}
