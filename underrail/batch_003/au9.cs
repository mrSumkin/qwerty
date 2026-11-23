using System;
using System.Runtime.Serialization;

// Token: 0x020019DF RID: 6623
[eiz("TKAPCFM")]
[Serializable]
public sealed class au9 : cdh, ISerializable, d7s
{
	// Token: 0x06008E41 RID: 36417 RVA: 0x00394F14 File Offset: 0x00393114
	private au9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("TKAPCFM:M");
	}

	// Token: 0x06008E42 RID: 36418 RVA: 0x00394F30 File Offset: 0x00393130
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TKAPCFM:M", this.a);
	}

	// Token: 0x06008E43 RID: 36419 RVA: 0x00394F4C File Offset: 0x0039314C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06008E44 RID: 36420 RVA: 0x00394F54 File Offset: 0x00393154
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008E45 RID: 36421 RVA: 0x00394F60 File Offset: 0x00393160
	public override bool ae5()
	{
		return this.a > 0;
	}

	// Token: 0x06008E46 RID: 36422 RVA: 0x00394F6C File Offset: 0x0039316C
	public au9()
	{
	}

	// Token: 0x06008E47 RID: 36423 RVA: 0x00394F74 File Offset: 0x00393174
	public override string b2()
	{
		if (this.a < 0)
		{
			return string.Format("Стоимость очков действия при метании ножей уменьшена на {0}.", Math.Abs(this.a));
		}
		return string.Format("Стоимость очков действия при метании ножей увеличена на {0}.", this.a);
	}

	// Token: 0x06008E48 RID: 36424 RVA: 0x00394FB4 File Offset: 0x003931B4
	public override d3e b3()
	{
		au9 au = new au9();
		this.xx(au);
		return au;
	}

	// Token: 0x06008E49 RID: 36425 RVA: 0x00394FD0 File Offset: 0x003931D0
	public void cn(d3e A_0)
	{
		au9 au = A_0 as au9;
		if (au != null)
		{
			this.a += au.a;
		}
	}

	// Token: 0x06008E4A RID: 36426 RVA: 0x00395000 File Offset: 0x00393200
	public bool co(d3e A_0)
	{
		return A_0 is au9;
	}

	// Token: 0x06008E4B RID: 36427 RVA: 0x0039500C File Offset: 0x0039320C
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((au9)A_0).a = this.a;
	}

	// Token: 0x040037D2 RID: 14290
	private new int a;
}
