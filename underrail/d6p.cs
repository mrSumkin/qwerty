using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AC6 RID: 2758
[eiz("XPHWEBDSJ")]
[Serializable]
public sealed class d6p : cze, ISerializable
{
	// Token: 0x0600403F RID: 16447 RVA: 0x00187008 File Offset: 0x00185208
	private d6p(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<string>("XPHWEBDSJ:WN", ref this.a, A_0);
		this.b = A_0.GetBoolean("XPHWEBDSJ:SPC");
		this.c = A_0.GetBoolean("XPHWEBDSJ:SHI");
		this.f = A_0.GetBoolean("XPHWEBDSJ:STS");
		this.d = A_0.GetSingle("XPHWEBDSJ:BIV");
		this.e = A_0.GetSingle("XPHWEBDSJ:MIV");
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x001870A4 File Offset: 0x001852A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<string>("XPHWEBDSJ:WN", this.a, info);
		info.AddValue("XPHWEBDSJ:SPC", this.b);
		info.AddValue("XPHWEBDSJ:SHI", this.c);
		info.AddValue("XPHWEBDSJ:STS", this.f);
		info.AddValue("XPHWEBDSJ:BIV", this.d);
		info.AddValue("XPHWEBDSJ:MIV", this.e);
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x00187120 File Offset: 0x00185320
	public List<string> c()
	{
		return this.a;
	}

	// Token: 0x06004042 RID: 16450 RVA: 0x00187128 File Offset: 0x00185328
	public void a(List<string> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004043 RID: 16451 RVA: 0x00187134 File Offset: 0x00185334
	public bool e()
	{
		return this.b;
	}

	// Token: 0x06004044 RID: 16452 RVA: 0x0018713C File Offset: 0x0018533C
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004045 RID: 16453 RVA: 0x00187148 File Offset: 0x00185348
	public bool a()
	{
		return this.c;
	}

	// Token: 0x06004046 RID: 16454 RVA: 0x00187150 File Offset: 0x00185350
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06004047 RID: 16455 RVA: 0x0018715C File Offset: 0x0018535C
	public bool f()
	{
		return this.f;
	}

	// Token: 0x06004048 RID: 16456 RVA: 0x00187164 File Offset: 0x00185364
	public void c(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x06004049 RID: 16457 RVA: 0x00187170 File Offset: 0x00185370
	public float b()
	{
		return this.d;
	}

	// Token: 0x0600404A RID: 16458 RVA: 0x00187178 File Offset: 0x00185378
	public void a(float A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600404B RID: 16459 RVA: 0x00187184 File Offset: 0x00185384
	public float d()
	{
		return this.e;
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x0018718C File Offset: 0x0018538C
	public void b(float A_0)
	{
		this.e = A_0;
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x00187198 File Offset: 0x00185398
	public d6p()
	{
	}

	// Token: 0x0600404E RID: 16462 RVA: 0x001871C4 File Offset: 0x001853C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			List<csd> list = new List<csd>();
			foreach (string a_ in this.a)
			{
				list.Add(serviceOrThrow.aqw().g(a_));
			}
			if (Enumerable.Any<csd>(list))
			{
				dqp.a(list, false, this.b, this.c, this.d, this.e, this.f, null);
			}
		}
	}

	// Token: 0x04001BEC RID: 7148
	private new List<string> a = new List<string>();

	// Token: 0x04001BED RID: 7149
	private bool b;

	// Token: 0x04001BEE RID: 7150
	private bool c;

	// Token: 0x04001BEF RID: 7151
	private float d = 0.5f;

	// Token: 0x04001BF0 RID: 7152
	private float e = 0.5f;

	// Token: 0x04001BF1 RID: 7153
	private bool f;
}
