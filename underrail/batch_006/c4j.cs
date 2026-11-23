using System;
using System.Runtime.Serialization;

// Token: 0x02001911 RID: 6417
[eiz("T5")]
[Serializable]
public sealed class c4j : dj3
{
	// Token: 0x06008846 RID: 34886 RVA: 0x00386790 File Offset: 0x00384990
	private c4j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 124)
		{
			this.a = A_0.GetInt32("T5:S");
			this.b = A_0.GetDouble("T5:D");
		}
	}

	// Token: 0x06008847 RID: 34887 RVA: 0x003867EC File Offset: 0x003849EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("T5:S", this.a);
		info.AddValue("T5:D", this.b);
	}

	// Token: 0x06008848 RID: 34888 RVA: 0x00386818 File Offset: 0x00384A18
	public override string tv()
	{
		return "Ловушка";
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x00386820 File Offset: 0x00384A20
	public int b()
	{
		return this.a;
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x00386828 File Offset: 0x00384A28
	public new void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x00386834 File Offset: 0x00384A34
	public new double a()
	{
		return this.b;
	}

	// Token: 0x0600884C RID: 34892 RVA: 0x0038683C File Offset: 0x00384A3C
	public new void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600884D RID: 34893 RVA: 0x00386848 File Offset: 0x00384A48
	public c4j()
	{
	}

	// Token: 0x04003670 RID: 13936
	private new int a = 5;

	// Token: 0x04003671 RID: 13937
	private double b = 1.0;
}
