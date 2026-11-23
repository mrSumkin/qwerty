using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02001352 RID: 4946
[eiz("S21")]
[Serializable]
public sealed class bxp : b1z, ISerializable
{
	// Token: 0x06006FF0 RID: 28656 RVA: 0x002EFB74 File Offset: 0x002EDD74
	private bxp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("S21:E", typeof(ar7)) as ar7);
		this.b = (HorizontalDirection)A_0.GetValue("S21:D", typeof(HorizontalDirection));
	}

	// Token: 0x06006FF1 RID: 28657 RVA: 0x002EFBCC File Offset: 0x002EDDCC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S21:E", this.a);
		info.AddValue("S21:D", this.b);
	}

	// Token: 0x06006FF2 RID: 28658 RVA: 0x002EFC00 File Offset: 0x002EDE00
	public ar7 a()
	{
		return this.a;
	}

	// Token: 0x06006FF3 RID: 28659 RVA: 0x002EFC08 File Offset: 0x002EDE08
	public void a(ar7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006FF4 RID: 28660 RVA: 0x002EFC14 File Offset: 0x002EDE14
	public HorizontalDirection b()
	{
		return this.b;
	}

	// Token: 0x06006FF5 RID: 28661 RVA: 0x002EFC1C File Offset: 0x002EDE1C
	public void a(HorizontalDirection A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006FF6 RID: 28662 RVA: 0x002EFC28 File Offset: 0x002EDE28
	public bxp()
	{
	}

	// Token: 0x06006FF7 RID: 28663 RVA: 0x002EFC30 File Offset: 0x002EDE30
	public bxp(b0b A_0, HorizontalDirection A_1)
	{
		this.a = new ar7(A_0);
		this.b = A_1;
	}

	// Token: 0x06006FF8 RID: 28664 RVA: 0x002EFC4C File Offset: 0x002EDE4C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null)
		{
			this.a.ao().VisualDirection = this.b;
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002DBE RID: 11710
	private new ar7 a;

	// Token: 0x04002DBF RID: 11711
	private HorizontalDirection b;
}
