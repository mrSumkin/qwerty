using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010A0 RID: 4256
[eiz("HJ")]
[Serializable]
public sealed class d5u : cze, ISerializable
{
	// Token: 0x06005937 RID: 22839 RVA: 0x00269C40 File Offset: 0x00267E40
	private d5u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("HJ:A");
		this.b = A_0.GetBoolean("HJ:E");
		this.c = A_0.GetBoolean("HJ:M");
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x00269C90 File Offset: 0x00267E90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HJ:A", this.a);
		info.AddValue("HJ:E", this.b);
		info.AddValue("HJ:M", this.c);
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x00269CD8 File Offset: 0x00267ED8
	public int b()
	{
		return this.a;
	}

	// Token: 0x0600593A RID: 22842 RVA: 0x00269CE0 File Offset: 0x00267EE0
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600593B RID: 22843 RVA: 0x00269CEC File Offset: 0x00267EEC
	public bool c()
	{
		return this.b;
	}

	// Token: 0x0600593C RID: 22844 RVA: 0x00269CF4 File Offset: 0x00267EF4
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x00269D00 File Offset: 0x00267F00
	public bool a()
	{
		return this.c;
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x00269D08 File Offset: 0x00267F08
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x00269D14 File Offset: 0x00267F14
	public d5u()
	{
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x00269D28 File Offset: 0x00267F28
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().Defense.a(this.a, c5x.h.b.aa(), null, this.b, this.c, false, null);
		}
	}

	// Token: 0x040023E2 RID: 9186
	private new int a;

	// Token: 0x040023E3 RID: 9187
	private bool b = true;

	// Token: 0x040023E4 RID: 9188
	private bool c;
}
