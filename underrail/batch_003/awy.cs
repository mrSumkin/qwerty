using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012AB RID: 4779
[eiz("SHWEA")]
[Serializable]
public sealed class awy : Aspect<c5x>, ISerializable
{
	// Token: 0x060068CD RID: 26829 RVA: 0x002C4750 File Offset: 0x002C2950
	private awy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("SHWEA:E");
		this.b = A_0.GetString("SHWEA:C");
	}

	// Token: 0x060068CE RID: 26830 RVA: 0x002C478C File Offset: 0x002C298C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SHWEA:E", this.a);
		info.AddValue("SHWEA:C", this.b);
	}

	// Token: 0x060068CF RID: 26831 RVA: 0x002C47B8 File Offset: 0x002C29B8
	public double b()
	{
		return this.a;
	}

	// Token: 0x060068D0 RID: 26832 RVA: 0x002C47C0 File Offset: 0x002C29C0
	public void a(double A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060068D1 RID: 26833 RVA: 0x002C47CC File Offset: 0x002C29CC
	public string a()
	{
		return this.b;
	}

	// Token: 0x060068D2 RID: 26834 RVA: 0x002C47D4 File Offset: 0x002C29D4
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060068D3 RID: 26835 RVA: 0x002C47E0 File Offset: 0x002C29E0
	public awy(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002B4E RID: 11086
	private double a = 1.0;

	// Token: 0x04002B4F RID: 11087
	private string b;
}
