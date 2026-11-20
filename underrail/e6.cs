using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020012F9 RID: 4857
[eiz("MAEA")]
[a(typeof(j7))]
[Serializable]
public sealed class e6 : j7, ISerializable
{
	// Token: 0x06006C01 RID: 27649 RVA: 0x002D566C File Offset: 0x002D386C
	private e6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MAEA:I");
		this.b = A_0.GetString("MAEA:N");
		this.c = A_0.GetString("MAEA:P");
		this.d = (A_0.GetValue("MAEA:C", typeof(Color?)) as Color?);
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x002D56DC File Offset: 0x002D38DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MAEA:I", this.a);
		info.AddValue("MAEA:N", this.b);
		info.AddValue("MAEA:P", this.c);
		info.AddValue("MAEA:C", this.d);
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x002D573C File Offset: 0x002D393C
	public override string e9()
	{
		return this.a;
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x002D5744 File Offset: 0x002D3944
	public override string fa()
	{
		return this.b;
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x002D574C File Offset: 0x002D394C
	public override string fb()
	{
		return this.c;
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x002D5754 File Offset: 0x002D3954
	public override Color? fc()
	{
		return this.d;
	}

	// Token: 0x06006C07 RID: 27655 RVA: 0x002D575C File Offset: 0x002D395C
	public override string fd()
	{
		return null;
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x002D5760 File Offset: 0x002D3960
	public e6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x002D576C File Offset: 0x002D396C
	public e6(c5x A_0, string A_1 = null, string A_2 = null, string A_3 = null, Color? A_4 = null) : this(A_0)
	{
		this.a = A_1;
		this.b = A_2;
		this.c = A_3;
		this.d = A_4;
	}

	// Token: 0x04002C53 RID: 11347
	private new string a;

	// Token: 0x04002C54 RID: 11348
	private string b;

	// Token: 0x04002C55 RID: 11349
	private string c;

	// Token: 0x04002C56 RID: 11350
	private Color? d;
}
