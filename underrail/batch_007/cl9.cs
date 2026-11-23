using System;
using System.Runtime.Serialization;

// Token: 0x020019F4 RID: 6644
[eiz("NOCAME")]
[Serializable]
public sealed class cl9 : cdh, ISerializable, d7s
{
	// Token: 0x06008F14 RID: 36628 RVA: 0x00397100 File Offset: 0x00395300
	private cl9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("NOCAME:D");
		this.b = A_0.GetDouble("NOCAME:V");
	}

	// Token: 0x06008F15 RID: 36629 RVA: 0x00397150 File Offset: 0x00395350
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("NOCAME:D", this.a);
		info.AddValue("NOCAME:V", this.b);
	}

	// Token: 0x06008F16 RID: 36630 RVA: 0x0039717C File Offset: 0x0039537C
	public double a()
	{
		return this.b;
	}

	// Token: 0x06008F17 RID: 36631 RVA: 0x00397184 File Offset: 0x00395384
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008F18 RID: 36632 RVA: 0x00397190 File Offset: 0x00395390
	public int b()
	{
		return this.a;
	}

	// Token: 0x06008F19 RID: 36633 RVA: 0x00397198 File Offset: 0x00395398
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008F1A RID: 36634 RVA: 0x003971A4 File Offset: 0x003953A4
	public cl9()
	{
	}

	// Token: 0x06008F1B RID: 36635 RVA: 0x003971C4 File Offset: 0x003953C4
	public override string b2()
	{
		return string.Format("Пси-способность Невральная перегрузка наносит дополнительно {0}% от первоначального урона в течение {1}, в виде кислотного урона неподдающегося сопротивлению.", Convert.ToInt32(this.b * 100.0), l4.a(this.a, false));
	}

	// Token: 0x06008F1C RID: 36636 RVA: 0x003971F8 File Offset: 0x003953F8
	public override d3e b3()
	{
		cl9 cl = new cl9();
		this.xx(cl);
		return cl;
	}

	// Token: 0x06008F1D RID: 36637 RVA: 0x00397214 File Offset: 0x00395414
	public void cn(d3e A_0)
	{
		cl9 cl = A_0 as cl9;
		if (cl != null)
		{
			this.b += cl.b;
			this.a = Math.Max(this.a, cl.a);
		}
	}

	// Token: 0x06008F1E RID: 36638 RVA: 0x00397258 File Offset: 0x00395458
	public bool co(d3e A_0)
	{
		return A_0 is cl9;
	}

	// Token: 0x06008F1F RID: 36639 RVA: 0x00397264 File Offset: 0x00395464
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		cl9 cl = (cl9)A_0;
		cl.b = this.b;
		cl.a = this.a;
	}

	// Token: 0x040037E9 RID: 14313
	private new int a = 3;

	// Token: 0x040037EA RID: 14314
	private double b = 0.25;
}
