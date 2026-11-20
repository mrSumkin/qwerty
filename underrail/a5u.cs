using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001089 RID: 4233
[eiz("RCX7")]
[Serializable]
public sealed class a5u : cze, ISerializable
{
	// Token: 0x06005849 RID: 22601 RVA: 0x002656AC File Offset: 0x002638AC
	private a5u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600584A RID: 22602 RVA: 0x002656B8 File Offset: 0x002638B8
	public a5u()
	{
	}

	// Token: 0x0600584B RID: 22603 RVA: 0x002656C4 File Offset: 0x002638C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			d16 aspect = c5x.GetAspect<d16>();
			if (aspect != null)
			{
				aspect.b();
			}
		}
	}
}
