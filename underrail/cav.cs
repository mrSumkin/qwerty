using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010E9 RID: 4329
[eiz("SSSJ")]
[Serializable]
public sealed class cav : cze, ISerializable
{
	// Token: 0x06005B79 RID: 23417 RVA: 0x00274B4C File Offset: 0x00272D4C
	private cav(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("SSSJ:D");
		this.b = (A_0.GetValue("SSSJ:LX", typeof(int?)) as int?);
		this.c = (A_0.GetValue("SSSJ:UX", typeof(int?)) as int?);
		this.d = (A_0.GetValue("SSSJ:LY", typeof(int?)) as int?);
		this.e = (A_0.GetValue("SSSJ:UY", typeof(int?)) as int?);
		this.f = (A_0.GetValue("SSSJ:S", typeof(int?)) as int?);
	}

	// Token: 0x06005B7A RID: 23418 RVA: 0x00274C2C File Offset: 0x00272E2C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSSJ:D", this.a);
		info.AddValue("SSSJ:LX", this.b);
		info.AddValue("SSSJ:UX", this.c);
		info.AddValue("SSSJ:LY", this.d);
		info.AddValue("SSSJ:UY", this.e);
		info.AddValue("SSSJ:S", this.f);
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x00274CC0 File Offset: 0x00272EC0
	public int f()
	{
		return this.a;
	}

	// Token: 0x06005B7C RID: 23420 RVA: 0x00274CC8 File Offset: 0x00272EC8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B7D RID: 23421 RVA: 0x00274CD4 File Offset: 0x00272ED4
	public int? c()
	{
		return this.b;
	}

	// Token: 0x06005B7E RID: 23422 RVA: 0x00274CDC File Offset: 0x00272EDC
	public void d(int? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B7F RID: 23423 RVA: 0x00274CE8 File Offset: 0x00272EE8
	public int? d()
	{
		return this.c;
	}

	// Token: 0x06005B80 RID: 23424 RVA: 0x00274CF0 File Offset: 0x00272EF0
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B81 RID: 23425 RVA: 0x00274CFC File Offset: 0x00272EFC
	public int? b()
	{
		return this.d;
	}

	// Token: 0x06005B82 RID: 23426 RVA: 0x00274D04 File Offset: 0x00272F04
	public void c(int? A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06005B83 RID: 23427 RVA: 0x00274D10 File Offset: 0x00272F10
	public int? e()
	{
		return this.e;
	}

	// Token: 0x06005B84 RID: 23428 RVA: 0x00274D18 File Offset: 0x00272F18
	public void e(int? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06005B85 RID: 23429 RVA: 0x00274D24 File Offset: 0x00272F24
	public int? a()
	{
		return this.f;
	}

	// Token: 0x06005B86 RID: 23430 RVA: 0x00274D2C File Offset: 0x00272F2C
	public void b(int? A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06005B87 RID: 23431 RVA: 0x00274D38 File Offset: 0x00272F38
	public cav()
	{
	}

	// Token: 0x06005B88 RID: 23432 RVA: 0x00274D44 File Offset: 0x00272F44
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.ane(this.a, this.b, this.c, this.d, this.e, this.f);
		}
	}

	// Token: 0x04002489 RID: 9353
	private new int a;

	// Token: 0x0400248A RID: 9354
	private int? b;

	// Token: 0x0400248B RID: 9355
	private int? c;

	// Token: 0x0400248C RID: 9356
	private int? d;

	// Token: 0x0400248D RID: 9357
	private int? e;

	// Token: 0x0400248E RID: 9358
	private int? f;
}
