using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010FC RID: 4348
[eiz("U01")]
[Serializable]
public sealed class eaq : cze, ISerializable
{
	// Token: 0x06005C2F RID: 23599 RVA: 0x002776DC File Offset: 0x002758DC
	private eaq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("U01:S");
		this.b = A_0.GetString("U01:T");
		this.c = (h)A_0.GetValue("U01:A", typeof(h));
		this.d = (A_0.GetValue("U01:U", typeof(h?)) as h?);
		this.e = A_0.GetBoolean("U01:V");
		this.f = A_0.GetBoolean("U01:D");
		this.g = A_0.GetBoolean("U01:C");
	}

	// Token: 0x06005C30 RID: 23600 RVA: 0x0027778C File Offset: 0x0027598C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("U01:S", this.a);
		info.AddValue("U01:T", this.b);
		info.AddValue("U01:A", this.c);
		info.AddValue("U01:U", this.d);
		info.AddValue("U01:V", this.e);
		info.AddValue("U01:D", this.f);
		info.AddValue("U01:C", this.g);
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x00277824 File Offset: 0x00275A24
	public string g()
	{
		return this.a;
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x0027782C File Offset: 0x00275A2C
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005C33 RID: 23603 RVA: 0x00277838 File Offset: 0x00275A38
	public string e()
	{
		return this.b;
	}

	// Token: 0x06005C34 RID: 23604 RVA: 0x00277840 File Offset: 0x00275A40
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005C35 RID: 23605 RVA: 0x0027784C File Offset: 0x00275A4C
	public h f()
	{
		return this.c;
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x00277854 File Offset: 0x00275A54
	public void a(h A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x00277860 File Offset: 0x00275A60
	public h? c()
	{
		return this.d;
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x00277868 File Offset: 0x00275A68
	public void a(h? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005C39 RID: 23609 RVA: 0x00277874 File Offset: 0x00275A74
	public bool a()
	{
		return this.e;
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x0027787C File Offset: 0x00275A7C
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x00277888 File Offset: 0x00275A88
	public bool b()
	{
		return this.f;
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x00277890 File Offset: 0x00275A90
	public void b(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005C3D RID: 23613 RVA: 0x0027789C File Offset: 0x00275A9C
	public bool d()
	{
		return this.g;
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x002778A4 File Offset: 0x00275AA4
	public void c(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x002778B0 File Offset: 0x00275AB0
	public eaq()
	{
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x002778BC File Offset: 0x00275ABC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (!string.IsNullOrEmpty(this.a) && !string.IsNullOrEmpty(this.b))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				(serviceOrThrow.aqu().ac() as bv9).a(this.a, this.b, this.c, this.d, this.e, this.f, this.g);
			}
		}
	}

	// Token: 0x040024CE RID: 9422
	private new string a;

	// Token: 0x040024CF RID: 9423
	private string b;

	// Token: 0x040024D0 RID: 9424
	private h c;

	// Token: 0x040024D1 RID: 9425
	private h? d;

	// Token: 0x040024D2 RID: 9426
	private bool e;

	// Token: 0x040024D3 RID: 9427
	private bool f;

	// Token: 0x040024D4 RID: 9428
	private bool g;
}
