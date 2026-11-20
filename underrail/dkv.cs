using System;
using System.Runtime.Serialization;

// Token: 0x02001190 RID: 4496
[eiz("SI2")]
[Serializable]
public sealed class dkv : ISerializable
{
	// Token: 0x06005FFD RID: 24573 RVA: 0x0029D578 File Offset: 0x0029B778
	private dkv(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("SI2:ST");
			this.b = A_0.GetInt32("SI2:I");
			return;
		}
		if (base.GetType() == typeof(dkv))
		{
			this.a = A_0.GetString("_ScannerType");
			this.b = A_0.GetInt32("_Interval");
			return;
		}
		this.a = A_0.GetString("ScannerInfo+_ScannerType");
		this.b = A_0.GetInt32("ScannerInfo+_Interval");
	}

	// Token: 0x06005FFE RID: 24574 RVA: 0x0029D618 File Offset: 0x0029B818
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SI2:ST", this.a);
		info.AddValue("SI2:I", this.b);
	}

	// Token: 0x06005FFF RID: 24575 RVA: 0x0029D63C File Offset: 0x0029B83C
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006000 RID: 24576 RVA: 0x0029D644 File Offset: 0x0029B844
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006001 RID: 24577 RVA: 0x0029D650 File Offset: 0x0029B850
	public int b()
	{
		return this.b;
	}

	// Token: 0x06006002 RID: 24578 RVA: 0x0029D658 File Offset: 0x0029B858
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006003 RID: 24579 RVA: 0x0029D664 File Offset: 0x0029B864
	public dkv()
	{
	}

	// Token: 0x06006004 RID: 24580 RVA: 0x0029D66C File Offset: 0x0029B86C
	public dkv(string A_0, int A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06006005 RID: 24581 RVA: 0x0029D684 File Offset: 0x0029B884
	public override string ToString()
	{
		return string.Format("{0} каждые {1}", this.a, this.b);
	}

	// Token: 0x0400284C RID: 10316
	private string a;

	// Token: 0x0400284D RID: 10317
	private int b;
}
