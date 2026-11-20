using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001061 RID: 4193
[eiz("SWEATJ")]
[Serializable]
public sealed class dfn : cze, ISerializable
{
	// Token: 0x06005713 RID: 22291 RVA: 0x00261AF0 File Offset: 0x0025FCF0
	private dfn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SWEATJ:B");
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x00261B0C File Offset: 0x0025FD0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SWEATJ:B", this.a);
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x00261B28 File Offset: 0x0025FD28
	public string a()
	{
		return this.a;
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x00261B30 File Offset: 0x0025FD30
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x00261B3C File Offset: 0x0025FD3C
	public dfn()
	{
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x00261B48 File Offset: 0x0025FD48
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.Area != null && c5x.Zone != null)
			{
				vq.a(this.a, c5x.Zone, new bt4(c5x.Area.y8(), c5x.Location), false);
			}
		}
	}

	// Token: 0x04002346 RID: 9030
	private new string a;
}
