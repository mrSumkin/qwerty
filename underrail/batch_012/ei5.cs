using System;
using System.Runtime.Serialization;

// Token: 0x020000D8 RID: 216
[eiz("BSII")]
[Serializable]
public sealed class ei5 : ISerializable
{
	// Token: 0x060004BF RID: 1215 RVA: 0x000158EC File Offset: 0x00013AEC
	private ei5(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("BSII:N");
		this.b = A_0.GetInt32("BSII:C");
		this.c = A_0.GetInt64("BSII:S");
		this.d = A_0.GetInt64("BSII:L");
		if (ell.b() >= 29)
		{
			this.e = (A_0.GetValue("BSII:X", typeof(bool?)) as bool?);
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00015974 File Offset: 0x00013B74
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("BSII:N", this.a);
		info.AddValue("BSII:C", this.b);
		info.AddValue("BSII:S", this.c);
		info.AddValue("BSII:L", this.d);
		info.AddValue("BSII:X", this.e);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x000159DC File Offset: 0x00013BDC
	public ei5()
	{
	}

	// Token: 0x0400045C RID: 1116
	public string a;

	// Token: 0x0400045D RID: 1117
	public int b;

	// Token: 0x0400045E RID: 1118
	public long c;

	// Token: 0x0400045F RID: 1119
	public long d;

	// Token: 0x04000460 RID: 1120
	public bool? e;
}
