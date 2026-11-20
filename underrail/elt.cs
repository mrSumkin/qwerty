using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010FA RID: 4346
[eiz("B68")]
[Serializable]
public sealed class elt : cze, ISerializable
{
	// Token: 0x06005C21 RID: 23585 RVA: 0x002773E0 File Offset: 0x002755E0
	private elt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("B68:E", typeof(ar7)) as ar7);
	}

	// Token: 0x06005C22 RID: 23586 RVA: 0x0027740C File Offset: 0x0027560C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("B68:E", this.a);
	}

	// Token: 0x06005C23 RID: 23587 RVA: 0x00277428 File Offset: 0x00275628
	public elt(ar7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C24 RID: 23588 RVA: 0x00277438 File Offset: 0x00275638
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.a != null)
		{
			c5x c5x = this.a.ao() as c5x;
			if (c5x != null && c5x.o.b != null)
			{
				c5x.o.b.b = new Point(cuo.a.Next(3), 0);
			}
		}
	}

	// Token: 0x040024CA RID: 9418
	private new ar7 a;
}
