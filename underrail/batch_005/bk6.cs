using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010CD RID: 4301
[eiz("DPJ")]
[Serializable]
public class bk6 : cze, ISerializable
{
	// Token: 0x06005A9A RID: 23194 RVA: 0x00271664 File Offset: 0x0026F864
	protected bk6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("DPJ:E", typeof(c5x)) as c5x);
		this.b = (A_0.GetValue("DPJ:A", typeof(e6z)) as e6z);
	}

	// Token: 0x06005A9B RID: 23195 RVA: 0x002716BC File Offset: 0x0026F8BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DPJ:E", this.a);
		info.AddValue("DPJ:A", this.b);
	}

	// Token: 0x06005A9C RID: 23196 RVA: 0x002716E8 File Offset: 0x0026F8E8
	public c5x a()
	{
		return this.a;
	}

	// Token: 0x06005A9D RID: 23197 RVA: 0x002716F0 File Offset: 0x0026F8F0
	public void a(c5x A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A9E RID: 23198 RVA: 0x002716FC File Offset: 0x0026F8FC
	public e6z b()
	{
		return this.b;
	}

	// Token: 0x06005A9F RID: 23199 RVA: 0x00271704 File Offset: 0x0026F904
	public void a(e6z A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005AA0 RID: 23200 RVA: 0x00271710 File Offset: 0x0026F910
	public bk6()
	{
	}

	// Token: 0x06005AA1 RID: 23201 RVA: 0x00271718 File Offset: 0x0026F918
	public bk6(e6z A_0, c5x A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06005AA2 RID: 23202 RVA: 0x00271730 File Offset: 0x0026F930
	public bk6(aud A_0, c5x A_1)
	{
		this.b = new e6z(A_0);
		this.a = A_1;
	}

	// Token: 0x06005AA3 RID: 23203 RVA: 0x0027174C File Offset: 0x0026F94C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.b != null && this.b.ao() != null && this.a != null && this.a.j != cgy.b)
		{
			this.b.ao().a(this.a);
		}
	}

	// Token: 0x04002445 RID: 9285
	private new c5x a;

	// Token: 0x04002446 RID: 9286
	private e6z b;
}
