using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010FF RID: 4351
[eiz("S45")]
[Serializable]
public sealed class b16 : cze, ISerializable
{
	// Token: 0x06005C4C RID: 23628 RVA: 0x00277AE8 File Offset: 0x00275CE8
	private b16(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S44:S", typeof(int?)) as int?);
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x00277B18 File Offset: 0x00275D18
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S44:S", this.a);
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x00277B38 File Offset: 0x00275D38
	public int? a()
	{
		return this.a;
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x00277B40 File Offset: 0x00275D40
	public void a(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C50 RID: 23632 RVA: 0x00277B4C File Offset: 0x00275D4C
	public b16()
	{
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x00277B54 File Offset: 0x00275D54
	public b16(int? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x00277B68 File Offset: 0x00275D68
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aq = this.a;
		}
	}

	// Token: 0x040024D7 RID: 9431
	private new int? a;
}
