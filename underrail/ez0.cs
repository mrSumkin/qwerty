using System;
using System.Runtime.Serialization;

// Token: 0x0200118F RID: 4495
[eiz("SC2")]
[Serializable]
public sealed class ez0 : ISerializable
{
	// Token: 0x06005FF7 RID: 24567 RVA: 0x0029D3A0 File Offset: 0x0029B5A0
	private ez0(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("SC2:I");
			this.b = (ot)A_0.GetValue("SC2:S", typeof(ot));
			this.c = A_0.GetDouble("SC2:TC");
			return;
		}
		if (base.GetType() == typeof(ez0))
		{
			this.a = A_0.GetInt32("_Interval");
			this.b = (ot)A_0.GetValue("_Scanner", typeof(ot));
			this.c = A_0.GetDouble("_TimeCache");
			return;
		}
		this.a = A_0.GetInt32("ScannerContainer+_Interval");
		this.b = (ot)A_0.GetValue("ScannerContainer+_Scanner", typeof(ot));
		this.c = A_0.GetDouble("ScannerContainer+_TimeCache");
	}

	// Token: 0x06005FF8 RID: 24568 RVA: 0x0029D4A0 File Offset: 0x0029B6A0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SC2:I", this.a);
		info.AddValue("SC2:S", this.b);
		info.AddValue("SC2:TC", this.c);
	}

	// Token: 0x06005FF9 RID: 24569 RVA: 0x0029D4D8 File Offset: 0x0029B6D8
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005FFA RID: 24570 RVA: 0x0029D4E0 File Offset: 0x0029B6E0
	public ot b()
	{
		return this.b;
	}

	// Token: 0x06005FFB RID: 24571 RVA: 0x0029D4E8 File Offset: 0x0029B6E8
	public ez0(ot A_0, int A_1)
	{
		this.b = A_0;
		this.a = A_1;
	}

	// Token: 0x06005FFC RID: 24572 RVA: 0x0029D500 File Offset: 0x0029B700
	public void a(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		if (this.b != null && this.a > 0 && (this.c += (double)A_2.Milliseconds) >= (double)this.a)
		{
			this.c -= (double)this.a;
			this.b.abi(A_0, A_1, TimeSpan.FromMilliseconds((double)this.a));
		}
	}

	// Token: 0x04002849 RID: 10313
	private int a;

	// Token: 0x0400284A RID: 10314
	private ot b;

	// Token: 0x0400284B RID: 10315
	private double c;
}
