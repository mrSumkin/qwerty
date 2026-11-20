using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F0 RID: 4336
[eiz("XI")]
[Serializable]
public sealed class clv : cze, ISerializable
{
	// Token: 0x06005BD0 RID: 23504 RVA: 0x00276210 File Offset: 0x00274410
	private clv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XI:E");
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x0027622C File Offset: 0x0027442C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XI:E", this.a);
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x00276248 File Offset: 0x00274448
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x00276250 File Offset: 0x00274450
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x0027625C File Offset: 0x0027445C
	public clv()
	{
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x00276264 File Offset: 0x00274464
	public clv(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x00276278 File Offset: 0x00274478
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.t.b != null)
		{
			c5x.t.b.a(this.a);
		}
	}

	// Token: 0x040024B0 RID: 9392
	private new bool a;
}
