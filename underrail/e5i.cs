using System;
using System.Runtime.Serialization;

// Token: 0x020004DA RID: 1242
[eiz("R04")]
[Serializable]
public sealed class e5i : dnh, ISerializable
{
	// Token: 0x06001FF2 RID: 8178 RVA: 0x000AE9A4 File Offset: 0x000ACBA4
	private e5i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("R04:M");
		this.b = A_0.GetInt32("R04:X");
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000AE9D0 File Offset: 0x000ACBD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R04:M", this.a);
		info.AddValue("R04:X", this.b);
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000AE9FC File Offset: 0x000ACBFC
	public int b()
	{
		return this.a;
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000AEA04 File Offset: 0x000ACC04
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000AEA10 File Offset: 0x000ACC10
	public int a()
	{
		return this.b;
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x000AEA18 File Offset: 0x000ACC18
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000AEA24 File Offset: 0x000ACC24
	public e5i()
	{
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000AEA30 File Offset: 0x000ACC30
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			int value = A_1.GetPrimitivePropertyValue<int>("rndInt", new int?(0)).Value;
			return value >= this.b() && value <= this.a();
		}
		return false;
	}

	// Token: 0x040013F2 RID: 5106
	private int a;

	// Token: 0x040013F3 RID: 5107
	private int b;
}
