using System;
using System.Runtime.Serialization;

// Token: 0x020019B5 RID: 6581
[eiz("MSSARAME")]
[Serializable]
public sealed class bz5 : cdh, ISerializable, d7s
{
	// Token: 0x06008CB9 RID: 36025 RVA: 0x00391BD0 File Offset: 0x0038FDD0
	private bz5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("MSSARAME:M");
	}

	// Token: 0x06008CBA RID: 36026 RVA: 0x00391BEC File Offset: 0x0038FDEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSSARAME:M", this.a);
	}

	// Token: 0x06008CBB RID: 36027 RVA: 0x00391C08 File Offset: 0x0038FE08
	public double a()
	{
		return this.a;
	}

	// Token: 0x06008CBC RID: 36028 RVA: 0x00391C10 File Offset: 0x0038FE10
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008CBD RID: 36029 RVA: 0x00391C1C File Offset: 0x0038FE1C
	public override bool ae5()
	{
		return this.a < 0.0;
	}

	// Token: 0x06008CBE RID: 36030 RVA: 0x00391C30 File Offset: 0x0038FE30
	public bz5()
	{
	}

	// Token: 0x06008CBF RID: 36031 RVA: 0x00391C38 File Offset: 0x0038FE38
	public bz5(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008CC0 RID: 36032 RVA: 0x00391C48 File Offset: 0x0038FE48
	public override string b2()
	{
		if (this.a < 0.0)
		{
			return string.Format("Уменьшает количество очков действия, восстанавливаемых Весёлой стрельбой, на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
		}
		return string.Format("Увеличивает количество очков действия, восстанавливаемых Весёлой стрельбой, на {0}%.", Convert.ToInt32(Math.Abs(this.a) * 100.0));
	}

	// Token: 0x06008CC1 RID: 36033 RVA: 0x00391CBC File Offset: 0x0038FEBC
	public override d3e b3()
	{
		bz5 bz = new bz5();
		this.xx(bz);
		return bz;
	}

	// Token: 0x06008CC2 RID: 36034 RVA: 0x00391CD8 File Offset: 0x0038FED8
	public void cn(d3e A_0)
	{
		bz5 bz = A_0 as bz5;
		if (bz != null)
		{
			this.a += bz.a;
		}
	}

	// Token: 0x06008CC3 RID: 36035 RVA: 0x00391D08 File Offset: 0x0038FF08
	public bool co(d3e A_0)
	{
		return A_0 is bz5;
	}

	// Token: 0x06008CC4 RID: 36036 RVA: 0x00391D14 File Offset: 0x0038FF14
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((bz5)A_0).a = this.a;
	}

	// Token: 0x040037A7 RID: 14247
	private new double a;
}
