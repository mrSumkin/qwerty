using System;
using System.Runtime.Serialization;

// Token: 0x020019D0 RID: 6608
[eiz("PFACMME")]
[Serializable]
public sealed class ol : cdh, ISerializable, d7s
{
	// Token: 0x06008DA1 RID: 36257 RVA: 0x00393D48 File Offset: 0x00391F48
	private ol(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("PFACMME:M");
	}

	// Token: 0x06008DA2 RID: 36258 RVA: 0x00393D64 File Offset: 0x00391F64
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PFACMME:M", this.a);
	}

	// Token: 0x06008DA3 RID: 36259 RVA: 0x00393D80 File Offset: 0x00391F80
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x00393D88 File Offset: 0x00391F88
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x00393D94 File Offset: 0x00391F94
	public override bool ae5()
	{
		return this.a > 0;
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x00393DA0 File Offset: 0x00391FA0
	public ol()
	{
	}

	// Token: 0x06008DA7 RID: 36263 RVA: 0x00393DA8 File Offset: 0x00391FA8
	public override string b2()
	{
		if (this.a < 0)
		{
			return string.Format("Стоимость очков действия Избиения уменьшена на {0}", Math.Abs(this.a));
		}
		return string.Format("Стоимость очков действия Избиения увеличена на {0}", this.a);
	}

	// Token: 0x06008DA8 RID: 36264 RVA: 0x00393DEC File Offset: 0x00391FEC
	public override d3e b3()
	{
		ol ol = new ol();
		this.xx(ol);
		return ol;
	}

	// Token: 0x06008DA9 RID: 36265 RVA: 0x00393E08 File Offset: 0x00392008
	public void cn(d3e A_0)
	{
		ol ol = A_0 as ol;
		if (ol != null)
		{
			this.a += ol.a;
		}
	}

	// Token: 0x06008DAA RID: 36266 RVA: 0x00393E38 File Offset: 0x00392038
	public bool co(d3e A_0)
	{
		return A_0 is ol;
	}

	// Token: 0x06008DAB RID: 36267 RVA: 0x00393E44 File Offset: 0x00392044
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ol)A_0).a = this.a;
	}

	// Token: 0x040037C1 RID: 14273
	private new int a;
}
