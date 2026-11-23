using System;
using System.Runtime.Serialization;

// Token: 0x020019CE RID: 6606
[eiz("CFATFB")]
[Serializable]
public sealed class ezn : cdh, ISerializable, d7s
{
	// Token: 0x06008D8D RID: 36237 RVA: 0x003938A0 File Offset: 0x00391AA0
	private ezn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("CFATFB:C");
	}

	// Token: 0x06008D8E RID: 36238 RVA: 0x003938BC File Offset: 0x00391ABC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CFATFB:C", this.a);
	}

	// Token: 0x06008D8F RID: 36239 RVA: 0x003938D8 File Offset: 0x00391AD8
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x003938E0 File Offset: 0x00391AE0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008D91 RID: 36241 RVA: 0x003938EC File Offset: 0x00391AEC
	public override bool ae5()
	{
		return false;
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x003938F0 File Offset: 0x00391AF0
	public ezn()
	{
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x003938F8 File Offset: 0x00391AF8
	public ezn(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008D94 RID: 36244 RVA: 0x0039390C File Offset: 0x00391B0C
	public override string b2()
	{
		if (this.a < 1.0)
		{
			return string.Format("Когда срабатывает Вкус крови, есть {0}% шанс, что он даст дополнительную единицу эффекта.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return "Когда срабатывает Вкус крови, он даёт дополнительную единицу эффекта.";
	}

	// Token: 0x06008D95 RID: 36245 RVA: 0x0039395C File Offset: 0x00391B5C
	public override d3e b3()
	{
		ezn ezn = new ezn();
		this.xx(ezn);
		return ezn;
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x00393978 File Offset: 0x00391B78
	public void cn(d3e A_0)
	{
		ezn ezn = A_0 as ezn;
		if (ezn != null)
		{
			this.a = d05.b(0.0, this.a + ezn.a, 1.0);
		}
	}

	// Token: 0x06008D97 RID: 36247 RVA: 0x003939BC File Offset: 0x00391BBC
	public bool co(d3e A_0)
	{
		return A_0 is ezn;
	}

	// Token: 0x06008D98 RID: 36248 RVA: 0x003939C8 File Offset: 0x00391BC8
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ezn)A_0).a = this.a;
	}

	// Token: 0x040037BB RID: 14267
	private new double a;
}
