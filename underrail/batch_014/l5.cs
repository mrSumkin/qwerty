using System;
using System.Runtime.Serialization;

// Token: 0x02001A31 RID: 6705
[eiz("M52")]
[Serializable]
public sealed class l5 : d3e, d7s, ISerializable
{
	// Token: 0x0600913D RID: 37181 RVA: 0x0039C7D4 File Offset: 0x0039A9D4
	private l5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("M52:A");
	}

	// Token: 0x0600913E RID: 37182 RVA: 0x0039C7F0 File Offset: 0x0039A9F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M52:A", this.a);
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x0600913F RID: 37183 RVA: 0x0039C80C File Offset: 0x0039AA0C
	// (set) Token: 0x06009140 RID: 37184 RVA: 0x0039C814 File Offset: 0x0039AA14
	public double Modifier
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06009141 RID: 37185 RVA: 0x0039C820 File Offset: 0x0039AA20
	public override bool Negative
	{
		get
		{
			return this.a > 0.0;
		}
	}

	// Token: 0x06009142 RID: 37186 RVA: 0x0039C834 File Offset: 0x0039AA34
	public l5()
	{
	}

	// Token: 0x06009143 RID: 37187 RVA: 0x0039C83C File Offset: 0x0039AA3C
	public l5(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06009144 RID: 37188 RVA: 0x0039C84C File Offset: 0x0039AA4C
	protected override void @in(ll A_0)
	{
		nw nw = A_0.a().Defense;
		nw.f(nw.w() + this.a);
	}

	// Token: 0x06009145 RID: 37189 RVA: 0x0039C878 File Offset: 0x0039AA78
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((l5)A_0).a = this.a;
	}

	// Token: 0x06009146 RID: 37190 RVA: 0x0039C894 File Offset: 0x0039AA94
	public void cn(d3e A_0)
	{
		l5 l = A_0 as l5;
		if (l != null)
		{
			this.a += l.a;
		}
	}

	// Token: 0x06009147 RID: 37191 RVA: 0x0039C8C4 File Offset: 0x0039AAC4
	public bool co(d3e A_0)
	{
		l5 l = A_0 as l5;
		return l != null && l.Condition == base.Condition;
	}

	// Token: 0x06009148 RID: 37192 RVA: 0x0039C8F0 File Offset: 0x0039AAF0
	public override string b2()
	{
		if (this.a > 0.0)
		{
			return string.Format("Шанс получить критический урон от оружия и рукопашных атак увеличен на {0}%", (this.a * 100.0).ToString("0.00"));
		}
		return string.Format("Шанс получить критический урон от оружия и рукопашных атак уменьшен на {0}%", (Math.Abs(this.a) * 100.0).ToString("0.00"));
	}

	// Token: 0x06009149 RID: 37193 RVA: 0x0039C968 File Offset: 0x0039AB68
	public override d3e b3()
	{
		l5 l = new l5();
		this.xx(l);
		return l;
	}

	// Token: 0x04003824 RID: 14372
	private new double a;
}
