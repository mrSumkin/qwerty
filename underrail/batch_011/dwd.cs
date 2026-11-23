using System;
using System.Runtime.Serialization;

// Token: 0x020019EF RID: 6639
[eiz("PBAMME")]
[Serializable]
public sealed class dwd : cdh, ISerializable, d7s
{
	// Token: 0x06008ED7 RID: 36567 RVA: 0x003968F0 File Offset: 0x00394AF0
	private dwd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("PBAMME:M");
	}

	// Token: 0x06008ED8 RID: 36568 RVA: 0x0039690C File Offset: 0x00394B0C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PBAMME:M", this.a);
	}

	// Token: 0x06008ED9 RID: 36569 RVA: 0x00396928 File Offset: 0x00394B28
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008EDA RID: 36570 RVA: 0x00396930 File Offset: 0x00394B30
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008EDB RID: 36571 RVA: 0x0039693C File Offset: 0x00394B3C
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008EDC RID: 36572 RVA: 0x00396950 File Offset: 0x00394B50
	public dwd()
	{
	}

	// Token: 0x06008EDD RID: 36573 RVA: 0x00396958 File Offset: 0x00394B58
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Количество урона блокируемое Парированием уменьшено на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Количество урона блокируемое Парированием увеличено на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008EDE RID: 36574 RVA: 0x003969CC File Offset: 0x00394BCC
	public override d3e b3()
	{
		dwd dwd = new dwd();
		this.xx(dwd);
		return dwd;
	}

	// Token: 0x06008EDF RID: 36575 RVA: 0x003969E8 File Offset: 0x00394BE8
	public void cn(d3e A_0)
	{
		dwd dwd = A_0 as dwd;
		if (dwd != null)
		{
			this.a += dwd.a;
		}
	}

	// Token: 0x06008EE0 RID: 36576 RVA: 0x00396A18 File Offset: 0x00394C18
	public bool co(d3e A_0)
	{
		return A_0 is dwd;
	}

	// Token: 0x06008EE1 RID: 36577 RVA: 0x00396A24 File Offset: 0x00394C24
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((dwd)A_0).a = this.a;
	}

	// Token: 0x040037E2 RID: 14306
	private new double a;
}
