using System;
using System.Runtime.Serialization;

// Token: 0x020000D4 RID: 212
[eiz("BCHFS")]
[Serializable]
public sealed class b1c : ISerializable
{
	// Token: 0x060004A3 RID: 1187 RVA: 0x00014D64 File Offset: 0x00012F64
	private b1c(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt64("BCHFS:S");
		this.b = A_0.GetInt64("BCHFS:L");
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00014D90 File Offset: 0x00012F90
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("BCHFS:S", this.a);
		info.AddValue("BCHFS:L", this.b);
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00014DB4 File Offset: 0x00012FB4
	public b1c()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00014DBC File Offset: 0x00012FBC
	public b1c(long A_0, long A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00014DD4 File Offset: 0x00012FD4
	public override string ToString()
	{
		return string.Format("{0}-{1}", this.a, this.a + this.b);
	}

	// Token: 0x04000455 RID: 1109
	public long a;

	// Token: 0x04000456 RID: 1110
	public long b;
}
